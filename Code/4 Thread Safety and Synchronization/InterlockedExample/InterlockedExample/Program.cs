namespace InterlockedExample
{
    class Program
    {
        static int counter = 0;

        static void IncrementUnsafe()
        {
            for (int i = 0; i < 1000000; i++)
            {
                counter++; // Not thread-safe
            }
        }

        static void IncrementSafe()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref counter); // Thread-safe
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementSafe);
            Thread t2 = new Thread(IncrementSafe);

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine("Counter: " + counter); // Should be 20000
        }
    }
}
