namespace LockRaceCondition
{
    internal class Program
    {
        static int counter = 0;
        static readonly object _syncObj = new object();

        static void Increment()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                lock (_syncObj)
                {
                    counter = counter + 1; 
                }
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine($"Final Counter Value: {counter}");
        }
    }
}
