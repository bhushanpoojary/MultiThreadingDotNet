namespace CancelExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 1000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Cancellation requested!");
                        token.ThrowIfCancellationRequested();
                        return; // Exit cleanly
                    }

                    Console.WriteLine("Working... " + i);
                    Thread.Sleep(100);
                }
            }, token);

            // Simulate cancellation after 1 second
            Thread.Sleep(1000);
            cts.Cancel();
            task.Wait();
        }
    }
}
