using System.Collections.Concurrent;

namespace BlockingCollectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> servingCounter = new BlockingCollection<string>(5);

            // Producer (Chef)
            Task checfTask = Task.Run(() =>
            {
                int count = 0;
                while (true)
                {
                    string meal = $"Meal {++count}";
                    servingCounter.Add(meal);
                    Console.WriteLine($"Chef: prepared {meal}");
                    Thread.Sleep(500); // Simulate time to cook
                }
            });

            // Consumer (Waiter)
            Task.Run(() =>
            {
                foreach (var meal in servingCounter.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Waiter: served {meal}");
                    Thread.Sleep(800); // Simulate time to serve
                }
            });
            checfTask.Wait();

        }
    }
}
