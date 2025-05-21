namespace WinFormsAssyncAwaitDeepDive
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
            btnSimpleAsync = new Button();
            btnWrongHang = new Button();
            SuspendLayout();
            // 
            // btnSimpleAsync
            // 
            btnSimpleAsync.Location = new Point(82, 12);
            btnSimpleAsync.Name = "btnSimpleAsync";
            btnSimpleAsync.Size = new Size(171, 23);
            btnSimpleAsync.TabIndex = 0;
            btnSimpleAsync.Text = "Simple Async";
            btnSimpleAsync.UseVisualStyleBackColor = true;
            btnSimpleAsync.Click += button1_Click;
            // 
            // btnWrongHang
            // 
            btnWrongHang.Location = new Point(82, 62);
            btnWrongHang.Name = "btnWrongHang";
            btnWrongHang.Size = new Size(171, 23);
            btnWrongHang.TabIndex = 1;
            btnWrongHang.Text = "Wrong Hang";
            btnWrongHang.UseVisualStyleBackColor = true;
            btnWrongHang.Click += btnWrongHang_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 131);
            Controls.Add(btnWrongHang);
            Controls.Add(btnSimpleAsync);
            Name = "Form1";
            Text = "Async Await Deep Dive";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimpleAsync;
        private Button btnWrongHang;
    }
}
