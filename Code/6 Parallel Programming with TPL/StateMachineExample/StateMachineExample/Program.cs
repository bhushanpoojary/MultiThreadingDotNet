namespace StateMachineExample
{
    internal class Program
    {
        public async static Task Main(string[] args)
        {
            var data = await FetchData();
            Console.WriteLine(data);
        }
        public async static Task<string> FetchData()
        { 
            using var client = new HttpClient();
            var result =  await client.GetStringAsync("https://example.com");
            return result;
        }
    }
}
