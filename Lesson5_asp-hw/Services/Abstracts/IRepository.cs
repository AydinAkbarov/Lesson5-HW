using Lesson5_asp_hw.Models;

namespace Lesson5_asp_hw.Services.Abstracts;

public interface IRepository
{
    bool Add(Product product);
    bool Remove(int id);
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(int id);
    List<Product> GetProductsByPrice(decimal min, decimal max);
}
