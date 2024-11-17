using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Matcha
{
    internal class Controller
    {
        protected void Render(string viewName, Dictionary<string, object> context)
        {
            ViewEngine viewEngine = CreateViewEngine();
            string html = viewEngine.Render(viewName, context);
            Console.WriteLine(html);
        }

        protected virtual ViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
