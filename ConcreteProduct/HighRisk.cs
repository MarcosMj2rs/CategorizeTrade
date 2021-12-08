using CategorizeTrade.Product;

namespace CategorizeTrade.ConcreteProduct
{
	public class HighRisk : Category
	{
		private readonly string _categoryDescription;

		public HighRisk()
		{
			_categoryDescription = "HIGHRISK";
		}

		public override string Description { get => _categoryDescription; }
	}
}
