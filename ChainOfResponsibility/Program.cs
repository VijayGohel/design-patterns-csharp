using ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compressor compressor = new Compressor(null);
            Logger logger = new Logger(compressor);
            Authenticator authenticator = new Authenticator(logger);

            WebServer webServer = new WebServer(authenticator);
            webServer.handle(new HttpRequest("Admin", "Pass"));

            Console.ReadLine();
        }
    }
}

