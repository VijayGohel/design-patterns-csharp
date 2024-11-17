using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Movie
    {
        public void AddFrame(string text, int duration)
        {
            Console.WriteLine($"adding {text} to movie frame");
        }
    }
}
