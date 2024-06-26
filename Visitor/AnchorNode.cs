using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class AnchorNode : HtmlNode
    {
        public void Execute(Operation operation)
        {
            operation.Apply(this);
        }
    }
}
