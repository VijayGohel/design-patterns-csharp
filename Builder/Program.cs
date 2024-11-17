namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Presentation presentation = new Presentation();
            presentation.AddSlide(new Slide("slide 1"));
            presentation.AddSlide(new Slide("slide 2"));

            presentation.Export(new MovieBuilder());
        }
    }
}
