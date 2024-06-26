using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class HtmlDocument
    {
        List<HtmlNode> nodes = new List<HtmlNode>();

        public void Add(HtmlNode node)
        {
            nodes.Add(node);
        }
        public void Execute(Operation operation)
        {
            foreach (var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
