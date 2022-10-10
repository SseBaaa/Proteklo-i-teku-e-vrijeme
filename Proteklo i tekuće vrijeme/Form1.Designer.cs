namespace Proteklo_i_tekuće_vrijeme
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTrenutno = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProteklo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTrenutno,
            this.toolStripProteklo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTrenutno
            // 
            this.toolStripTrenutno.Name = "toolStripTrenutno";
            this.toolStripTrenutno.Size = new System.Drawing.Size(60, 17);
            this.toolStripTrenutno.Text = "Trenutno: ";
            this.toolStripTrenutno.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripProteklo
            // 
            this.toolStripProteklo.Name = "toolStripProteklo";
            this.toolStripProteklo.Size = new System.Drawing.Size(57, 17);
            this.toolStripProteklo.Text = "Proteklo: ";
            this.toolStripProteklo.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTrenutno;
        private System.Windows.Forms.ToolStripStatusLabel toolStripProteklo;
    }
}

