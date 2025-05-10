namespace BackgroundForegroundThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() => {
                while (true)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Heartbeat");
                }
            });
            t.IsBackground = true;
            t.Start();
            Thread.Sleep(5000);
        }
    }
}
