using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class HttpRequest
    {
        private string userName, password;

        public HttpRequest(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
