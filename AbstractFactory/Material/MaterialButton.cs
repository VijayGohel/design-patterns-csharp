using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Material
{
    internal class MaterialButton : Button
    {
        public void Render()
        {
            Console.WriteLine("Material button");
        }
    }
}
