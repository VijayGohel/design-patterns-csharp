using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Library
    {
        Dictionary<string, Ebook> ebooks = new Dictionary<string, Ebook>();

        public void OpenBook(string fileName)
        {
            ebooks[fileName].Show();
        }

        public void AddBook(Ebook book) 
        {
            ebooks.Add(book.GetFileName(), book);
        }
    }
}
