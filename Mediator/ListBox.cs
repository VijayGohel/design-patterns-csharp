using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class ListBox : UIControl
    {
        private string _selection = string.Empty;

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        public string Selection { get => _selection; set { _selection = value; this.owner.Changed(this); } }
    }
}
