using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Home1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Home1.Pages
{
    public class ProductsModel : PageModel
    {

        public List<Product> product;
        public Products prod = new Products();

        public void OnGet()
        {
            product = prod.GetProducts();
        }
    }
}
