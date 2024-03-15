using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();
            ICommand command = new AddCustomerCommand(customerService);
            Button button = new Button();
            button.SetCommand(command);
            button.Click();
            command = new DeleteCustomerCommand(customerService);
            button.SetCommand(command);
            button.Click();

            ICommand resizeCommand = new ResizeCommand();
            ICommand blackAndWhiteCommand = new BlackAndWhiteCommand();
            CompositeCommand compositeCommand = new CompositeCommand();

            compositeCommand.Add(resizeCommand);
            compositeCommand.Add(blackAndWhiteCommand);
            compositeCommand.Execute();

            Console.ReadLine();
        }
    }
}
