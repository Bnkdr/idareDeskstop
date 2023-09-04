namespace İdareDeskstop
{
    partial class ÇağırmaEkranı
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
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbox_ogrenci = new System.Windows.Forms.ComboBox();
            this.btn_ogrenciEkleme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxt_aciklama = new System.Windows.Forms.RichTextBox();
            this.txt_idareno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbox_ogretmen = new System.Windows.Forms.ComboBox();
            this.btn_ogretmenEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.rtxt_ogretmen = new System.Windows.Forms.RichTextBox();
            this.txt_oIdareNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbox_idare = new System.Windows.Forms.ComboBox();
            this.btn_idareEkle = new System.Windows.Forms.Button();
            this.txt_çağrılanidare = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rtxt_idareaciklama = new System.Windows.Forms.RichTextBox();
            this.txt_çağıranidare = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_ListeCagri = new System.Windows.Forms.Button();
            this.btn_datagridSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cagrıilacak_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cagrilacak_sinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cagrilacak_gorev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cagrilacak_aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Çağır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 355);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbox_ogrenci);
            this.tabPage1.Controls.Add(this.btn_ogrenciEkleme);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.rtxt_aciklama);
            this.tabPage1.Controls.Add(this.txt_idareno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbox_ogrenci
            // 
            this.cmbox_ogrenci.FormattingEnabled = true;
            this.cmbox_ogrenci.Location = new System.Drawing.Point(111, 86);
            this.cmbox_ogrenci.Name = "cmbox_ogrenci";
            this.cmbox_ogrenci.Size = new System.Drawing.Size(171, 21);
            this.cmbox_ogrenci.TabIndex = 25;
            // 
            // btn_ogrenciEkleme
            // 
            this.btn_ogrenciEkleme.Location = new System.Drawing.Point(170, 239);
            this.btn_ogrenciEkleme.Name = "btn_ogrenciEkleme";
            this.btn_ogrenciEkleme.Size = new System.Drawing.Size(122, 48);
            this.btn_ogrenciEkleme.TabIndex = 24;
            this.btn_ogrenciEkleme.Text = "Çağırma Listesine Ekle";
            this.btn_ogrenciEkleme.UseVisualStyleBackColor = true;
            this.btn_ogrenciEkleme.Click += new System.EventHandler(this.btn_ogrenciEkleme_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Açıklama";
            // 
            // rtxt_aciklama
            // 
            this.rtxt_aciklama.Location = new System.Drawing.Point(111, 137);
            this.rtxt_aciklama.Name = "rtxt_aciklama";
            this.rtxt_aciklama.Size = new System.Drawing.Size(171, 96);
            this.rtxt_aciklama.TabIndex = 22;
            this.rtxt_aciklama.Text = "";
            // 
            // txt_idareno
            // 
            this.txt_idareno.Location = new System.Drawing.Point(111, 33);
            this.txt_idareno.Name = "txt_idareno";
            this.txt_idareno.Size = new System.Drawing.Size(171, 20);
            this.txt_idareno.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "İdare Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Öğrenci İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sınıf";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9A",
            "9B",
            "9C",
            "9D",
            "10A",
            "10B",
            "10C",
            "10D",
            "11A",
            "11B",
            "11C",
            "11D",
            "12A",
            "12B",
            "12C",
            "12D"});
            this.comboBox1.Location = new System.Drawing.Point(111, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbox_ogretmen);
            this.tabPage2.Controls.Add(this.btn_ogretmenEkle);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.rtxt_ogretmen);
            this.tabPage2.Controls.Add(this.txt_oIdareNo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğretmen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbox_ogretmen
            // 
            this.cmbox_ogretmen.FormattingEnabled = true;
            this.cmbox_ogretmen.Location = new System.Drawing.Point(131, 81);
            this.cmbox_ogretmen.Name = "cmbox_ogretmen";
            this.cmbox_ogretmen.Size = new System.Drawing.Size(171, 21);
            this.cmbox_ogretmen.TabIndex = 34;
            // 
            // btn_ogretmenEkle
            // 
            this.btn_ogretmenEkle.Location = new System.Drawing.Point(180, 231);
            this.btn_ogretmenEkle.Name = "btn_ogretmenEkle";
            this.btn_ogretmenEkle.Size = new System.Drawing.Size(122, 48);
            this.btn_ogretmenEkle.TabIndex = 33;
            this.btn_ogretmenEkle.Text = "Çağırma Listesine Ekle";
            this.btn_ogretmenEkle.UseVisualStyleBackColor = true;
            this.btn_ogretmenEkle.Click += new System.EventHandler(this.btn_ogretmenEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Açıklama";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 48);
            this.button2.TabIndex = 24;
            this.button2.Text = "Çağır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtxt_ogretmen
            // 
            this.rtxt_ogretmen.Location = new System.Drawing.Point(131, 129);
            this.rtxt_ogretmen.Name = "rtxt_ogretmen";
            this.rtxt_ogretmen.Size = new System.Drawing.Size(171, 96);
            this.rtxt_ogretmen.TabIndex = 31;
            this.rtxt_ogretmen.Text = "";
            // 
            // txt_oIdareNo
            // 
            this.txt_oIdareNo.Location = new System.Drawing.Point(131, 25);
            this.txt_oIdareNo.Name = "txt_oIdareNo";
            this.txt_oIdareNo.Size = new System.Drawing.Size(171, 20);
            this.txt_oIdareNo.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "İdare Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Öğretmen İsmi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sınıf";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9A",
            "9B",
            "9C",
            "9D",
            "10A",
            "10B",
            "10C",
            "10D",
            "11A",
            "11B",
            "11C",
            "11D",
            "12A",
            "12B",
            "12C",
            "12D"});
            this.comboBox2.Location = new System.Drawing.Point(131, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 21);
            this.comboBox2.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbox_idare);
            this.tabPage3.Controls.Add(this.btn_idareEkle);
            this.tabPage3.Controls.Add(this.txt_çağrılanidare);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.rtxt_idareaciklama);
            this.tabPage3.Controls.Add(this.txt_çağıranidare);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(690, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İdare";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbox_idare
            // 
            this.cmbox_idare.FormattingEnabled = true;
            this.cmbox_idare.Location = new System.Drawing.Point(131, 81);
            this.cmbox_idare.Name = "cmbox_idare";
            this.cmbox_idare.Size = new System.Drawing.Size(171, 21);
            this.cmbox_idare.TabIndex = 44;
            this.cmbox_idare.SelectedIndexChanged += new System.EventHandler(this.cmbox_idare_SelectedIndexChanged);
            // 
            // btn_idareEkle
            // 
            this.btn_idareEkle.Location = new System.Drawing.Point(180, 231);
            this.btn_idareEkle.Name = "btn_idareEkle";
            this.btn_idareEkle.Size = new System.Drawing.Size(122, 48);
            this.btn_idareEkle.TabIndex = 43;
            this.btn_idareEkle.Text = "Çağırma Listesine Ekle";
            this.btn_idareEkle.UseVisualStyleBackColor = true;
            this.btn_idareEkle.Click += new System.EventHandler(this.btn_idareEkle_Click);
            // 
            // txt_çağrılanidare
            // 
            this.txt_çağrılanidare.Location = new System.Drawing.Point(131, 54);
            this.txt_çağrılanidare.Name = "txt_çağrılanidare";
            this.txt_çağrılanidare.Size = new System.Drawing.Size(171, 20);
            this.txt_çağrılanidare.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Açıklama";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 48);
            this.button3.TabIndex = 33;
            this.button3.Text = "Çağır";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rtxt_idareaciklama
            // 
            this.rtxt_idareaciklama.Location = new System.Drawing.Point(131, 129);
            this.rtxt_idareaciklama.Name = "rtxt_idareaciklama";
            this.rtxt_idareaciklama.Size = new System.Drawing.Size(171, 96);
            this.rtxt_idareaciklama.TabIndex = 40;
            this.rtxt_idareaciklama.Text = "";
            // 
            // txt_çağıranidare
            // 
            this.txt_çağıranidare.Location = new System.Drawing.Point(131, 25);
            this.txt_çağıranidare.Name = "txt_çağıranidare";
            this.txt_çağıranidare.Size = new System.Drawing.Size(171, 20);
            this.txt_çağıranidare.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Çağıran İdare Numarası";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "İdareci İsmi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Çağrılan İdare Numarası";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_ListeCagri);
            this.tabPage4.Controls.Add(this.btn_datagridSil);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(690, 329);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Çağırma";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_ListeCagri
            // 
            this.btn_ListeCagri.Location = new System.Drawing.Point(385, 234);
            this.btn_ListeCagri.Name = "btn_ListeCagri";
            this.btn_ListeCagri.Size = new System.Drawing.Size(142, 57);
            this.btn_ListeCagri.TabIndex = 2;
            this.btn_ListeCagri.Text = "Listedekileri Çağır";
            this.btn_ListeCagri.UseVisualStyleBackColor = true;
            this.btn_ListeCagri.Click += new System.EventHandler(this.btn_ListeCagri_Click);
            // 
            // btn_datagridSil
            // 
            this.btn_datagridSil.Location = new System.Drawing.Point(188, 234);
            this.btn_datagridSil.Name = "btn_datagridSil";
            this.btn_datagridSil.Size = new System.Drawing.Size(142, 57);
            this.btn_datagridSil.TabIndex = 1;
            this.btn_datagridSil.Text = "Çağrılacak Kişiyi Sil";
            this.btn_datagridSil.UseVisualStyleBackColor = true;
            this.btn_datagridSil.Click += new System.EventHandler(this.btn_datagridSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cagrıilacak_ad,
            this.cagrilacak_sinif,
            this.cagrilacak_gorev,
            this.cagrilacak_aciklama});
            this.dataGridView1.Location = new System.Drawing.Point(10, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // cagrıilacak_ad
            // 
            this.cagrıilacak_ad.HeaderText = "Çağrılacak Kişi Adı";
            this.cagrıilacak_ad.Name = "cagrıilacak_ad";
            this.cagrıilacak_ad.Width = 200;
            // 
            // cagrilacak_sinif
            // 
            this.cagrilacak_sinif.HeaderText = "Çağrılacak Kişi Sınıfı";
            this.cagrilacak_sinif.Name = "cagrilacak_sinif";
            // 
            // cagrilacak_gorev
            // 
            this.cagrilacak_gorev.HeaderText = "Çağrılacak Kişi Görevi";
            this.cagrilacak_gorev.Name = "cagrilacak_gorev";
            // 
            // cagrilacak_aciklama
            // 
            this.cagrilacak_aciklama.HeaderText = "Çağrı Açıklaması";
            this.cagrilacak_aciklama.Name = "cagrilacak_aciklama";
            this.cagrilacak_aciklama.Width = 230;
            // 
            // ÇağırmaEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 350);
            this.Controls.Add(this.tabControl1);
            this.Name = "ÇağırmaEkranı";
            this.Text = "ÇağırmaEkranı";
            this.Load += new System.EventHandler(this.ÇağırmaEkranı_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxt_aciklama;
        private System.Windows.Forms.TextBox txt_idareno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtxt_ogretmen;
        private System.Windows.Forms.TextBox txt_oIdareNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_çağrılanidare;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox rtxt_idareaciklama;
        private System.Windows.Forms.TextBox txt_çağıranidare;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_ogrenciEkleme;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbox_ogrenci;
        private System.Windows.Forms.ComboBox cmbox_ogretmen;
        private System.Windows.Forms.Button btn_ogretmenEkle;
        private System.Windows.Forms.Button btn_idareEkle;
        private System.Windows.Forms.ComboBox cmbox_idare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ListeCagri;
        private System.Windows.Forms.Button btn_datagridSil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cagrıilacak_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cagrilacak_sinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn cagrilacak_gorev;
        private System.Windows.Forms.DataGridViewTextBoxColumn cagrilacak_aciklama;
    }
}