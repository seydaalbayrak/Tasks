namespace yenim
{
    partial class ProjeEkleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeEkleme));
            this.txtProjeAdi = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotlar = new MetroFramework.Controls.MetroTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblProjeAdiHata = new System.Windows.Forms.Label();
            this.lblMaksimumHata = new System.Windows.Forms.Label();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProjeAdi
            // 
            // 
            // 
            // 
            this.txtProjeAdi.CustomButton.Image = null;
            this.txtProjeAdi.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.txtProjeAdi.CustomButton.Name = "";
            this.txtProjeAdi.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtProjeAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProjeAdi.CustomButton.TabIndex = 1;
            this.txtProjeAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProjeAdi.CustomButton.UseSelectable = true;
            this.txtProjeAdi.CustomButton.Visible = false;
            this.txtProjeAdi.ForeColor = System.Drawing.Color.Black;
            this.txtProjeAdi.Lines = new string[0];
            this.txtProjeAdi.Location = new System.Drawing.Point(45, 67);
            this.txtProjeAdi.MaxLength = 20;
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.PasswordChar = '\0';
            this.txtProjeAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProjeAdi.SelectedText = "";
            this.txtProjeAdi.SelectionLength = 0;
            this.txtProjeAdi.SelectionStart = 0;
            this.txtProjeAdi.ShortcutsEnabled = true;
            this.txtProjeAdi.Size = new System.Drawing.Size(200, 20);
            this.txtProjeAdi.TabIndex = 0;
            this.txtProjeAdi.UseSelectable = true;
            this.txtProjeAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProjeAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProjeAdi.TextChanged += new System.EventHandler(this.txtProjeAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(41, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proje Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(45, 129);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(41, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(45, 185);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.ShortcutsEnabled = true;
            this.txtAciklama.Size = new System.Drawing.Size(200, 20);
            this.txtAciklama.TabIndex = 5;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(41, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Notlar";
            // 
            // txtNotlar
            // 
            // 
            // 
            // 
            this.txtNotlar.CustomButton.Image = null;
            this.txtNotlar.CustomButton.Location = new System.Drawing.Point(182, 2);
            this.txtNotlar.CustomButton.Name = "";
            this.txtNotlar.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtNotlar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotlar.CustomButton.TabIndex = 1;
            this.txtNotlar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotlar.CustomButton.UseSelectable = true;
            this.txtNotlar.CustomButton.Visible = false;
            this.txtNotlar.Lines = new string[0];
            this.txtNotlar.Location = new System.Drawing.Point(45, 248);
            this.txtNotlar.MaxLength = 32767;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.PasswordChar = '\0';
            this.txtNotlar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotlar.SelectedText = "";
            this.txtNotlar.SelectionLength = 0;
            this.txtNotlar.SelectionStart = 0;
            this.txtNotlar.ShortcutsEnabled = true;
            this.txtNotlar.Size = new System.Drawing.Size(200, 20);
            this.txtNotlar.TabIndex = 7;
            this.txtNotlar.UseSelectable = true;
            this.txtNotlar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotlar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(45, 284);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 25);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblProjeAdiHata
            // 
            this.lblProjeAdiHata.AutoSize = true;
            this.lblProjeAdiHata.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeAdiHata.ForeColor = System.Drawing.Color.Crimson;
            this.lblProjeAdiHata.Location = new System.Drawing.Point(42, 90);
            this.lblProjeAdiHata.Name = "lblProjeAdiHata";
            this.lblProjeAdiHata.Size = new System.Drawing.Size(169, 17);
            this.lblProjeAdiHata.TabIndex = 9;
            this.lblProjeAdiHata.Text = "! Proje Adı Boş Geçilemez";
            this.lblProjeAdiHata.Visible = false;
            // 
            // lblMaksimumHata
            // 
            this.lblMaksimumHata.AutoSize = true;
            this.lblMaksimumHata.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaksimumHata.ForeColor = System.Drawing.Color.Crimson;
            this.lblMaksimumHata.Location = new System.Drawing.Point(42, 28);
            this.lblMaksimumHata.Name = "lblMaksimumHata";
            this.lblMaksimumHata.Size = new System.Drawing.Size(174, 17);
            this.lblMaksimumHata.TabIndex = 10;
            this.lblMaksimumHata.Text = "! Maksimum sınıra ulaştınız";
            this.lblMaksimumHata.Visible = false;
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.BackColor = System.Drawing.Color.Crimson;
            this.btnIptalEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptalEt.FlatAppearance.BorderSize = 0;
            this.btnIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptalEt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalEt.ForeColor = System.Drawing.Color.White;
            this.btnIptalEt.Location = new System.Drawing.Point(45, 315);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(200, 25);
            this.btnIptalEt.TabIndex = 11;
            this.btnIptalEt.Text = "İptal Et";
            this.btnIptalEt.UseVisualStyleBackColor = false;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // ProjeEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 388);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.lblMaksimumHata);
            this.Controls.Add(this.lblProjeAdiHata);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNotlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProjeAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjeEkleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtProjeAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtNotlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblProjeAdiHata;
        private System.Windows.Forms.Label lblMaksimumHata;
        private System.Windows.Forms.Button btnIptalEt;
    }
}