using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Flyweight.Enums;

namespace Flyweight
{
    internal class PointService
    {
        private PointIconFactory _iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            _iconFactory = iconFactory;
        }

        public List<Point> GetPoints(List<Cordinates> cordinates, PointType pointType)
        {
            List<Point> points = new List<Point>();
            PointIcon pointIcon = _iconFactory.GetPointIcon(pointType);
            foreach (var cordinate in cordinates)
            {
                Point point = new Point(cordinate.x, cordinate.y, pointIcon);
                points.Add(point);
            }
            return points;
        }

        public void Draw(List<Point> points)
        {
            foreach (var point in points)
            {
                point.Draw();
            }
        }
    }
}
