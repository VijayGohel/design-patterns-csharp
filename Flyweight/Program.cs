namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PointService pointService = new PointService(new PointIconFactory());
            List<Cordinates> cordinates = new List<Cordinates>();
            cordinates.Add(new Cordinates(1, 2));
            cordinates.Add(new Cordinates(3, 5));
            List<Point> points = pointService.GetPoints(cordinates, Enums.PointType.HOSPITALS);
            pointService.Draw(points);
        }
    }
}
