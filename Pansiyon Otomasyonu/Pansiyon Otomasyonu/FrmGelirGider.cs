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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int personel = Convert.ToInt16(txtPersonelSayisi.Text);
            int maas = Convert.ToInt16(txtMaasMiktari.Text);
            lblPersonelMaas.Text = (personel * maas).ToString();

            int sonuc = Convert.ToInt32(lblKasaToplam.Text) - (Convert.ToInt16(lblPersonelMaas.Text) + Convert.ToInt16(lblGida.Text) + Convert.ToInt16(lblIcecek.Text) + Convert.ToInt16(lblAburcubur.Text) + Convert.ToInt16(lblElektrik.Text) + Convert.ToInt16(lblSu.Text) + Convert.ToInt16(lblIsinma.Text) + Convert.ToInt16(lblInternet.Text));
            if (sonuc < 0)
            {
                lblSonuc.ForeColor = Color.Red;
            }
            else
            {
                lblSonuc.ForeColor = Color.Green;
            }
            lblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

            //Kasadaki Toplam Tutar
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select Sum(Ucret) as toplam from Musteri", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                lblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //Gıda Giderleri
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select Sum(Gida) as toplam1 from Stok", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();
            while (oku2.Read())
            {
                lblGida.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            //İçecek Giderleri
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select Sum(Icecek) as toplam2 from Stok", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();
            while (oku3.Read())
            {
                lblIcecek.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //Aburcubur Giderleri
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("Select Sum(Aburcubur) as toplam3 from Stok", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();
            while (oku4.Read())
            {
                lblAburcubur.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //Elektrik Giderleri
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("Select Sum(Elektrik) as toplam4 from Fatura", baglanti);
            SqlDataReader oku5 = cmd5.ExecuteReader();
            while (oku5.Read())
            {
                lblElektrik.Text = oku5["toplam4"].ToString();
            }
            baglanti.Close();

            //Su Giderleri
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Select Sum(Su) as toplam5 from Fatura", baglanti);
            SqlDataReader oku6 = cmd6.ExecuteReader();
            while (oku6.Read())
            {
                lblSu.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();


            //Isınma Giderleri
            baglanti.Open();
            SqlCommand cmd7 = new SqlCommand("Select Sum(Isinma) as toplam6 from Fatura", baglanti);
            SqlDataReader oku7 = cmd7.ExecuteReader();
            while (oku7.Read())
            {
                lblIsinma.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();


            //İnternet Giderleri
            baglanti.Open();
            SqlCommand cmd8 = new SqlCommand("Select Sum(Internet) as toplam7 from Fatura", baglanti);
            SqlDataReader oku8 = cmd8.ExecuteReader();
            while (oku8.Read())
            {
                lblInternet.Text = oku8["toplam7"].ToString();
            }
            baglanti.Close();

        }

        
    }
}
