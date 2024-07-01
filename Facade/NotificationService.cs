using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class NotificationService
    {
        public void Send(string message, string target)
        {
            var notificationServer = new NotificationServer();
            var connection = notificationServer.Connect("ip");
            var authToken = notificationServer.Authenticate("AppId", "Key");
            notificationServer.Send(new Message(message), target, authToken);
            connection.Disconnect();
        }
    }
}
