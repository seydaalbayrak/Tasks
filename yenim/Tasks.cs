using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yenim
{
    public partial class Tasks : MetroForm
    {
        public Tasks()
        {
            InitializeComponent();
        }
        public int projectId { get; set; }
        public string projectName { get; set; }
        public string userName { get; set; }
        public int userId { get; set; }
        public string taskName { get; set; }
        private void Task_Load(object sender, EventArgs e)
        {
            //Eklenen panellerin Drag Drop özelliklerinin açılması
            flowDone.AllowDrop = true;
            flowToDo.AllowDrop = true;
            flowRevision.AllowDrop = true;
            flowCheck.AllowDrop = true;
            flowInProgress.AllowDrop = true;
            //Gerekli bilgilerin ekrana yazılması
            proje.ProjeGetir(projectName);
            projectId = proje.projeId;
            lblBaslangic.Text = proje.baslangicTarihi;
            lblTahmin.Text = proje.tahminiSure;
            PanelGuncelle(projectId);
            
            
        }
        List<Button> buttons=new List<Button>();
        Button selectBtn = new Button();
        cBaglanti baglanti = new cBaglanti();
        cProje proje = new cProje();
        cKart kart = new cKart();

        //Task durumlarının bulunduğu panellerin güncellenmesi

        public void PanelGuncelle(int projectId)
        {
            YapilacaklarListesi(projectId);
            DevamEdilenlerListesi(projectId);
            KontrolListesi(projectId);
            RevizyonListesi(projectId);
            YapildiListesi(projectId);
        }

        //Birinci durumun veritabanından çekilerek listelenmesi
        public void YapilacaklarListesi(int projectId)
        {

            using (SqlCommand m = new SqlCommand("exec ListStatus0Tasks @ProjectId", baglanti.Baglanti()))
            {
                flowToDo.Controls.Clear();
             
                m.Parameters.AddWithValue("@ProjectId", projectId);
                SqlDataReader oku = m.ExecuteReader();
                while (oku.Read())
                {
                    Button btn = new Button();
                    btn.ForeColor = Color.DodgerBlue; 
                    btn.Text = String.Concat(oku["TaskName"]);                    
                    btn.Size = new System.Drawing.Size(140, 25);
                    btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.MouseClick += new MouseEventHandler(yapilacaklar_Click);
                    btn.MouseDown += new MouseEventHandler(yapilacaklar_MouseDown);
                    if (DragDropRbtn.Checked)
                    {
                        
                        btn.MouseClick -= new MouseEventHandler(yapilacaklar_Click);

                    }
                    else if(EditRbtn.Checked)
                    {
                        
                        btn.MouseDown -= new MouseEventHandler(yapilacaklar_MouseDown);
                    }
                   
                    flowToDo.Controls.Add(btn);
                    buttons.Add(btn);

                }

            }
        }
        //Listelenen taskların tıklanınca açacağı forma yönlendirme
        void yapilacaklar_Click(object sender,EventArgs e)
        {
            
            TaskAyarları task = new TaskAyarları();
            task.kullaniciNo = userId;
            task.KullaniciAdi = userName;
            task.ProjeAdi = projectName;
            task.ProjeNo = projectId;
            task.KartAdi = ((Button)sender).Text;
            task.Show();
            this.Hide();


        }
        //Drag Drop işlemine başladığımız yer(Statü 1 için )
        void yapilacaklar_MouseDown(object sender,EventArgs e)
        {
          
            Button downBtn = new Button();
            downBtn=buttons.FirstOrDefault(x => x.Text==((Button)sender).Text);
            downBtn.DoDragDrop(downBtn, DragDropEffects.Copy);
            selectBtn = downBtn;
            taskName = ((Button)sender).Text;
            kart.ProjeGetir(taskName);
            taskName = "";
        }
        //2. durumun veritabanından çekilerek panele listelenmesi
        public void DevamEdilenlerListesi(int projectId)
        {

            using (SqlCommand m = new SqlCommand("exec ListStatus1Tasks @ProjectId", baglanti.Baglanti()))
            {
                flowInProgress.Controls.Clear();
                
                m.Parameters.AddWithValue("@ProjectId", projectId);
                SqlDataReader oku = m.ExecuteReader();
                while (oku.Read())
                {
                    Button btn = new Button();
                    btn.ForeColor = Color.DodgerBlue;
                    btn.Text = String.Concat(oku["TaskName"]);                   
                    btn.Size = new System.Drawing.Size(140, 25);
                    btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Flat;
                    
                    btn.MouseClick += new MouseEventHandler(devamEdilenler_Click);
                    btn.MouseDown += new MouseEventHandler(devamEdilenler_MouseDown);
                    if (DragDropRbtn.Checked)
                    {

                        btn.MouseClick -= new MouseEventHandler(devamEdilenler_Click);
                       

                    }
                    else if (EditRbtn.Checked)
                    {

                        btn.MouseDown -= new MouseEventHandler(devamEdilenler_MouseDown);
                     
                    }

                    flowInProgress.Controls.Add(btn);
                    buttons.Add(btn);
                    


                }

            }
        }
        //2. durum üzerinde oluşturulan butonların tıklanma durumunda yapılacaklar
        void devamEdilenler_Click(object sender, EventArgs e)
        {

            TaskAyarları task = new TaskAyarları();
            task.kullaniciNo = userId;
            task.KullaniciAdi = userName;
            task.ProjeAdi = projectName;
            task.ProjeNo = projectId;
            task.KartAdi = ((Button)sender).Text;
            task.Show();
            this.Hide();
        }
        //2. durumun Mouse down özelliği çalıştırılınca yapılacaklar
        void devamEdilenler_MouseDown(object sender, EventArgs e)
        {

            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == ((Button)sender).Text);
            downBtn.DoDragDrop(downBtn, DragDropEffects.Copy);
            selectBtn = downBtn;
            taskName = ((Button)sender).Text;
            kart.ProjeGetir(taskName);
            taskName = "";
        }
        //3. durumun veritabından çekilerek listelenmesi
        public void RevizyonListesi(int projectId)
        {

            using (SqlCommand m = new SqlCommand("exec ListStatus2Tasks @ProjectId", baglanti.Baglanti()))
            {

                flowRevision.Controls.Clear();
                m.Parameters.AddWithValue("@ProjectId", projectId);
                SqlDataReader oku = m.ExecuteReader();
                while (oku.Read())
                {
                    Button btn = new Button();
                    btn.ForeColor = Color.DodgerBlue;
                    btn.Text = String.Concat(oku["TaskName"]);
                    btn.Size = new System.Drawing.Size(140, 25);
                    btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.MouseClick += new MouseEventHandler(revizyon_Click);
                    btn.MouseDown += new MouseEventHandler(revizyon_MouseDown);
                    if (DragDropRbtn.Checked)
                    {

                        btn.MouseClick -= new MouseEventHandler(revizyon_Click);

                    }
                    else if (EditRbtn.Checked)
                    {

                        btn.MouseDown -= new MouseEventHandler(revizyon_MouseDown);
                    }
                    flowRevision.Controls.Add(btn);
                    buttons.Add(btn);
                }

            }
        }
        //3. durum panelinde üzerinde bulunan butonlara tıklanınca çalışacak blok
        void revizyon_Click(object sender, EventArgs e)
        {
            TaskAyarları task = new TaskAyarları();
            task.kullaniciNo = userId;
            task.KullaniciAdi = userName;
            task.ProjeAdi = projectName;
            task.ProjeNo = projectId;
            task.KartAdi = ((Button)sender).Text;
            task.Show();
            this.Hide();
        }
        //3. durumun mouse down özelliğinin çalıştırılmasında çalışacak buton
        void revizyon_MouseDown(object sender, EventArgs e)
        {
            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == ((Button)sender).Text);
            downBtn.DoDragDrop(downBtn, DragDropEffects.Copy);
            selectBtn = downBtn;
            taskName = ((Button)sender).Text;
            kart.ProjeGetir(taskName);
            taskName = "";

        }
        //4. durumun veritabanından çekilerek listelenmesi
        public void KontrolListesi(int projectId)
        {

            using (SqlCommand m = new SqlCommand("exec ListStatus3Tasks @ProjectId", baglanti.Baglanti()))
            {
                flowCheck.Controls.Clear();
                m.Parameters.AddWithValue("@ProjectId", projectId);
                SqlDataReader oku = m.ExecuteReader();
                while (oku.Read())
                {
                    
                    Button btn = new Button();
                    btn.ForeColor = Color.DodgerBlue;
                    btn.Text = String.Concat(oku["TaskName"]);
                    btn.Size = new System.Drawing.Size(140, 25);
                    btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.MouseClick += new MouseEventHandler(kontrol_Click);
                    btn.MouseDown += new MouseEventHandler(kontrol_MouseDown);
                    if (DragDropRbtn.Checked)
                    {

                        btn.MouseClick -= new MouseEventHandler(kontrol_Click);

                    }
                    else if (EditRbtn.Checked)
                    {

                        btn.MouseDown -= new MouseEventHandler(kontrol_MouseDown);
                    }
                    flowCheck.Controls.Add(btn);
                    buttons.Add(btn);
                }

            }
        }
        //4. durumun üzerinde bulunan butonlara tıklayınca çalışacak olan blok
        void kontrol_Click(object sender, EventArgs e)
        {
            TaskAyarları task = new TaskAyarları();
            task.kullaniciNo = userId;
            task.KullaniciAdi = userName;
            task.ProjeAdi = projectName;
            task.ProjeNo = projectId;
            task.KartAdi = ((Button)sender).Text;
            task.Show();
            this.Hide();
        }
        //4. durumun mouse down özelliğinin çalışması durumunda çalışcak olan blok
        void kontrol_MouseDown(object sender, EventArgs e)
        {

            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == ((Button)sender).Text);
            downBtn.DoDragDrop(downBtn, DragDropEffects.Copy);
            selectBtn = downBtn;
            taskName = ((Button)sender).Text;
            kart.ProjeGetir(taskName);
            taskName = "";

        }
        //5. durumun panel üzerinde listelenmesi
        public void YapildiListesi(int projectId)
        {

            using (SqlCommand m = new SqlCommand("exec ListStatus4Tasks @ProjectId", baglanti.Baglanti()))
            {
                flowDone.Controls.Clear();
                m.Parameters.AddWithValue("@ProjectId", projectId);
                SqlDataReader oku = m.ExecuteReader();
                while (oku.Read())
                {
                    Button btn = new Button();
                    btn.ForeColor = Color.DodgerBlue;
                    btn.Text = String.Concat(oku["TaskName"]);
                    btn.Size = new System.Drawing.Size(140, 25);
                    btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.MouseClick += new MouseEventHandler(yapildi_Click);
                    btn.MouseDown += new MouseEventHandler(yapildi_MouseDown);
                    if (DragDropRbtn.Checked)
                    {

                        btn.MouseClick -= new MouseEventHandler(yapildi_Click);

                    }
                    else if (EditRbtn.Checked)
                    {

                        btn.MouseDown -= new MouseEventHandler(yapildi_MouseDown);
                    }
                    flowDone.Controls.Add(btn);
                    buttons.Add(btn);
                }

            }
        }
        //5. durum paneli üzerinde bulunan butonların üzerine tıklanınca çalışacak blok
        void yapildi_Click(object sender, EventArgs e)
        {
            TaskAyarları task = new TaskAyarları();
            task.kullaniciNo = userId;
            task.KullaniciAdi = userName;
            task.ProjeAdi = projectName;
            task.ProjeNo = projectId;
            task.KartAdi = ((Button)sender).Text;
            task.Show();
            this.Hide();
        }
        //5. durum paneli üzerinde bulunan butonların mouse down özelliği çalışması ile çalışacak blok 
        void yapildi_MouseDown(object sender, EventArgs e)
        {

            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == ((Button)sender).Text);
            downBtn.DoDragDrop(downBtn, DragDropEffects.Copy);
            selectBtn = downBtn;
            taskName = ((Button)sender).Text;
            kart.ProjeGetir(taskName);
            taskName = "";

        }
        //Projeler sayfasına dönmek için kullanılan blok
        private void lblProjelereDon_Click(object sender, EventArgs e)
        {
            Projeler panolar = new Projeler();
            panolar.kullaniciAdi = userName;
            panolar.Show();
            this.Hide();
        }
        //Yeni bir task eklemek için yeni forma yönlendiren blok
        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            TaskAyarları task = new TaskAyarları();
            task.kullaniciNo = userId;
            task.ProjeNo = projectId;
            task.ProjeAdi = projectName;
            task.KartAdi = "Kart Adı";
            task.KullaniciAdi = userName;
            task.Show();
            this.Hide();

        }
        //Proje silmek için çalıştırılan blok
        private void btnProjeSil_Click(object sender, EventArgs e)
        {
            proje.ProjeGetir(projectName);
            proje.ProjeSil(proje.projeId);
            Projeler panolar = new Projeler();
            panolar.kullaniciAdi = userName;
            panolar.kullaniciId = userId;
            panolar.Show();
            this.Hide();
        }

        private void flowInProgress_DragDrop(object sender, DragEventArgs e)
        {
           
            var obj = e.Data.GetFormats()[0];
            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == selectBtn.Text);
            flowInProgress.Controls.Add(downBtn);;
            kart.KartDurumuGuncelle(kart.KartNo, 1);
            taskName = "";
            PanelGuncelle(projectId); 
        }

        private void flowInProgress_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            taskName = "";

        }

        private void DragDropRbtn_CheckedChanged(object sender, EventArgs e)
        {
            PanelGuncelle(projectId);
            taskName = "";
            
        }

        

        private void flowToDo_DragDrop(object sender, DragEventArgs e)
        {
            var obj = e.Data.GetFormats()[0];
            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == selectBtn.Text);
            flowToDo.Controls.Add(downBtn);
           
            kart.KartDurumuGuncelle(kart.KartNo, 0);
            taskName = "";
            PanelGuncelle(projectId);


        }


        private void flowToDo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            taskName = "";
        }

        private void flowRevision_DragDrop(object sender, DragEventArgs e)
        {
            var obj = e.Data.GetFormats()[0];
            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == selectBtn.Text);
            flowRevision.Controls.Add(downBtn);
            kart.KartDurumuGuncelle(kart.KartNo, 2);
            taskName = "";
            PanelGuncelle(projectId);

        }

        private void flowRevision_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            taskName = "";
        }

        private void flowCheck_DragDrop(object sender, DragEventArgs e)
        {
            var obj = e.Data.GetFormats()[0];
            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == selectBtn.Text);
            flowCheck.Controls.Add(downBtn);
            kart.KartDurumuGuncelle(kart.KartNo, 3);
            taskName = "";
            PanelGuncelle(projectId);
        }

        private void flowCheck_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            taskName = "";
        }

        private void flowDone_DragDrop(object sender, DragEventArgs e)
        {
            var obj = e.Data.GetFormats()[0];
            Button downBtn = new Button();
            downBtn = buttons.FirstOrDefault(x => x.Text == selectBtn.Text);
            flowDone.Controls.Add(downBtn);
            kart.KartDurumuGuncelle(kart.KartNo, 4);
            taskName = "";
            PanelGuncelle(projectId);
        }

        private void flowDone_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            taskName = "";
        }

      
    }
}
