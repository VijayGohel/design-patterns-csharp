using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Matcha;

namespace Factory.Sharp
{
    internal class SharpController : Controller
    {
        protected override ViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
