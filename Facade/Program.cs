namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();
            notificationService.Send("Hello!!", "target");
        }
    }
}
