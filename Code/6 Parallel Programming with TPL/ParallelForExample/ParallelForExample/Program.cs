using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        const int iterations = 10;

        // Normal for loop
        Stopwatch sw1 = Stopwatch.StartNew();

        for (int i = 0; i < iterations; i++)
        {
            DoHeavyWork(i);
        }

        sw1.Stop();
        Console.WriteLine($"Regular for loop time: {sw1.ElapsedMilliseconds} ms");

        // Parallel.For loop
        Stopwatch sw2 = Stopwatch.StartNew();

        Parallel.For(0, iterations, i =>
        {
            DoHeavyWork(i);
        });

        sw2.Stop();
        Console.WriteLine($"Parallel.For loop time: {sw2.ElapsedMilliseconds} ms");
    }

    static void DoHeavyWork(int i)
    {
        double result = 0;
        for (int j = 0; j < 10_000_000; j++)
        {
            result += Math.Sqrt(j + i);
        }
        // Just to prevent optimization
        Console.WriteLine($"Work {i} done on thread {Thread.CurrentThread.ManagedThreadId}");
    }
}
