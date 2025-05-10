namespace ThreadConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(OpenDoor);
            thread.Name = "Worker-1";
            thread.Name = "Worker-2";
            thread.Start();
            thread.Join();
            BoilingWater();
        }
        private static void BoilingWater()
        {
            Console.WriteLine("Boiling water");
        }
        private static void OpenDoor()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Open Door");
        }
    }
}
