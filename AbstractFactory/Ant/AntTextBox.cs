using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Ant
{
    internal class AntTextBox : TextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant textbox");
        }
    }
}
