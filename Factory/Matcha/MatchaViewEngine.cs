using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Matcha
{
    internal class MatchaViewEngine : ViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> context)
        {
            return "View rendered by Matcha";
        }
    }
}
