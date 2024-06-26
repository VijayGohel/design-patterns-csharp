using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Boolean valid = request.UserName == "Admin" && request.Password == "Pass";
            Console.WriteLine("Authenticating");
            return !valid;
        }
    }
}
