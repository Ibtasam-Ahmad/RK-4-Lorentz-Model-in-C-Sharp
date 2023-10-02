namespace LmRk4Class
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lorentzModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xvsyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xvstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zvsxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lorentzModelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lorentzModelToolStripMenuItem
            // 
            this.lorentzModelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xvsyToolStripMenuItem,
            this.xvstToolStripMenuItem,
            this.zvsxToolStripMenuItem});
            this.lorentzModelToolStripMenuItem.Name = "lorentzModelToolStripMenuItem";
            this.lorentzModelToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.lorentzModelToolStripMenuItem.Text = "LorentzModel";
            // 
            // xvsyToolStripMenuItem
            // 
            this.xvsyToolStripMenuItem.Name = "xvsyToolStripMenuItem";
            this.xvsyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xvsyToolStripMenuItem.Text = "x_vs_y";
            this.xvsyToolStripMenuItem.Click += new System.EventHandler(this.xvsyToolStripMenuItem_Click);
            // 
            // xvstToolStripMenuItem
            // 
            this.xvstToolStripMenuItem.Name = "xvstToolStripMenuItem";
            this.xvstToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xvstToolStripMenuItem.Text = "x_vs_t";
            this.xvstToolStripMenuItem.Click += new System.EventHandler(this.xvstToolStripMenuItem_Click);
            // 
            // zvsxToolStripMenuItem
            // 
            this.zvsxToolStripMenuItem.Name = "zvsxToolStripMenuItem";
            this.zvsxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zvsxToolStripMenuItem.Text = "z_vs_x";
            this.zvsxToolStripMenuItem.Click += new System.EventHandler(this.zvsxToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 538);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lorentzModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xvsyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xvstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zvsxToolStripMenuItem;
    }
}

