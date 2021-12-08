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
		public override Category CategorizeTrade(ProductInput productInput)
		{
			CultureInfo ci = new CultureInfo("en-US");
			Thread.CurrentThread.CurrentCulture = ci;

			if(productInput.DataRef.Date > productInput.NextPaymentDate.Date.AddDays(-30))
			{	
				return new Expired();
			}
			else if(Convert.ToDouble(productInput.Value) > 1000000 && string.Compare(productInput.ClientSector, "Private", true) == 0)
			{
				return new HighRisk();
			}
			else if(Convert.ToDouble(productInput.Value) > 1000000 && string.Compare(productInput.ClientSector, "Public", true) == 0)
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
