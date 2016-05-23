using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication4.Models.EF;

namespace WebApplication4.Models.Repository
{
    public class ProductRepository : IProductRepository
    {
        EfDbContext _context = new EfDbContext();

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            SaveProduct();
        }

        public void DeleteProduct(string id)
        {
            Product product = _context.Products.Find(id);
            _context.Products.Remove(product);
            SaveProduct();
        }

        public void EditProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            SaveProduct();
        }

        public List<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetProductByID(string id)
        {
            return _context.Products.Find(id);
        }

        public void SaveProduct()
        {
            _context.SaveChanges();
        }
    }
}