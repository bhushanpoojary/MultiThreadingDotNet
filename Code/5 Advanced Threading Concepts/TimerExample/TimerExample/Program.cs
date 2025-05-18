using System;
using System.Threading;

class Program
{
    static Timer _timer;

    static void Main()
    {
        // Timer callback every 2 seconds
        _timer = new Timer(DoWork, null, 0, 2000);

        Console.WriteLine("Timer started. Press any key to exit.");
        Console.ReadKey();
    }

    static void DoWork(object state)
    {
        Console.WriteLine($"Work done at: {DateTime.Now}");
    }
}
