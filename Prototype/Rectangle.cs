using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Rectangle : Component
    {
        private int width, height;
        public string color;

        public Rectangle() { }

        public Rectangle(Rectangle rectangle)
        {
            this.width = rectangle.width;
            this.height = rectangle.height;
        }

        public Component Clone()
        {
            return new Rectangle(this);
        }

        public void Render()
        {
            Console.WriteLine("rendering rectangle...");
        }
    }
}
