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
            this.update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(825, 473);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(123, 37);
            this.about.TabIndex = 0;
            this.about.Text = "O sprawdzaczu";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(825, 527);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(123, 36);
            this.exit.TabIndex = 1;
            this.exit.Text = "Wyjście";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(825, 12);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(123, 54);
            this.check.TabIndex = 3;
            this.check.Text = "Sprawdzaj!";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(807, 498);
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
            this.progressBar1.Location = new System.Drawing.Point(12, 527);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(807, 36);
            this.progressBar1.TabIndex = 6;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(825, 91);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(123, 60);
            this.update.TabIndex = 7;
            this.update.Text = "Aktualizuj!";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 587);
            this.Controls.Add(this.update);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.check);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.about);
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
        private System.Windows.Forms.Button update;
    }
}

