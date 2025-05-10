
namespace ThreadStartDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This works because of method group conversion,
            //where the compiler infers and converts
            //Print to a ThreadStart delegate automatically
            //if the method signature matches.
            Thread thread = new Thread(Print);
            thread.Name = "Worker";
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine(thread.IsAlive);
            thread.Start();
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.ThreadState);
            thread.Join();
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine(thread.IsAlive);
            Thread thread2 = new Thread(new ThreadStart(Print));
            thread2.Name = "Worker-2";
            thread2.Start();
            Thread thread3 = new Thread(new ParameterizedThreadStart(PrintMessage));
            thread3.Start("Hello world!");
        }

        private static void Print()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }
        static void PrintMessage(object message)
        {
            Console.WriteLine(message);
        }
    }
}
