using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class AdvanceRemoteControl : RemoteControl
    {
        public AdvanceRemoteControl(Device device) : base(device)
        {
        }

        public void ChangeChannel(int channel)
        {
            device.ChangeChannel(channel);
        }
    }
}
