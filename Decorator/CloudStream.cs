using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine($"Wrting data to the cloud: {data}");
        }
    }
}
