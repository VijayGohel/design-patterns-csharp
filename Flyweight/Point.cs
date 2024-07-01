using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Point
    {
        private int x, y;
        private PointIcon pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            this.x = x;
            this.y = y;
            this.pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing point on {x}, {y} of type {pointIcon.GetPointType()} ");
        }
    }
}
