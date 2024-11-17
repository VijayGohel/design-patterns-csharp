using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ant
{
    internal class AntButton : Button
    {
        public void Render()
        {
            Console.WriteLine("Ant button");
        }
    }
}
