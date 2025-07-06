using GestaoDeVendas.Domain.Entities;

namespace TestCommonUtilities.Entities;
public class ProductsListBuilder
{
	public static List<Product> Build()
	{
        List<Product> products = [];
		
		for (int i = 0; i < 3; i++)
        {
			products.Add(ProductBuilder.Build());
		}

		return products;
    }
}
