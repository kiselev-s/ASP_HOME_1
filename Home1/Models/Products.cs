using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home1.Models
{
    public class Products
    {
        List<Product> product;
        public List<Product> DisplayedPeople { get; set; }
        public Products()
        {
            product = new List<Product>()
            {
                new Product {Name = "Gala", Price=100},
                new Product {Name = "Sarma", Price=250},
                new Product {Name = "Fairy", Price=123},
                new Product {Name = "Dave", Price=205}
            };
        }

        public List<Product> GetProducts()
        {
            return product;
        }

        public void OnGet()
        {
            DisplayedPeople = product;
        }
        public void OnPostGreaterThan(int price)
        {
            DisplayedPeople = product.Where(p => p.Price > price).ToList();
        }
        public void OnPostLessThan(int price)
        {
            DisplayedPeople = product.Where(p => p.Price < price).ToList();
        }
    }
}
