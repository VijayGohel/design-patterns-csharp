using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class RealEbook : Ebook
    {
        private string fileName;

        public RealEbook(string fileName)
        {
            this.fileName = fileName;
            Load(); 
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            Console.WriteLine($"Showing file: {fileName}");
        }

        public void Load()
        {
            Console.WriteLine($"Loading file: {fileName}");
        }
    }
}
