using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black & White command");
        }
    }
}
