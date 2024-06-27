namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "Hello, World!";
            Stream stream = new CompressedStream(new EncryptedStream(new CloudStream()));
            stream.Write(data);
            Console.WriteLine();
        }
    }
}
