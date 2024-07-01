using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Connection
    {
        public void Disconnect()
        {
            Console.WriteLine("Disconnecting...");
        }
    }
}
