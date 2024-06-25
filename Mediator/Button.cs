using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Button : UIControl
    {
        private bool _isEnable = true;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool IsEnable { get => _isEnable; set { _isEnable = value; this.owner.Changed(this); } }
    }
}
