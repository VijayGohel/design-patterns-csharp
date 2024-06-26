namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnchorNode anchorNode = new AnchorNode();
            HeadingNode headingNode = new HeadingNode();
            HtmlDocument document = new HtmlDocument();
            document.Add(anchorNode);
            document.Add(headingNode);
            document.Execute(new PlainTextOperation());
            Console.ReadLine();
        }
    }
}
