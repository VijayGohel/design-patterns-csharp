using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ListBox : UIControl
    {
        private string _selection = string.Empty;

        public string Selection { get => _selection; set { _selection = value; this.NotifyAllObservers(); } }
    }
}
