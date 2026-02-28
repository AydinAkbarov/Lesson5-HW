using Lesson5_asp_hw.Helpers;
using Lesson5_asp_hw.Models;
using Lesson5_asp_hw.Services.Abstracts;

namespace Lesson5_asp_hw.Services.Concretes;

public class ProductRepository : IRepository
{
    public List<Product> Products = ProductHelper.products;

    public bool Add(Product product)
    {
        if (Products.Any(x => x.Id == product.Id))
            return false;

        product.Id = Products.Count == 0 ? 1 : Products.Max(x => x.Id) + 1;
        Products.Add(product);

        return true;
    }

    public IEnumerable<Product> GetAllProducts() => Products;

    public Product GetProductById(int id) =>
        Products.FirstOrDefault(x => x.Id == id);

    public List<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice) =>
        Products.Where(x => x.Price >= minPrice && x.Price <= maxPrice).ToList();

    public bool Remove(int id)
    {
        var item = Products.FirstOrDefault(x => x.Id == id);
        if (item is null)
            return false;

        Products.Remove(item);
        return true;
    }
}
