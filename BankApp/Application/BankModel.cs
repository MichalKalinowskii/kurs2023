using BankApp.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Model
{
	public interface IBankModel
	{
		double GetCommison(double summaryPrice);
		PaymentMethods AcceptablePaymentMetod { get; }
	}
}
