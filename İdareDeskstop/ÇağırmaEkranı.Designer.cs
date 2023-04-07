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
            this.txt_öğrenciisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idareno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Çağır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_öğrenciisim
            // 
            this.txt_öğrenciisim.Location = new System.Drawing.Point(135, 129);
            this.txt_öğrenciisim.Name = "txt_öğrenciisim";
            this.txt_öğrenciisim.Size = new System.Drawing.Size(171, 20);
            this.txt_öğrenciisim.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Öğrenci İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sınıf";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "9/A",
            "9/B",
            "9/c",
            "9/D",
            "10/A",
            "10/B",
            "10/C",
            "10/D",
            "11/A",
            "11/B",
            "11/C",
            "11/D",
            "12/A",
            "12/B",
            "12/C",
            "12/D"});
            this.comboBox1.Location = new System.Drawing.Point(135, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "İdare Numarası";
            // 
            // txt_idareno
            // 
            this.txt_idareno.Location = new System.Drawing.Point(135, 42);
            this.txt_idareno.Name = "txt_idareno";
            this.txt_idareno.Size = new System.Drawing.Size(171, 20);
            this.txt_idareno.TabIndex = 12;
            // 
            // ÇağırmaEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 289);
            this.Controls.Add(this.txt_idareno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_öğrenciisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "ÇağırmaEkranı";
            this.Text = "ÇağırmaEkranı";
            this.Load += new System.EventHandler(this.ÇağırmaEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_öğrenciisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idareno;
    }
}