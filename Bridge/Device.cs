﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal interface Device
    {
        void TurnOn();
        void TurnOff();
        void ChangeChannel(int channel);
    }
}
