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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void verileriGoster()
        {
            listView1.Items.Clear();
            listView1.Enabled = true;
            listView1.ForeColor = Color.Black;
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteri where Aktif='1'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void SilinmisVerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteri where Aktif='0'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            listView1.ForeColor = Color.Gray;
            listView1.Enabled = false;
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            verileriGoster();
            
        }

        private void btnListele_Click(object sender, EventArgs e) //Yenile Butonu
        {
            TextBoxlariTemizle();
            verileriGoster();
        }

        int id = 0;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text); //Kök dizin, id'yi çektik
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {

                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update Musteri set Aktif='0' where MusteriId=(" + id + ")", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();

                //Müşteriler tablosundan ve Müşteriler formundan silmek için
                /*baglanti.Open();
                SqlCommand cmd = new SqlCommand("delete from Musteri where MusteriId=(" + id + ")", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                verileriGoster();*/

                //Odalar Tablolarından ve Odalar formundan silmek için
                string OdaNo = TxtOdaNo.Text;
                string Adi = txtAdi.Text;
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda" + OdaNo + " where Adi='" + txtAdi.Text + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Müşteriyi Seçiniz!");
                this.Close();
            }
            
        }

        private void TextBoxlariTemizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            mskTxtTel.Clear();
            txtMail.Clear();
            txtKimlikNo.Clear();
            TxtOdaNo.Clear();
            txtUcret.Clear();
            dtpGirisTarihi.Text = "";
            dtpCikisTarihi.Text = "";
            txtAra.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TextBoxlariTemizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update Musteri set Adi='" + txtAdi.Text + "',Soyadi='" + txtSoyadi.Text + "',Cinsiyet='" + cmbCinsiyet.Text + "',Telefon='" + mskTxtTel.Text+ "',Mail='" + txtMail.Text + "',KimlikNo='" + txtKimlikNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi='" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where MusteriId=" + id + "", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteri where Adi like '%"+txtAra.Text+"%'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Musteri where Adi like '%" + txtAra.Text + "%'", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnArşiv_Click(object sender, EventArgs e)
        {
            TextBoxlariTemizle();            
            SilinmisVerileriGoster();            
        }
    }
}
