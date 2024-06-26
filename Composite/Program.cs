namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group1 = new Group();
            group1.Add(new Shape());
            group1.Add(new Shape());
            
            Group group2 = new Group();
            group2.Add(new Shape());
            group2.Add(new Shape());

            Group group3 = new Group();
            group3.Add(group1);
            group3.Add(group2);

            group3.Render();
            Console.ReadLine();
        }
    }
}
