namespace ParallelForEachExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Enumerable.Range(1, 5).ToList();

            Parallel.ForEach(items, item =>
            {
                Console.WriteLine($"Item {item} processed on thread {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }
}
