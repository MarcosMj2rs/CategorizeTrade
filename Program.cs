using CategorizeTrade.ConcreteCreator;
using CategorizeTrade.Product;
using System;
using System.Globalization;
using System.Threading;

namespace CategorizeTrade
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Hit enter to continue...");
				Console.ReadLine();

				CultureInfo ci = new CultureInfo("en-US");
				Thread.CurrentThread.CurrentCulture = ci;

				ProductInput productInput = new ProductInput();
				productInput.DataRef = Convert.ToDateTime("12/11/2020");
				productInput.countTrade = 4;
				productInput.Transaction.Add("2000000 Private 12/29/2025");
				productInput.Transaction.Add("400000 Public 07/01/2020");
				productInput.Transaction.Add("5000000 Public 01/02/2024");
				productInput.Transaction.Add("3000000 Public 10/26/2023");


				CategoryFactory factory = new CategoryFactory();

				foreach(var item in productInput.Transaction)
				{
					productInput.Value = Convert.ToDouble(item.Split(" ")[0]);
					productInput.ClientSector = item.Split(" ")[1].Trim();
					productInput.NextPaymentDate = Convert.ToDateTime(item.Split(" ")[2]);

					Console.WriteLine(factory.CategorizeTrade(productInput).Description);
				}
			}
			catch(Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
