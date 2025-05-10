namespace _4_SimpleAsyncAwait
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            btnSyncCode = new Button();
            richTextBox1 = new RichTextBox();
            btnAsyncAwait = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 411);
            progressBar1.MarqueeAnimationSpeed = 200;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(562, 23);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.TabIndex = 0;
            // 
            // btnSyncCode
            // 
            btnSyncCode.Location = new Point(35, 35);
            btnSyncCode.Name = "btnSyncCode";
            btnSyncCode.Size = new Size(75, 23);
            btnSyncCode.TabIndex = 1;
            btnSyncCode.Text = "Sync fetch";
            btnSyncCode.UseVisualStyleBackColor = true;
            btnSyncCode.Click += btnSyncCode_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 89);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(538, 316);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnAsyncAwait
            // 
            btnAsyncAwait.Location = new Point(172, 35);
            btnAsyncAwait.Name = "btnAsyncAwait";
            btnAsyncAwait.Size = new Size(88, 23);
            btnAsyncAwait.TabIndex = 3;
            btnAsyncAwait.Text = "Async/Await fetch";
            btnAsyncAwait.UseVisualStyleBackColor = true;
            btnAsyncAwait.Click += btnAsyncAwait_Click;
            // 
            // button1
            // 
            button1.Location = new Point(333, 35);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 4;
            button1.Text = "Async/Await return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAsyncAwaitReturn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 434);
            Controls.Add(button1);
            Controls.Add(btnAsyncAwait);
            Controls.Add(richTextBox1);
            Controls.Add(btnSyncCode);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Simple Async Await Form";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button btnSyncCode;
        private RichTextBox richTextBox1;
        private Button btnAsyncAwait;
        private Button button1;
    }
}
