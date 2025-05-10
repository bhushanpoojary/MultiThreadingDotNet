namespace _4_SimpleAsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSyncCode_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            var client = new HttpClient();
            Thread.Sleep(5000);
            string content = client.GetStringAsync("https://example.com").Result;
            richTextBox1.Text = content;
        }

        private async void btnAsyncAwait_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            var client = new HttpClient();
            await Task.Delay(5000); // Non-blocking delay
            string content = await client.GetStringAsync("https://example.com");
            richTextBox1.Text = content;
        }

        private async void btnAsyncAwaitReturn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Text = await DownloadContentAsync();
        }
        public async Task<string> DownloadContentAsync()
        {
            using var client = new HttpClient();
            string content = await client.GetStringAsync("https://example.com");
            return content;
        }
    }
}
