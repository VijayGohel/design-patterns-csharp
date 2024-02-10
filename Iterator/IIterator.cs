using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface IIterator<T>
    {
        void Next();
        T Current();
        bool IsDone(); 
        bool HasNext();
    }
}
