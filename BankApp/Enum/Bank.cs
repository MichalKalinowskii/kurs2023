using BankApp.Helper;
using BankApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Enum
{
    public enum Bank
	{
		Bank1,
		Bank2
	}
	static class BankMethod
	{
		public static IBankHelper GetBank(this Bank bank)
		{
			switch (bank)
			{
				case Bank.Bank1:
					return new Bank1Helper();
				case Bank.Bank2:
					return new Bank2Helper();
				default:
					return null;
			}
		}
	}
}
