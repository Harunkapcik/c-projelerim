namespace pc_alma_oyunu
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHazirSistem = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.btnPcBilesen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(318, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BİLGİSAYARLAR";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 542);
            this.panel1.TabIndex = 1;
            // 
            // btnHazirSistem
            // 
            this.btnHazirSistem.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHazirSistem.Location = new System.Drawing.Point(355, 75);
            this.btnHazirSistem.Name = "btnHazirSistem";
            this.btnHazirSistem.Size = new System.Drawing.Size(176, 75);
            this.btnHazirSistem.TabIndex = 2;
            this.btnHazirSistem.Text = "HAZIR SİSTEMLER";
            this.btnHazirSistem.UseVisualStyleBackColor = true;
            this.btnHazirSistem.Click += new System.EventHandler(this.btnHazirSistem_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLaptop.Location = new System.Drawing.Point(355, 181);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(176, 75);
            this.btnLaptop.TabIndex = 3;
            this.btnLaptop.Text = "LAPTOPLAR";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // btnPcBilesen
            // 
            this.btnPcBilesen.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPcBilesen.Location = new System.Drawing.Point(355, 285);
            this.btnPcBilesen.Name = "btnPcBilesen";
            this.btnPcBilesen.Size = new System.Drawing.Size(176, 75);
            this.btnPcBilesen.TabIndex = 4;
            this.btnPcBilesen.Text = "BİLGİSAYAR BİLEŞENLERİ";
            this.btnPcBilesen.UseVisualStyleBackColor = true;
            this.btnPcBilesen.Click += new System.EventHandler(this.btnPcBilesen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 542);
            this.Controls.Add(this.btnPcBilesen);
            this.Controls.Add(this.btnLaptop);
            this.Controls.Add(this.btnHazirSistem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHazirSistem;
        private System.Windows.Forms.Button btnLaptop;
        private System.Windows.Forms.Button btnPcBilesen;
    }
}