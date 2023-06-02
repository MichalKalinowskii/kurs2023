using BankApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
	public class Cart
	{
		public List<Product> Products { get; set; } = new List<Product>();
		public Bank Bank { get; set; }
		public PaymentMethods PaymentMethod { get; set; }
	}
}
