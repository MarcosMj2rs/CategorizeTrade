using CategorizeTrade.ConcreteProduct;
using CategorizeTrade.Creator;
using CategorizeTrade.Product;
using System;
using System.Globalization;
using System.Threading;

namespace CategorizeTrade.ConcreteCreator
{
	public class CategoryFactory : CategoryFactoryMethod
	{
		public override Category CategorizeTrade(DateTime dateRef, string transaction)
		{
			CultureInfo ci = new CultureInfo("en-US");
			Thread.CurrentThread.CurrentCulture = ci;
			string[] transactionPart = transaction.Split(" ");
			DateTime dtTransaction = Convert.ToDateTime(transactionPart[2]);

			if(dateRef.Date > dtTransaction.Date.AddDays(-30))
			{	
				return new Expired();
			}
			else if(Convert.ToDouble(transactionPart[0]) > 1000000 && string.Compare(transactionPart[1].Trim().ToUpper(), "Private", true) == 0)
			{
				return new HighRisk();
			}
			else if(Convert.ToDouble(transactionPart[0]) > 1000000 && string.Compare(transactionPart[1].Trim().ToUpper(), "Public", true) == 0)
			{
				return new MediumRisk();
			}
			else
			{
				throw new System.ArgumentException("Category not found");
			}
		}
	}
}
