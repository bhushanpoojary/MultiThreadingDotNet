namespace WinFormsAssyncAwaitDeepDive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread.CurrentThread.Name = "GUI Thread";
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = true;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Before Async:" + Thread.CurrentThread.Name);
            var result = await FetchDataAsyncConfigureAwaitFalse();
            Console.WriteLine("After Async:" + Thread.CurrentThread.Name);
        }

        private void btnWrongHang_Click(object sender, EventArgs e)
        {
            var result = FetchDataAsync().Result;
        }

        public async Task<string> FetchDataAsyncConfigureAwaitFalse()
        {
            Console.WriteLine("During Async Before:" + Thread.CurrentThread.Name);
            using var client = new HttpClient();
            var result = await client.GetStringAsync("https://example.com").ConfigureAwait(false);
            Console.WriteLine("During Async After:" + Thread.CurrentThread.Name);
            return result;
        }

        public async Task<string> FetchDataAsync()
        {
            Console.WriteLine("During Async Before:" + Thread.CurrentThread.Name);
            using var client = new HttpClient();
            var result = await client.GetStringAsync("https://example.com");
            Console.WriteLine("During Async After:" + Thread.CurrentThread.Name);
            return result;
        }
    }
}
