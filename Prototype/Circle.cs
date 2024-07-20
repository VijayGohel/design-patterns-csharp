using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Circle : Component
    {
        private int radius;
        private string color;

        public Circle() { }

        public Circle(Circle circle)
        {
            this.color = circle.color;
            this.radius = circle.radius;
        }

        public Component Clone()
        {
            return new Circle(this);
        }

        public void Render()
        {
            Console.WriteLine("rendering circle...");
        }
    }
}
