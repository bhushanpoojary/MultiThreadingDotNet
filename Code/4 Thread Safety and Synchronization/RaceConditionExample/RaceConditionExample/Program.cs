namespace RaceConditionExample
{
    internal class Program
    {
        static int counter = 0;

        static void Increment()
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                counter= counter + 1; // Not thread-safe!
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
