using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ListIterator<T> : IIterator<T>
    {
        private List<T> urls;
        private int currentIndex { get; set; } = 0;

        public ListIterator(List<T> urls)
        {
            this.urls = urls;
        }

        public T Current()
        {
            return urls[currentIndex];
        }

        public void Next()
        {
            currentIndex++;
        }

        public bool IsDone()
        {
            return currentIndex == urls.Count;
        }

        public bool HasNext()
        {
            return currentIndex < urls.Count;
        }
    }
}
