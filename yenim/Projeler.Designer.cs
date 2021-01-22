namespace yenim
{
    partial class Projeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projeler));
            this.btnProjeEkle = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCikisYap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.BackColor = System.Drawing.Color.FloralWhite;
            this.btnProjeEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjeEkle.FlatAppearance.BorderSize = 0;
            this.btnProjeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjeEkle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProjeEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnProjeEkle.Location = new System.Drawing.Point(0, 22);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(850, 35);
            this.btnProjeEkle.TabIndex = 0;
            this.btnProjeEkle.Text = "Proje Ekle";
            this.btnProjeEkle.UseVisualStyleBackColor = false;
            this.btnProjeEkle.Click += new System.EventHandler(this.btnProjeEkle_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 83);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(804, 344);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblCikisYap
            // 
            this.lblCikisYap.AutoSize = true;
            this.lblCikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCikisYap.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisYap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCikisYap.Location = new System.Drawing.Point(767, 430);
            this.lblCikisYap.Name = "lblCikisYap";
            this.lblCikisYap.Size = new System.Drawing.Size(62, 16);
            this.lblCikisYap.TabIndex = 4;
            this.lblCikisYap.Text = "Çıkış Yap";
            this.lblCikisYap.Click += new System.EventHandler(this.lblCikisYap_Click);
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.lblCikisYap);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnProjeEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Projeler";
            this.Load += new System.EventHandler(this.Panolar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProjeEkle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblCikisYap;
    }
}