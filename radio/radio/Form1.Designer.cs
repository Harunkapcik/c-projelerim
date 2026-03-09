namespace radio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radyoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kralFmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.babaRadyoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imbatFmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alemFmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kralPopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istanbulFmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(323, 56);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(281, 243);
            this.wmp.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radyoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(223, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radyoToolStripMenuItem
            // 
            this.radyoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabeskToolStripMenuItem,
            this.popToolStripMenuItem});
            this.radyoToolStripMenuItem.Name = "radyoToolStripMenuItem";
            this.radyoToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.radyoToolStripMenuItem.Text = "Radyo";
            // 
            // arabeskToolStripMenuItem
            // 
            this.arabeskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kralFmToolStripMenuItem,
            this.babaRadyoToolStripMenuItem,
            this.imbatFmToolStripMenuItem});
            this.arabeskToolStripMenuItem.Name = "arabeskToolStripMenuItem";
            this.arabeskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.arabeskToolStripMenuItem.Text = "Arabesk";
            // 
            // kralFmToolStripMenuItem
            // 
            this.kralFmToolStripMenuItem.Name = "kralFmToolStripMenuItem";
            this.kralFmToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.kralFmToolStripMenuItem.Text = "Kral fm";
            this.kralFmToolStripMenuItem.Click += new System.EventHandler(this.kralFmToolStripMenuItem_Click);
            // 
            // babaRadyoToolStripMenuItem
            // 
            this.babaRadyoToolStripMenuItem.Name = "babaRadyoToolStripMenuItem";
            this.babaRadyoToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.babaRadyoToolStripMenuItem.Text = "baba radyo";
            this.babaRadyoToolStripMenuItem.Click += new System.EventHandler(this.babaRadyoToolStripMenuItem_Click);
            // 
            // imbatFmToolStripMenuItem
            // 
            this.imbatFmToolStripMenuItem.Name = "imbatFmToolStripMenuItem";
            this.imbatFmToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.imbatFmToolStripMenuItem.Text = "imbat fm";
            this.imbatFmToolStripMenuItem.Click += new System.EventHandler(this.imbatFmToolStripMenuItem_Click);
            // 
            // popToolStripMenuItem
            // 
            this.popToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alemFmToolStripMenuItem,
            this.kralPopToolStripMenuItem,
            this.istanbulFmToolStripMenuItem});
            this.popToolStripMenuItem.Name = "popToolStripMenuItem";
            this.popToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.popToolStripMenuItem.Text = "pop";
            // 
            // alemFmToolStripMenuItem
            // 
            this.alemFmToolStripMenuItem.Name = "alemFmToolStripMenuItem";
            this.alemFmToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.alemFmToolStripMenuItem.Text = "alem fm";
            this.alemFmToolStripMenuItem.Click += new System.EventHandler(this.alemFmToolStripMenuItem_Click);
            // 
            // kralPopToolStripMenuItem
            // 
            this.kralPopToolStripMenuItem.Name = "kralPopToolStripMenuItem";
            this.kralPopToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.kralPopToolStripMenuItem.Text = "kral pop";
            this.kralPopToolStripMenuItem.Click += new System.EventHandler(this.kralPopToolStripMenuItem_Click);
            // 
            // istanbulFmToolStripMenuItem
            // 
            this.istanbulFmToolStripMenuItem.Name = "istanbulFmToolStripMenuItem";
            this.istanbulFmToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.istanbulFmToolStripMenuItem.Text = "istanbul fm";
            this.istanbulFmToolStripMenuItem.Click += new System.EventHandler(this.istanbulFmToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 534);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem radyoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabeskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kralFmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babaRadyoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imbatFmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alemFmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kralPopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istanbulFmToolStripMenuItem;
    }
}

