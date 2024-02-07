using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caretaker caretaker = new Caretaker();
            originator.SetContent("a");
            caretaker.Push(originator.CreateState());
            originator.SetContent("b");
            caretaker.Push(originator.CreateState());
            originator.SetContent("c");
            originator.Restore(caretaker.Pop());

            Console.WriteLine(originator.GetContent());

            Console.ReadLine();
        }
    }
}
