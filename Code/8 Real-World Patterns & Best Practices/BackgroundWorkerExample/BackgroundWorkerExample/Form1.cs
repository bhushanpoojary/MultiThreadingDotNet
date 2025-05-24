using System.ComponentModel;

namespace BackgroundWorkerExample
{
    public partial class Form1 : Form
    {
        BackgroundWorker backgroundWorker;
        public Form1()
        {
            InitializeComponent();
            // Initialize and configure BackgroundWorker
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                progressBar1.Value = 0;
                labelStatus.Text = "Working...";
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simulate long task
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50); // Simulate delay
                backgroundWorker.ReportProgress(i);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            labelStatus.Text = $"Progress: {e.ProgressPercentage}%";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelStatus.Text = "Completed!";
        }
    }
}
