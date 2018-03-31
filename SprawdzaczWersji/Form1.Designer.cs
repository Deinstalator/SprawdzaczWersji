namespace SprawdzaczWersji
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
            this.components = new System.ComponentModel.Container();
            this.about = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(1100, 582);
            this.about.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(164, 46);
            this.about.TabIndex = 0;
            this.about.Text = "O sprawdzaczu";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(1100, 649);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(164, 44);
            this.exit.TabIndex = 1;
            this.exit.Text = "Wyjście";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(1100, 43);
            this.check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(164, 66);
            this.check.TabIndex = 3;
            this.check.Text = "Sprawdzaj!";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.ItemHeight = 16;
            this.output.Location = new System.Drawing.Point(16, 15);
            this.output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(1075, 612);
            this.output.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 649);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1076, 44);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 722);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.check);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sprawdzacz Wersji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

