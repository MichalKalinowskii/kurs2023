﻿using BankApp.Enum;
using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Helper
{
    public class OKPHelper : IBankModel
    {

        private double _summaryPrice;

        private double Commission
        {
            get
            {
                if (_summaryPrice > 50) return 1;
                return 2;
            }
        }
        public PaymentMethods AcceptablePaymentMetod
        {
            get
            {
                return PaymentMethods.Przelewy24;
            }
        }

        public double GetCommison(double summaryPrice)
        {
            _summaryPrice = summaryPrice;
            return Commission;
        }
    }
}
