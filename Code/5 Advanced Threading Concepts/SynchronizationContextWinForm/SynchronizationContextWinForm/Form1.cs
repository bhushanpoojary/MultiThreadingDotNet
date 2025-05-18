namespace SynchronizationContextWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = true;
        }

        private async void btnCorrect_Click(object sender, EventArgs e)
        {
            label1.Text = "Loading...";

            // Simulate background work
            //await Task.Delay(2000).ConfigureAwait(false);
            await Task.Delay(2000);

            // Back on UI thread because SynchronizationContext captured
            label1.Text = "Done!";
        }

        private void btnWrong_Click(object sender, EventArgs e)
        {
            // Run code on background thread
            Thread thread = new Thread(() =>
            {
                // Delay to simulate work
                Thread.Sleep(1000);
                // Directly accessing UI control from non-UI thread — this will crash
                label1.Text = "This should crash!";
            });

            thread.Start();
        }
    }
}
