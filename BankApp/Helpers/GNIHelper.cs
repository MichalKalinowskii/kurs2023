using BankApp.Enum;
using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Helper
{
    public class GNIHelper : IBankModel
    {
        private double _summaryPrice;

        public double Commission
        {
            get
            {
                return 1.5;
            }
        }
        public PaymentMethods AcceptablePaymentMetod
        {
            get
            {
                return PaymentMethods.Blik;
            }
        }

        public double GetCommison(double summaryPrice)
        {
            _summaryPrice = summaryPrice;
            return Commission;
        }
    }
}
