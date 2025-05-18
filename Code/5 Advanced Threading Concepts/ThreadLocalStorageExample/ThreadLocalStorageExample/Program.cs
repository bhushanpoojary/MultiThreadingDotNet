

internal class Program
{
    static void Main(string[] args)
    {
        ThreadLocal<Random> localRandom = new ThreadLocal<Random>(() => new Random(Guid.NewGuid().GetHashCode()));

        Parallel.For(0, 10, i =>
        {
            Console.WriteLine(localRandom.Value.Next()); // Each thread gets its own Random
        });

    }
}

