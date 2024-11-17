using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Matcha;
using Factory.Sharp;

namespace Factory
{
    internal class ProductController : SharpController
    {
        public void ListProducts()
        {
            //Get products from DB
            Dictionary<string, object> context = new Dictionary<string, object>();
            Render("products.html", context);
        }
    }
}
