using CategorizeTrade.Product;

namespace CategorizeTrade.ConcreteProduct
{
	public class Expired : Category
	{
		private readonly string _categoryDescription;

		public Expired()
		{
			_categoryDescription = "EXPIRED";
		}

		public override string Description { get => _categoryDescription; }
	}
}
