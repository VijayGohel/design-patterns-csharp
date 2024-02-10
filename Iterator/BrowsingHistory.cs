using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class BrowsingHistory<T>
    {
        private List<T> urls = new List<T>();

        public void Push(T item)
        {
            this.urls.Add(item);
        }

        public T Pop()
        {
            int lastIndex = this.urls.Count - 1;
            T lastEle = this.urls[lastIndex];
            urls.RemoveAt(lastIndex);
            return lastEle;
        }

        public IIterator<T> GetIterator()
        {
            return new ListIterator<T>(this.urls);
        }
    }
}
