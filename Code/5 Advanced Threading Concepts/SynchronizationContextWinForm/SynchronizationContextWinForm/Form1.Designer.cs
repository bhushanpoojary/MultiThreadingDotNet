namespace SynchronizationContextWinForm
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
            btnCorrect = new Button();
            btnWrong = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCorrect
            // 
            btnCorrect.Location = new Point(60, 12);
            btnCorrect.Name = "btnCorrect";
            btnCorrect.Size = new Size(243, 23);
            btnCorrect.TabIndex = 0;
            btnCorrect.Text = "With SynchronizationContext";
            btnCorrect.UseVisualStyleBackColor = true;
            btnCorrect.Click += btnCorrect_Click;
            // 
            // btnWrong
            // 
            btnWrong.Location = new Point(60, 56);
            btnWrong.Name = "btnWrong";
            btnWrong.Size = new Size(243, 23);
            btnWrong.TabIndex = 1;
            btnWrong.Text = "Without SynchronizationContext";
            btnWrong.UseVisualStyleBackColor = true;
            btnWrong.Click += btnWrong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 115);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "{label}";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 159);
            Controls.Add(label1);
            Controls.Add(btnWrong);
            Controls.Add(btnCorrect);
            Name = "Form1";
            Text = "SynchronizationContexts Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCorrect;
        private Button btnWrong;
        private Label label1;
    }
}
