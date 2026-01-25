using Lesson5_asp_hw.Helpers;
using Lesson5_asp_hw.Services.Abstracts;
using Lesson5_asp_hw.Models;

namespace Lesson5_asp_hw.Services.Concretes
{
    public class ProductRepository : IRepository
    {
        public List<Product> Products =ProductHelper.products;

        public bool Add(Product product)
        {
            var isExists = Products.Any(p => p.Id == product.Id);
            if (isExists)
            {
                return false;
            }
            product.Id = Products.Count > 0 ? Products.Max(p => p.Id) + 1 : 1;
            Products.Add(product);
            return true;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return Products;
        }
        public Product GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> GetProductsByPrice(decimal minPrice, decimal maxPrice)
        {
            return Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        }

        public bool Remove(int id)
        {
            var IsExists = Products.FirstOrDefault(p => p.Id == id);
            if (IsExists == null)
            {
                return false;
            }
            Products.Remove(IsExists);
            return true;
        }
    }
}
