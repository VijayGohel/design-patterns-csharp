namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device device = new SamsungTv();
            var remoteControl = new RemoteControl(device);
            remoteControl.TurnOn();
            remoteControl.TurnOff();
            Console.ReadLine();
        }
    }
}
