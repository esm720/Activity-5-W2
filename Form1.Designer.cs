namespace Activity_5_W2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ProcessBut
            // 
            this.ProcessBut.Location = new System.Drawing.Point(73, 129);
            this.ProcessBut.Name = "ProcessBut";
            this.ProcessBut.Size = new System.Drawing.Size(236, 98);
            this.ProcessBut.TabIndex = 0;
            this.ProcessBut.Text = "Process File...";
            this.ProcessBut.UseVisualStyleBackColor = true;
            this.ProcessBut.Click += new System.EventHandler(this.ProcessBut_Click);
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(393, 129);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(241, 98);
            this.ExitBut.TabIndex = 1;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.Click += new System.EventHandler(this.ExitBut_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.ProcessBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBut;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.ProcessBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProcessBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

