namespace yenim
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.flowToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblToDo = new System.Windows.Forms.Label();
            this.flowInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.flowRevision = new System.Windows.Forms.FlowLayoutPanel();
            this.flowCheck = new System.Windows.Forms.FlowLayoutPanel();
            this.flowDone = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRevision = new System.Windows.Forms.Label();
            this.lblProjelereDon = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.btnProjeSil = new System.Windows.Forms.Button();
            this.DragDropRbtn = new System.Windows.Forms.RadioButton();
            this.EditRbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // flowToDo
            // 
            this.flowToDo.Location = new System.Drawing.Point(10, 40);
            this.flowToDo.Name = "flowToDo";
            this.flowToDo.Size = new System.Drawing.Size(150, 390);
            this.flowToDo.TabIndex = 0;
            this.flowToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowToDo_DragDrop);
            this.flowToDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowToDo_DragEnter);
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToDo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblToDo.Location = new System.Drawing.Point(10, 21);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(41, 16);
            this.lblToDo.TabIndex = 4;
            this.lblToDo.Text = "To Do";
            // 
            // flowInProgress
            // 
            this.flowInProgress.Location = new System.Drawing.Point(164, 40);
            this.flowInProgress.Name = "flowInProgress";
            this.flowInProgress.Size = new System.Drawing.Size(150, 390);
            this.flowInProgress.TabIndex = 1;
            this.flowInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowInProgress_DragDrop);
            this.flowInProgress.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowInProgress_DragEnter);
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInProgress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInProgress.Location = new System.Drawing.Point(168, 21);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(71, 16);
            this.lblInProgress.TabIndex = 5;
            this.lblInProgress.Text = "In Progress";
            // 
            // flowRevision
            // 
            this.flowRevision.Location = new System.Drawing.Point(318, 40);
            this.flowRevision.Name = "flowRevision";
            this.flowRevision.Size = new System.Drawing.Size(150, 390);
            this.flowRevision.TabIndex = 2;
            this.flowRevision.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowRevision_DragDrop);
            this.flowRevision.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowRevision_DragEnter);
            // 
            // flowCheck
            // 
            this.flowCheck.Location = new System.Drawing.Point(472, 40);
            this.flowCheck.Name = "flowCheck";
            this.flowCheck.Size = new System.Drawing.Size(150, 390);
            this.flowCheck.TabIndex = 3;
            this.flowCheck.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowCheck_DragDrop);
            this.flowCheck.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowCheck_DragEnter);
            // 
            // flowDone
            // 
            this.flowDone.Location = new System.Drawing.Point(626, 40);
            this.flowDone.Name = "flowDone";
            this.flowDone.Size = new System.Drawing.Size(150, 390);
            this.flowDone.TabIndex = 4;
            this.flowDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowDone_DragDrop);
            this.flowDone.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowDone_DragEnter);
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRevision.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRevision.Location = new System.Drawing.Point(315, 21);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(56, 16);
            this.lblRevision.TabIndex = 7;
            this.lblRevision.Text = "Revision";
            // 
            // lblProjelereDon
            // 
            this.lblProjelereDon.AutoSize = true;
            this.lblProjelereDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProjelereDon.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjelereDon.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProjelereDon.Location = new System.Drawing.Point(816, 440);
            this.lblProjelereDon.Name = "lblProjelereDon";
            this.lblProjelereDon.Size = new System.Drawing.Size(87, 16);
            this.lblProjelereDon.TabIndex = 8;
            this.lblProjelereDon.Text = "Projelere Dön";
            this.lblProjelereDon.Click += new System.EventHandler(this.lblProjelereDon_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCheck.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCheck.Location = new System.Drawing.Point(469, 21);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(47, 16);
            this.lblCheck.TabIndex = 9;
            this.lblCheck.Text = "Check";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDone.Location = new System.Drawing.Point(628, 24);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(39, 16);
            this.lblDone.TabIndex = 10;
            this.lblDone.Text = "Done";
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTaskEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskEkle.FlatAppearance.BorderSize = 0;
            this.btnTaskEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskEkle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTaskEkle.ForeColor = System.Drawing.Color.White;
            this.btnTaskEkle.Location = new System.Drawing.Point(10, 436);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(75, 25);
            this.btnTaskEkle.TabIndex = 11;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = false;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // lblBaslangicTarihi
            // 
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangicTarihi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(780, 50);
            this.lblBaslangicTarihi.Name = "lblBaslangicTarihi";
            this.lblBaslangicTarihi.Size = new System.Drawing.Size(99, 16);
            this.lblBaslangicTarihi.TabIndex = 12;
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi";
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitisTarihi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBitisTarihi.Location = new System.Drawing.Point(780, 108);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(111, 16);
            this.lblBitisTarihi.TabIndex = 13;
            this.lblBitisTarihi.Text = "Tahmini Bitiş Tarihi";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBaslangic.Location = new System.Drawing.Point(780, 77);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(13, 15);
            this.lblBaslangic.TabIndex = 14;
            this.lblBaslangic.Text = "0";
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTahmin.Location = new System.Drawing.Point(780, 137);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(13, 15);
            this.lblTahmin.TabIndex = 15;
            this.lblTahmin.Text = "0";
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.BackColor = System.Drawing.Color.Crimson;
            this.btnProjeSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjeSil.FlatAppearance.BorderSize = 0;
            this.btnProjeSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjeSil.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProjeSil.ForeColor = System.Drawing.Color.White;
            this.btnProjeSil.Location = new System.Drawing.Point(114, 436);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(75, 25);
            this.btnProjeSil.TabIndex = 16;
            this.btnProjeSil.Text = "Proje Sil";
            this.btnProjeSil.UseVisualStyleBackColor = false;
            this.btnProjeSil.Click += new System.EventHandler(this.btnProjeSil_Click);
            // 
            // DragDropRbtn
            // 
            this.DragDropRbtn.AutoSize = true;
            this.DragDropRbtn.Checked = true;
            this.DragDropRbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DragDropRbtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DragDropRbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DragDropRbtn.Location = new System.Drawing.Point(229, 438);
            this.DragDropRbtn.Name = "DragDropRbtn";
            this.DragDropRbtn.Size = new System.Drawing.Size(100, 20);
            this.DragDropRbtn.TabIndex = 18;
            this.DragDropRbtn.TabStop = true;
            this.DragDropRbtn.Text = "Sürükle Bırak";
            this.DragDropRbtn.UseVisualStyleBackColor = true;
            this.DragDropRbtn.CheckedChanged += new System.EventHandler(this.DragDropRbtn_CheckedChanged);
            // 
            // EditRbtn
            // 
            this.EditRbtn.AutoSize = true;
            this.EditRbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRbtn.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EditRbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EditRbtn.Location = new System.Drawing.Point(344, 438);
            this.EditRbtn.Name = "EditRbtn";
            this.EditRbtn.Size = new System.Drawing.Size(73, 20);
            this.EditRbtn.TabIndex = 19;
            this.EditRbtn.TabStop = true;
            this.EditRbtn.Text = "Düzenle";
            this.EditRbtn.UseVisualStyleBackColor = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 468);
            this.Controls.Add(this.EditRbtn);
            this.Controls.Add(this.DragDropRbtn);
            this.Controls.Add(this.btnProjeSil);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.lblBaslangicTarihi);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.lblProjelereDon);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.flowDone);
            this.Controls.Add(this.flowCheck);
            this.Controls.Add(this.flowRevision);
            this.Controls.Add(this.lblInProgress);
            this.Controls.Add(this.flowInProgress);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.flowToDo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tasks";
            this.Load += new System.EventHandler(this.Task_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowToDo;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.FlowLayoutPanel flowInProgress;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.FlowLayoutPanel flowRevision;
        private System.Windows.Forms.FlowLayoutPanel flowCheck;
        private System.Windows.Forms.FlowLayoutPanel flowDone;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.Label lblProjelereDon;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.Button btnProjeSil;
        private System.Windows.Forms.RadioButton DragDropRbtn;
        private System.Windows.Forms.RadioButton EditRbtn;
    }
}