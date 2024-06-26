﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Button : UIControl
    {
        private bool _isEnable = true;

        public bool IsEnable { get => _isEnable; set { _isEnable = value; } }
    }
}
