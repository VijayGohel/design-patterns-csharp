using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Flyweight.Enums;

namespace Flyweight
{
    internal class PointIconFactory
    {
        Dictionary<PointType, PointIcon> pointIcons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType type)
        {
            if(!pointIcons.ContainsKey(type))
            {
                pointIcons.Add(type, new PointIcon(type, null));
            }

            return pointIcons[type];
        }
    }
}
