using BankApp.Enum;
using BankApp.Interfaces;
using BankApp.Model;

namespace BankApp
{
    internal class Program
	{
		static void Main(string[] args)
		{
			Product tire = new Product()
			{
				Name = "Opona",
				Desc = "Z magazynu Oponeo",
				Price = 200,
			};
			Product tpms = new Product()
			{
				Name = "TPMS",
				Desc = "Z magazynu Oponeo",
				Price = 30,
			};


			Cart cart = new();

			cart.Bank = Bank.Bank2;
			cart.PaymentMethod = PaymentMethods.Blik;
			cart.Products.Add(tire);

			MakePurchaseFactory(cart);
		}


		static void MakePurchaseFactory(Cart cart)
		{
			double summaryPrice = 0;

			foreach (var product in cart.Products)
			{
				summaryPrice += product.Price;
			}
			if(cart.Bank.GetBank() != null)
			{
				GetResult(cart.Bank.GetBank(), cart.PaymentMethod, summaryPrice);
			}
			
		}

		static void GetResult(IBankHelper bank, PaymentMethods cartPayment, double summaryPrice)
		{
			if (cartPayment != bank.AcceptablePaymentMetod) return;
			double commison = bank.GetCommison(summaryPrice);
			Console.WriteLine($"{summaryPrice + summaryPrice * commison / 100}");
		}
	}
}