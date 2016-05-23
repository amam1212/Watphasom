using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication4.Models.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void DeleteProduct(string id);
        void EditProduct(Product product);
        List<Product> GetAllProduct();
        Product GetProductByID(string id);
        void SaveProduct();

    }
}
