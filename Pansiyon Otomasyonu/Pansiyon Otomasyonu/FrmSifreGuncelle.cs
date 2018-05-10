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
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Kullanıcı adı ve şifre, eşleşiyor mu? Bunları sorgula
            //Eşleşiyorsa şifreyi değiştir, eşleşmiyorsa hata mesajı ver.
            try
            {
                baglanti.Open();
                string sql = "select * from PersonelGiris where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", txtKullaniciAdi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifre", txtEskiSifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);

                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable(); //Sanal Tablo
                SqlDataAdapter adp = new SqlDataAdapter(komut);

                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand("update PersonelGiris set KullaniciAdi='" + txtKullaniciAdi.Text + "',Sifre='" + txtYeniSifre.Text + "' where KullaniciAdi='" + txtKullaniciAdi.Text + "'", baglanti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Şifre başarıyla değiştirildi!");

                }
                else MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik hata, tekrar deneyin!");
            }
            finally
            {
                baglanti.Close();
            }

        }
    }
}

