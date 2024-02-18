using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Button
    {
        private string label { get; }
        private ICommand _command;
        public void Click()
        {
            _command.Execute();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
    }
}
