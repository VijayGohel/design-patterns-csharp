using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class TextBox : UIControl
    {
        private string _content = string.Empty;

        public string Content { get => _content; set { _content = value; } }
    }
}
