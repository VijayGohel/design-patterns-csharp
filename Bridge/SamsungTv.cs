using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class SamsungTv : Device
    {
        public void ChangeChannel(int channel)
        {
            Console.WriteLine("Changing channel for SamsungTV");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off SamsungTV");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on SamsungTV");
        }
    }
}
