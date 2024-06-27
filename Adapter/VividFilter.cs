using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class VividFilter : Filter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid filter...");
        }
    }
}
