using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class SonyTv : Device
    {
        public void ChangeChannel(int channel)
        {
            Console.WriteLine("Changing channel for SonyTV");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off SonyTV");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on SonyTV");
        }
    }
}
