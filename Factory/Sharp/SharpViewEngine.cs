using Factory.Matcha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Sharp
{
    internal class SharpViewEngine : ViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View rendered by Sharp view engine";
        }
    }
}
