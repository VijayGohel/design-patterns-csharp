using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Flyweight.Enums;

namespace Flyweight
{
    internal class PointIcon
    {
        private readonly PointType pointType;
        private readonly byte[] icon;
        public PointIcon(PointType pointType, byte[] icon)
        {
            this.pointType = pointType;
            this.icon = icon;
        }

        public PointType GetPointType()
        {
            return pointType;
        }
    }
}
