namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => { InstantiateSingleton("t1"); });
            Thread t2 = new Thread(() => { InstantiateSingleton("t2"); });
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        public static void InstantiateSingleton(string value)
        {
            Singleton singleton = Singleton.GetSingleton(value);
            Console.WriteLine(singleton.value);
        }
    }
}
