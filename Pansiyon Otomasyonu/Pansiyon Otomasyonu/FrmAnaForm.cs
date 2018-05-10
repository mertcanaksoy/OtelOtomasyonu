using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Otomasyonu
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris prg = new FrmPersonelGiris();
            prg.Show();
            this.Hide();
        }
    

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler musteri = new FrmMusteriler();
            musteri.Show();
            
        }


        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris per = new FrmPersonelGiris();
            this.Hide();
            per.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            FrmYeniMusteri musteri = new FrmYeniMusteri();
            musteri.Show();
        }

        private void btnOdalar_Click_1(object sender, EventArgs e)
        {
            FrmOdalar odalar = new FrmOdalar();
            odalar.Show();
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FrmGelirGider gelgit = new FrmGelirGider();
            gelgit.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            FrmStok stok = new FrmStok();
            stok.Show();
        }

        private void btnRadyo_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle rdy = new FrmRadyoDinle();
            rdy.Show();
        }      

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle sifre = new FrmSifreGuncelle();
            sifre.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular duyuru = new FrmDuyurular();
            duyuru.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri yeni = new FrmYeniMusteri();
            yeni.Show();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMusteriler must = new FrmMusteriler();
            must.Show();
        }

        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdalar odalar = new FrmOdalar();
            odalar.Show();
        }

        private void stokFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStok stok = new FrmStok();
            stok.Show();
        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirGider kasa = new FrmGelirGider();
            kasa.Show();
        }

        private void duyurularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDuyurular duyurular = new FrmDuyurular();
            duyurular.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPersonelGiris personelGiris = new FrmPersonelGiris();
            this.Close();
            personelGiris.Show();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle sifre = new FrmSifreGuncelle();
            sifre.Show();
        }

        private void radyoDinleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle rdy = new FrmRadyoDinle();
            rdy.Show();
        }
    }
}
