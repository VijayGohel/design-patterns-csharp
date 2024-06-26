using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class HighlightOperation : Operation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Highlighting Anchor node");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Highlighting Heading node");
        }
    }
}
