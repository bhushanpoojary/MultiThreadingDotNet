using System.Collections.Concurrent;

namespace ConcurrentExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<int, string> users = new();
            users.TryAdd(1, "Alice");
            string user = users.GetOrAdd(2, id => "Bob");
            Console.WriteLine(user);
            user = users.GetOrAdd(2, id => "Marwin");
            Console.WriteLine(user);
            ConcurrentQueue<string> messages = new();
            messages.Enqueue("Hello");
            if (messages.TryDequeue(out var msg))
                Console.WriteLine(msg); // "Hello"
        }
    }
}
