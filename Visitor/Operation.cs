using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface Operation
    {
        void Apply(AnchorNode node);
        void Apply(HeadingNode node);
    }
}
