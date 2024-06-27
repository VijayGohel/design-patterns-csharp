namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImageView imageView = new(new Image());
            imageView.Apply(new VividFilter());
            imageView.Apply(new CaramelFilter(new AvaFilter.Caramel()));
            imageView.Apply(new CaramelAdapter());
            Console.ReadLine();
        }
    }
}
