using System;
using System.Collections.Generic;

namespace CategorizeTrade.Interface
{
	public interface ITrade
	{
		double Value { get; }

		string ClientSector { get; }

		DateTime NestpaymentDate { get; }

	}
}
