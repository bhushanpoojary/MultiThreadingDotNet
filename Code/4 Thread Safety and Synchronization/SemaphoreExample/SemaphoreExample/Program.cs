using System;
using System.Threading;

class Program
{
    // Allow max 2 threads to enter the printer at once
    static Semaphore semaphore = new Semaphore(2, 2);

    static void PrintJob(object id)
    {
        Console.WriteLine($"Job {id} waiting for printer...");
        semaphore.WaitOne(); // Wait to enter

        Console.WriteLine($"Job {id} is printing...");
        Thread.Sleep(2000); // Simulate print time

        Console.WriteLine($"Job {id} done printing.");
        semaphore.Release(); // Release semaphore
    }

    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            new Thread(PrintJob).Start(i);
        }
    }
}
