using CategorizeTrade.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeTrade.Creator
{
	public abstract class CategoryFactoryMethod
	{
		public abstract Category CategorizeTrade(DateTime dateRef, string transaction);
	}
}
