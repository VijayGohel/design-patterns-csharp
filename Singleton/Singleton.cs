using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        public string value {  get; private set; }

        private static readonly object _lock = new object();

        private Singleton() { }

        public static Singleton GetSingleton(string value) 
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.value = value;
                    }
                }
            }
            return _instance;
        }

    }
}
