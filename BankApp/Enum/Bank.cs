using BankApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Enum
{
	public enum Bank
	{
		OKP,
		GNI
	}
	static class BankMethod
	{
		public static IBankModel GetBank(this Bank bank)
		{
			switch (bank)
			{
				case Bank.OKP:
					return new OKPHelper();
				case Bank.GNI:
					return new GNIHelper();
				default:
					return null;
			}
		}
	}
}
