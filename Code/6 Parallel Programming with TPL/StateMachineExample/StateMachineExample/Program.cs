namespace StateMachineExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = FetchData();
            Console.WriteLine(data);
        }
        public static string FetchData()
        {
            using var client = new HttpClient();
            var result = client.GetStringAsync("https://example.com").Result;
            return result;
        }
    }
}
