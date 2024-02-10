using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrowsingHistory<string> history = new BrowsingHistory<string>();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            IIterator<string> iterator = history.GetIterator();

            while(iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }

            Console.ReadLine();
        }
    }
}
