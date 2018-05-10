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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=PansiyonDB;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            //Oda101
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = cmd1.ExecuteReader();

            while (oku1.Read())
            {
                btn101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn101.Text != "101")
            {
                btn101.BackColor = Color.Red;
            }

            //Oda102
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = cmd2.ExecuteReader();

            while (oku2.Read())
            {
                btn102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn102.Text != "102")
            {
                btn102.BackColor = Color.Red;
            }

            //Oda103
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = cmd3.ExecuteReader();

            while (oku3.Read())
            {
                btn103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn103.Text != "103")
            {
                btn103.BackColor = Color.Red;
            }

            //Oda104
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = cmd4.ExecuteReader();

            while (oku4.Read())
            {
                btn104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn104.Text != "104")
            {
                btn104.BackColor = Color.Red;
            }

            //Oda201
            baglanti.Open();
            SqlCommand cmd21 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku21 = cmd21.ExecuteReader();

            while (oku21.Read())
            {
                btn201.Text = oku21["Adi"].ToString() + " " + oku21["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn201.Text != "201")
            {
                btn201.BackColor = Color.Red;
            }

            //Oda202
            baglanti.Open();
            SqlCommand cmd22 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku22 = cmd22.ExecuteReader();

            while (oku22.Read())
            {
                btn202.Text = oku22["Adi"].ToString() + " " + oku22["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn202.Text != "202")
            {
                btn202.BackColor = Color.Red;
            }

            //Oda203
            baglanti.Open();
            SqlCommand cmd23 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku23 = cmd23.ExecuteReader();

            while (oku23.Read())
            {
                btn203.Text = oku23["Adi"].ToString() + " " + oku23["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn203.Text != "203")
            {
                btn203.BackColor = Color.Red;
            }

            //Oda204
            baglanti.Open();
            SqlCommand cmd24 = new SqlCommand("select * from Oda204", baglanti);
            SqlDataReader oku24 = cmd24.ExecuteReader();

            while (oku24.Read())
            {
                btn204.Text = oku24["Adi"].ToString() + " " + oku24["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn204.Text != "204")
            {
                btn204.BackColor = Color.Red;
            }

            //Oda301
            baglanti.Open();
            SqlCommand cmd31 = new SqlCommand("select * from Oda301", baglanti);
            SqlDataReader oku31 = cmd31.ExecuteReader();

            while (oku31.Read())
            {
                btn301.Text = oku31["Adi"].ToString() + " " + oku31["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn301.Text != "301")
            {
                btn301.BackColor = Color.Red;
            }

            //Oda302
            baglanti.Open();
            SqlCommand cmd32 = new SqlCommand("select * from Oda302", baglanti);
            SqlDataReader oku32 = cmd32.ExecuteReader();

            while (oku32.Read())
            {
                btn302.Text = oku32["Adi"].ToString() + " " + oku32["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn302.Text != "302")
            {
                btn302.BackColor = Color.Red;
            }

            //Oda303
            baglanti.Open();
            SqlCommand cmd33 = new SqlCommand("select * from Oda303", baglanti);
            SqlDataReader oku33 = cmd33.ExecuteReader();

            while (oku33.Read())
            {
                btn303.Text = oku33["Adi"].ToString() + " " + oku33["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn303.Text != "303")
            {
                btn303.BackColor = Color.Red;
            }

            //Oda304
            baglanti.Open();
            SqlCommand cmd34 = new SqlCommand("select * from Oda304", baglanti);
            SqlDataReader oku34 = cmd34.ExecuteReader();

            while (oku34.Read())
            {
                btn304.Text = oku34["Adi"].ToString() + " " + oku34["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn304.Text != "304")
            {
                btn304.BackColor = Color.Red;
            }

            //Oda401
            baglanti.Open();
            SqlCommand cmd41 = new SqlCommand("select * from Oda401", baglanti);
            SqlDataReader oku41 = cmd41.ExecuteReader();

            while (oku41.Read())
            {
                btn401.Text = oku41["Adi"].ToString() + " " + oku41["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn401.Text != "401")
            {
                btn401.BackColor = Color.Red;
            }

            //Oda402
            baglanti.Open();
            SqlCommand cmd42 = new SqlCommand("select * from Oda402", baglanti);
            SqlDataReader oku42 = cmd42.ExecuteReader();

            while (oku42.Read())
            {
                btn402.Text = oku42["Adi"].ToString() + " " + oku42["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn402.Text != "402")
            {
                btn402.BackColor = Color.Red;
            }

            //Oda403
            baglanti.Open();
            SqlCommand cmd43 = new SqlCommand("select * from Oda403", baglanti);
            SqlDataReader oku43 = cmd43.ExecuteReader();

            while (oku43.Read())
            {
                btn403.Text = oku43["Adi"].ToString() + " " + oku43["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn403.Text != "403")
            {
                btn403.BackColor = Color.Red;
            }

            //Oda404
            baglanti.Open();
            SqlCommand cmd44 = new SqlCommand("select * from Oda404", baglanti);
            SqlDataReader oku44 = cmd44.ExecuteReader();

            while (oku44.Read())
            {
                btn404.Text = oku44["Adi"].ToString() + " " + oku44["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn404.Text != "404")
            {
                btn404.BackColor = Color.Red;
            }

            //Oda501
            baglanti.Open();
            SqlCommand cmd51 = new SqlCommand("select * from Oda501", baglanti);
            SqlDataReader oku51 = cmd51.ExecuteReader();

            while (oku51.Read())
            {
                btn501.Text = oku51["Adi"].ToString() + " " + oku51["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn501.Text != "501")
            {
                btn501.BackColor = Color.Red;
            }

            //Oda502
            baglanti.Open();
            SqlCommand cmd52 = new SqlCommand("select * from Oda502", baglanti);
            SqlDataReader oku52 = cmd52.ExecuteReader();

            while (oku52.Read())
            {
                btn502.Text = oku52["Adi"].ToString() + " " + oku52["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn502.Text != "502")
            {
                btn502.BackColor = Color.Red;
            }

            //Oda503
            baglanti.Open();
            SqlCommand cmd53 = new SqlCommand("select * from Oda503", baglanti);
            SqlDataReader oku53 = cmd53.ExecuteReader();

            while (oku53.Read())
            {
                btn503.Text = oku53["Adi"].ToString() + " " + oku53["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn503.Text != "503")
            {
                btn503.BackColor = Color.Red;
            }

            //Oda504
            baglanti.Open();
            SqlCommand cmd54 = new SqlCommand("select * from Oda504", baglanti);
            SqlDataReader oku54 = cmd54.ExecuteReader();

            while (oku54.Read())
            {
                btn504.Text = oku54["Adi"].ToString() + " " + oku54["Soyadi"].ToString();
            }
            baglanti.Close();
            if (btn504.Text != "504")
            {
                btn504.BackColor = Color.Red;
            }


        }
    }
}
