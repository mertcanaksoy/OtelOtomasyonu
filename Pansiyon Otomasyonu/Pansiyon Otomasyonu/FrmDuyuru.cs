using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Otomasyonu
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void verileriGoster()
        {
            lwDuyurular.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Duyurular where Aktif='1'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["DuyuruId"].ToString();
                ekle.SubItems.Add(oku["KullaniciAdi"].ToString());
                ekle.SubItems.Add(oku["DuyuruMetni"].ToString());



                lwDuyurular.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            verileriGoster(); //Listelenmiş duyurular

            //Combobox'a veri çekme
            baglanti.Open();
            SqlCommand combo = new SqlCommand("select * from PersonelGiris order by KullaniciAdi asc", baglanti);
            combo.CommandType = CommandType.Text;

            SqlDataReader dr = combo.ExecuteReader();
            while (dr.Read())
            {
                cmbKullaniciAdi.Items.Add(dr["KullaniciAdi"]);

            }
            baglanti.Close();

        }

        private void btnDuyuruEkle_Click(object sender, EventArgs e)
        {
            //FrmDuyuruEkle ekle = new FrmDuyuruEkle();
            //ekle.Show();
            //this.Hide();
            
            if (cmbKullaniciAdi.Text =="")
            {
                cmbKullaniciAdi.Focus();
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz!");
            }
            else if(rtxtDuyuru.Text == "")
            {
                rtxtDuyuru.Focus();
                MessageBox.Show("Duyuru Kısmı Boş Bırakılamaz!");
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Duyurular (KullaniciAdi,DuyuruMetni,Aktif) values('" + cmbKullaniciAdi.Text + "','" + rtxtDuyuru.Text + "','true')", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Duyuru Başarıyla Eklendi!");
                verileriGoster();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Duyurular set Aktif='0' where DuyuruId="+id+"", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            GirdileriTemizle();
        }

        int id = 0;
        private void lwDuyurular_MouseClick(object sender, MouseEventArgs e)
        {
            cmbKullaniciAdi.Enabled = false;
            id = int.Parse(lwDuyurular.SelectedItems[0].SubItems[0].Text); //Kök dizin, id'yi çektik
            cmbKullaniciAdi.Text = lwDuyurular.SelectedItems[0].SubItems[1].Text;
            rtxtDuyuru.Text = lwDuyurular.SelectedItems[0].SubItems[2].Text;                        
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Duyurular set DuyuruMetni='"+rtxtDuyuru.Text+"' where DuyuruId=" + id + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            GirdileriTemizle();
        }

        private void GirdileriTemizle()
        {
            cmbKullaniciAdi.Text = "";
            cmbKullaniciAdi.Enabled = true;
            rtxtDuyuru.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            GirdileriTemizle();
        }
    }
}
