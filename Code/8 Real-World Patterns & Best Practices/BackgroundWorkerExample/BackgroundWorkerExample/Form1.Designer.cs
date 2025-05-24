namespace BackgroundWorkerExample
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
            btnStart = new Button();
            progressBar1 = new ProgressBar();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(300, 75);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 159);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(696, 23);
            progressBar1.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(0, 141);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(38, 15);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 182);
            Controls.Add(labelStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private ProgressBar progressBar1;
        private Label labelStatus;
    }
}
