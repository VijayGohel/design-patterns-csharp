using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DeleteCustomerCommand : ICommand
    {
        private readonly CustomerService _customerService;

        public DeleteCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.DeleteCustomer();
        }
    }
}
