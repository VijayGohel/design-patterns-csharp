using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CompositeCommand : ICommand
    {
        List<ICommand> commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach (ICommand command in commands)
            {
                command.Execute();
            }
        }
    }
}
