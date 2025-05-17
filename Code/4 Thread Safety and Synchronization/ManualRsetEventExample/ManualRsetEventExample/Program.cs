using System;
using System.Threading;

class Program
{
    static ManualResetEvent gate = new ManualResetEvent(false); // Initially closed

    static void Worker(object id)
    {
        Console.WriteLine($"Thread {id} is waiting at the gate...");
        gate.WaitOne(); // Wait until the gate is opened
        Console.WriteLine($"Thread {id} passed through the gate.");
    }

    static void Main()
    {
        for (int i = 1; i <= 3; i++)
        {
            new Thread(Worker).Start(i);
        }

        Thread.Sleep(2000); // Give time for threads to start and wait

        Console.WriteLine("Main thread opens the gate...");
        gate.Set(); // Open the gate – all waiting threads proceed

        Thread.Sleep(2000); // Let them all go through

        Console.WriteLine("Main thread closes the gate...");
        gate.Reset(); // Close the gate again

        new Thread(Worker).Start(4); // Thread 4 will now wait

        Thread.Sleep(2000);

        Console.WriteLine("Main thread opens the gate again...");
        gate.Set(); // Allow thread 4 to proceed
    }
}
