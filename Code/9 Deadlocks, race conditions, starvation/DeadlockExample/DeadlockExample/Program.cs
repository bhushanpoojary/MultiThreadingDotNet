namespace DeadlockExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object lockA = new object();
            object lockB = new object();

            Thread t1 = new Thread(() => {
                lock (lockA)
                {
                    Console.WriteLine("Thread 1 acquired lockA");
                    Thread.Sleep(100); // simulate delay
                    lock (lockB)
                    {
                        Console.WriteLine("Thread 1 got both locks");
                    }
                }
            });

            Thread t2 = new Thread(() => {
                lock (lockB)
                {
                    Console.WriteLine("Thread 2 acquired lockB");
                    Thread.Sleep(100);
                    lock (lockA)
                    {
                        Console.WriteLine("Thread 2 got both locks");
                    }
                }
            });

            t1.Start();
            t2.Start();
        }
    }
}
