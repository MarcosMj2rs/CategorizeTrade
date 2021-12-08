using CategorizeTrade.Interface;
using System;
using System.Collections.Generic;

namespace CategorizeTrade
{
	public class ProductInput : ITrade
	{
		public double Value { get; set; }

		public string ClientSector { get; set; }

		public DateTime NextPaymentDate { get; set; }

		public DateTime DataRef { get; set; }

		public int countTrade { get; set; }

		public List<string> Transaction { get; set; } = new List<string>();

	}
}
