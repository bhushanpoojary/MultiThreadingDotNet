using System.Diagnostics;

namespace _3_Simple_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Fibonacci(40); // +1900 ms
            Fibonacci(39); //+1200 ms
            Fibonacci(41); //+3000 ms
            Fibonacci(40); //+1900 ms
            sw.Stop();
            Console.WriteLine("Sequentially:" + sw.ElapsedMilliseconds);
            sw.Reset();
            sw.Start();
            Task task1 = Task.Run(() => Fibonacci(40));
            Task task2 = Task.Run(() => Fibonacci(39));
            Task task3 = Task.Run(() => Fibonacci(41));
            Task task4 = Task.Run(() => Fibonacci(40));
            Task.WaitAll(task1, task2, task3, task4);
            sw.Stop();
            Console.WriteLine("Parallel:" + sw.ElapsedMilliseconds);
        }
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
