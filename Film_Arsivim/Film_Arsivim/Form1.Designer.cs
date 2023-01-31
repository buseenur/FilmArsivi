namespace Film_Arsivim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.TxtLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCksYap = new System.Windows.Forms.Button();
            this.BtnRenkDgisim = new System.Windows.Forms.Button();
            this.BtnHakkmzda = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 70);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(461, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "SİNEMA SALONUM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(925, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(282, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(266, 386);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(258, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(559, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 386);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnKaydet);
            this.groupBox3.Controls.Add(this.TxtLink);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.TxtKategori);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TxtFilmAd);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 200);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(91, 127);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(91, 23);
            this.BtnKaydet.TabIndex = 6;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtLink
            // 
            this.TxtLink.Location = new System.Drawing.Point(67, 99);
            this.TxtLink.Name = "TxtLink";
            this.TxtLink.Size = new System.Drawing.Size(154, 22);
            this.TxtLink.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Link:";
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(67, 71);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(154, 22);
            this.TxtKategori.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori:";
            // 
            // TxtFilmAd
            // 
            this.TxtFilmAd.Location = new System.Drawing.Point(67, 43);
            this.TxtFilmAd.Name = "TxtFilmAd";
            this.TxtFilmAd.Size = new System.Drawing.Size(154, 22);
            this.TxtFilmAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Ad:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnCksYap);
            this.groupBox4.Controls.Add(this.BtnRenkDgisim);
            this.groupBox4.Controls.Add(this.BtnHakkmzda);
            this.groupBox4.Location = new System.Drawing.Point(16, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 169);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // BtnCksYap
            // 
            this.BtnCksYap.Location = new System.Drawing.Point(67, 112);
            this.BtnCksYap.Name = "BtnCksYap";
            this.BtnCksYap.Size = new System.Drawing.Size(122, 23);
            this.BtnCksYap.TabIndex = 9;
            this.BtnCksYap.Text = "ÇIKIŞ YAP";
            this.BtnCksYap.UseVisualStyleBackColor = true;
            this.BtnCksYap.Click += new System.EventHandler(this.BtnCksYap_Click);
            // 
            // BtnRenkDgisim
            // 
            this.BtnRenkDgisim.Location = new System.Drawing.Point(67, 81);
            this.BtnRenkDgisim.Name = "BtnRenkDgisim";
            this.BtnRenkDgisim.Size = new System.Drawing.Size(122, 23);
            this.BtnRenkDgisim.TabIndex = 10;
            this.BtnRenkDgisim.Text = "RENK DEĞİŞTİR";
            this.BtnRenkDgisim.UseVisualStyleBackColor = true;
            this.BtnRenkDgisim.Click += new System.EventHandler(this.BtnRenkDgisim_Click);
            // 
            // BtnHakkmzda
            // 
            this.BtnHakkmzda.Location = new System.Drawing.Point(67, 50);
            this.BtnHakkmzda.Name = "BtnHakkmzda";
            this.BtnHakkmzda.Size = new System.Drawing.Size(122, 23);
            this.BtnHakkmzda.TabIndex = 8;
            this.BtnHakkmzda.Text = "HAKKIMIZDA";
            this.BtnHakkmzda.UseVisualStyleBackColor = true;
            this.BtnHakkmzda.Click += new System.EventHandler(this.BtnHakkmzda_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(554, 365);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1135, 485);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.TextBox TxtLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnCksYap;
        private System.Windows.Forms.Button BtnRenkDgisim;
        private System.Windows.Forms.Button BtnHakkmzda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

