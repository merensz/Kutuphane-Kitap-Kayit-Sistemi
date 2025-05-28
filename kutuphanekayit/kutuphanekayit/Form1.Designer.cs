namespace kutuphanekayit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnListele = new Button();
            txtTckn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtKitapIsmi = new TextBox();
            label3 = new Label();
            txtYazar = new TextBox();
            label4 = new Label();
            txtIlkTarih = new TextBox();
            label5 = new Label();
            txtSonTarih = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(276, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 409);
            dataGridView1.TabIndex = 15;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 249);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(214, 42);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(12, 297);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(214, 42);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(12, 345);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(214, 42);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(12, 393);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(214, 42);
            btnListele.TabIndex = 4;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // txtTckn
            // 
            txtTckn.Location = new Point(80, 37);
            txtTckn.Name = "txtTckn";
            txtTckn.Size = new Size(146, 23);
            txtTckn.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "TCKN:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 69);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Kitap İsmi:";
            // 
            // txtKitapIsmi
            // 
            txtKitapIsmi.Location = new Point(80, 66);
            txtKitapIsmi.Name = "txtKitapIsmi";
            txtKitapIsmi.Size = new Size(146, 23);
            txtKitapIsmi.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 99);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 10;
            label3.Text = "Yazar:";
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(80, 95);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(146, 23);
            txtYazar.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 128);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 12;
            label4.Text = "İlk Tarih:";
            // 
            // txtIlkTarih
            // 
            txtIlkTarih.Location = new Point(80, 124);
            txtIlkTarih.Name = "txtIlkTarih";
            txtIlkTarih.Size = new Size(146, 23);
            txtIlkTarih.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 157);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 14;
            label5.Text = "Son Tarih:";
            // 
            // txtSonTarih
            // 
            txtSonTarih.Location = new Point(80, 153);
            txtSonTarih.Name = "txtSonTarih";
            txtSonTarih.Size = new Size(146, 23);
            txtSonTarih.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(41, 220);
            txtId.Name = "txtId";
            txtId.Size = new Size(86, 23);
            txtId.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 223);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 17;
            label6.Text = "ID:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(txtSonTarih);
            Controls.Add(label4);
            Controls.Add(txtIlkTarih);
            Controls.Add(label3);
            Controls.Add(txtYazar);
            Controls.Add(label2);
            Controls.Add(txtKitapIsmi);
            Controls.Add(label1);
            Controls.Add(txtTckn);
            Controls.Add(btnListele);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Kütüphane Kitap Kayıt Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnListele;
        private TextBox txtTckn;
        private Label label1;
        private Label label2;
        private TextBox txtKitapIsmi;
        private Label label3;
        private TextBox txtYazar;
        private Label label4;
        private TextBox txtIlkTarih;
        private Label label5;
        private TextBox txtSonTarih;
        private TextBox txtId;
        private Label label6;
    }
}
