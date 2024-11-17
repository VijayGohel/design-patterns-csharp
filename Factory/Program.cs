namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController controller = new ProductController();
            controller.ListProducts();
        }
    }
}
