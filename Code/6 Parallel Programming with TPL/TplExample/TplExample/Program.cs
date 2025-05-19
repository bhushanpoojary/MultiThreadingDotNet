namespace TplExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(() => Console.WriteLine("Running in parallel!"));
            task.Wait(); // Waits for the task to complete

            Task<int> task1 = Task.Factory.StartNew(() => 40 + 2);
            int result = task1.Result;  // Waits for completion and gets the result
            Console.WriteLine(result); // 42

            try
            {
                var task3 = Task.Factory.StartNew(() => throw new InvalidOperationException());
                task3.Wait();  // Throws AggregateException
            }
            catch (AggregateException ae)
            {
                Console.WriteLine("Exception caught: " + ae.InnerException.Message);
            }


            var task4 = Task.Factory.StartNew(() => throw new InvalidOperationException("Task 1 failed"));
            var task5 = Task.Factory.StartNew(() => throw new ArgumentException("Task 2 failed"));

            try
            {
                Task.WaitAll(task4, task5);
            }
            catch (AggregateException ae)
            {
                foreach (var ex in ae.InnerExceptions)
                    Console.WriteLine(ex.Message);  // Both exceptions printed
            }
        }
    }
}
