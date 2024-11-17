using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class PDFDocument
    {
        public void AddText(string text)
        {
            Console.WriteLine($"Adding {text} to PDF");
        }
    }
}
