namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component circle = new Circle();
            Component newCircle = circle.Clone();

            Component rectangle = new Rectangle();
            Component newRectangle = rectangle.Clone();

            Console.ReadLine();
        }
    }
}
