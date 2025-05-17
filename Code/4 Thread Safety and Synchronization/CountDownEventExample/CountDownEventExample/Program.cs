namespace CountDownEventExample
{
    class Program
    {
        static CountdownEvent countdown = new CountdownEvent(3); // 3 tasks to complete

        static void Main()
        {
            for (int i = 1; i <= 3; i++)
            {
                int taskNum = i;
                new Thread(() =>
                {
                    Console.WriteLine($"Task {taskNum} started.");
                    Thread.Sleep(1000 * taskNum); // simulate work
                    Console.WriteLine($"Task {taskNum} completed.");
                    countdown.Signal(); // mark this task as completed
                }).Start();
            }
            Console.WriteLine("Main thread waiting for all tasks to complete...");
            countdown.Wait(); // wait for all tasks
            Console.WriteLine("All tasks completed. Proceeding with next step.");
        }
    }

}
