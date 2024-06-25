using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class TextBox : UIControl
    {
        private string _content = string.Empty;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string Content { get => _content; set { _content = value; this.owner.Changed(this); } }
    }
}
