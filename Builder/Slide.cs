using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Slide
    {
        public string text { get; set; }
        public Slide(string text) 
        {
            this.text = text;
        }
    }
}
