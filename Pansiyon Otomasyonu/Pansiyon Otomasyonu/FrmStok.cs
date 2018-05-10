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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void stokVeriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Stok", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Aburcubur"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void faturaVeriler()
        {
            listViewFatura.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from Fatura", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["Isinma"].ToString());
                ekle.SubItems.Add(oku["Internet"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                listViewFatura.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            stokVeriler();
            faturaVeriler();
        }

        private void txtFaturaKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Fatura (Elektrik,Su,Isinma,Internet,Tarih) values ('" + txtElektrik.Text + "','" + txtSu.Text + "','" + txtIsinma.Text + "','" + txtInternet.Text + "','" + dtpFaturaTarih.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            cmd1.ExecuteNonQuery();
            baglanti.Close();
            faturaVeriler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into Stok (Gida,Icecek,Aburcubur,Tarih) values ('" + txtGida.Text + "','" + txtIcecek.Text + "','" + txtAburcubur.Text + "','" + dtpTarih.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            stokVeriler();
        }
    }
}
