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
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from PersonelGiris where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlParameter prm = new SqlParameter("PersonelId","PersonelId");
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", txtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifre", txtSifre.Text.Trim());
                SqlCommand cmd = new SqlCommand(sql, baglanti);

                cmd.Parameters.Add(prm);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);

                DataTable dt = new DataTable(); //Sanal Tablo
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hata Oluştu!");
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void FrmPersonelGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
