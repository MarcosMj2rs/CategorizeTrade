using CategorizeTrade.Product;

namespace CategorizeTrade.ConcreteProduct
{
	public class MediumRisk : Category
	{
		private readonly string _categoryDescription;

		public MediumRisk()
		{
			_categoryDescription = "MEDIUMRISK";
		}

		public override string Description { get => _categoryDescription; }
	}
}
