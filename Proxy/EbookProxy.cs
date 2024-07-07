using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class EbookProxy : Ebook
    {
        private Ebook realEbook;
        private string fileName;

        public EbookProxy(string fileName)
        {
            this.fileName = fileName;
        }

        public string GetFileName()
        {
            return fileName;
        }

        public void Show()
        {
            if (realEbook == null)
            {
                realEbook = new RealEbook(fileName);
            }

            realEbook.Show();
        }
    }
}
