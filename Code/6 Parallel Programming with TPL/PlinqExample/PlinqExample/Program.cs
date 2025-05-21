namespace PlinqExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 10);

            var results = numbers
                .AsParallel()
                .Where(n => n % 2 == 0)
                .Select(n =>
                {
                    Console.WriteLine($"Processing {n} on thread {Thread.CurrentThread.ManagedThreadId}");
                    return n * 10;
                })
                .ToList();
        }
    }
}
