using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class DataSource : Subject
    {
        private int _value = 0;
        
        public int value { get { return _value; } set { _value = value; NotifyAllObservers(); } }
    }
}
