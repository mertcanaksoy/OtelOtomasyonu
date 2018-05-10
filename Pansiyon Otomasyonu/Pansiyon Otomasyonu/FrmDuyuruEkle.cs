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
    public partial class FrmDuyuruEkle : Form
    {
        public FrmDuyuruEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");


        private void btnGonder_Click(object sender, EventArgs e)
        {
            
            if (cmbKullaniciAdi.Text==""|| rtxtMesaj.Text=="")
            {
                MessageBox.Show("Boş Alanları Doldurun!");
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into Duyurular (KullaniciAdi,DuyuruMetni,Aktif) values('" + cmbKullaniciAdi.Text + "','" + rtxtMesaj.Text + "','true')", baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Duyuru Başarıyla Eklendi!");
            }
            
        }

        private void FrmDuyuruEkle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand combo = new SqlCommand("select * from PersonelGiris order by KullaniciAdi asc",baglanti);
            combo.CommandType = CommandType.Text;

            SqlDataReader dr = combo.ExecuteReader();
            while (dr.Read())
            {
                cmbKullaniciAdi.Items.Add(dr["KullaniciAdi"]);
                
            }
            baglanti.Close();
        }
    }
}
