namespace CountinueWithExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task1 = Task.Run(() =>
            {
                Console.WriteLine("Task 1: Ordering Pizza...");
                Thread.Sleep(1000);
                return 10;
            });

            task1.ContinueWith(t =>
            {
                Console.WriteLine($"Task 2: Eating Pizza {t.Result}!");
            }).
            ContinueWith(t => Console.WriteLine("Task 3: Watching TV")).
            Wait();
        }
    }
}
