using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class PlainTextOperation : Operation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Plain text Anchor node");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Plain text Heading node");
        }
    }
}
