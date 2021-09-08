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

namespace OgrenciNotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-34G34T7\SQLEXPRESS01;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBL_DERS' table. You can move, or remove it, as needed.
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
            cmbBox_Value();
            sinavEkleTextBox1.MaxLength = 3;
            sinavEkleTextBox2.MaxLength = 3;
            sinavEkleTextBox3.MaxLength = 3;
            ogrenciSayisi();
            gecenOgrenciSayisi();
            kalanOgrenciSayisi();
        }
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBL_DERS (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", ogrenciEkleMaskedTextBox.Text);
                komut.Parameters.AddWithValue("@p2", ogrenciEkleAd.Text);
                komut.Parameters.AddWithValue("@p3", ogrenciEkleSoyad.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
            }
            catch
            {
                MessageBox.Show("Girdiğiniz numara ile kayıt bulunmaktadır!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
                ogrenciEkleMaskedTextBox.Clear();
                ogrenciEkleAd.Clear();
                ogrenciEkleSoyad.Clear();
            }   
        }
        private void cmbBox_Value()
        {
            baglanti.Open();
            SqlCommand veriOku = new SqlCommand("select OGRNUMARA,OGRAD,OGRSOYAD,OGRS1,OGRS2,OGRS3,DURUM from TBL_DERS where OGRNUMARA=@p1", baglanti);
            veriOku.Parameters.AddWithValue("@p1", cmbBoxNumara.SelectedValue);
            veriOku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = veriOku.ExecuteReader();
            while (oku.Read())
            {
                labelOgrenciBilgiAdValue.Text = oku["OGRAD"].ToString();
                labelOgrenciBilgiSoyadValue.Text = oku["OGRSOYAD"].ToString();
                labelOgrenciBilgiNumaraValue.Text = oku["OGRNUMARA"].ToString();
                labelOgrenciBilgiSinav1Value.Text = oku["OGRS1"].ToString();
                labelOgrenciBilgiSinav2Value.Text = oku["OGRS2"].ToString();
                labelOgrenciBilgiSinav3Value.Text = oku["OGRS3"].ToString();

                if (oku["DURUM"].ToString() == "False")
                {
                    lblBilgiDurum.Text = "Başarısız";
                }
                else if (oku["DURUM"].ToString() == "True")
                {
                    lblBilgiDurum.Text = "Başarılı";
                }
            }
            oku.Close();
            baglanti.Close();
            //Ortalama
                double ortalama, s1, s2, s3;
                s1 = Convert.ToDouble(labelOgrenciBilgiSinav1Value.Text);
                s2 = Convert.ToDouble(labelOgrenciBilgiSinav2Value.Text);
                s3 = Convert.ToDouble(labelOgrenciBilgiSinav3Value.Text);
                ortalama = (s1 + s2 + s3) / 3;
                if(ortalama.ToString().Length > 3)
                {
                  labelDurumOrtalamaValue.Text = ortalama.ToString().Substring(0,4);
                }
                else
                {
                labelDurumOrtalamaValue.Text = ortalama.ToString();
                }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxNumara.SelectedIndex == -1)
            {
                cmbBoxNumara.SelectedIndex = cmbBoxNumara.SelectedIndex;
            }
            else
            {
                cmbBox_Value();
            }
        }
        private void ogrenciSayisi()
        {
            baglanti.Open();
            SqlCommand veriOku = new SqlCommand("select top 1 OGRID from TBL_DERS order by OGRID desc", baglanti);
            veriOku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = veriOku.ExecuteReader();
            while (oku.Read())
            {
                labelDurumOgrenciSayisiValue.Text = oku["OGRID"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }
        private void gecenOgrenciSayisi()
        {
            baglanti.Open();
            SqlCommand veriOku = new SqlCommand("select COUNT(*) as Result from TBL_DERS t where DURUM=1", baglanti);
            veriOku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = veriOku.ExecuteReader();
            while (oku.Read())
            {
                labelDurumGecenSayisiValue.Text = oku["Result"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }
        private void kalanOgrenciSayisi()
        {
            baglanti.Open();
            SqlCommand veriOku = new SqlCommand("select COUNT(*) as Result from TBL_DERS t where DURUM=0", baglanti);
            veriOku.ExecuteNonQuery();
            SqlDataReader oku;
            oku = veriOku.ExecuteReader();
            while (oku.Read())
            {
                labelDurumKalanSayisiValue.Text = oku["Result"].ToString();
            }
            oku.Close();
            baglanti.Close();
        }
        private void buttonSinavGuncelle_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            bool durum;
            s1 = Convert.ToDouble(sinavEkleTextBox1.Text);
            s2 = Convert.ToDouble(sinavEkleTextBox2.Text);
            s3 = Convert.ToDouble(sinavEkleTextBox3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            labelDurumOrtalamaValue.Text =ortalama.ToString();
            if (ortalama >= 50)
            {
                durum = true;
            }
            else
            {
                durum = false;
            }
            //GECEN VE KALAN SAYISI, TOPLAM OGRENCI SAYISI
            ogrenciSayisi();
            gecenOgrenciSayisi();
            kalanOgrenciSayisi();
            //
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBL_DERS set OGRS1=@p1,OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4,DURUM=@p5 where OGRNUMARA=@P6", baglanti);
            komut.Parameters.AddWithValue("@p1", sinavEkleTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", sinavEkleTextBox2.Text);
            komut.Parameters.AddWithValue("@p3", sinavEkleTextBox3.Text);
            komut.Parameters.AddWithValue("@p4", float.Parse(labelDurumOrtalamaValue.Text));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", cmbBoxNumara.SelectedValue);
            komut.ExecuteNonQuery();
            MessageBox.Show("Öğrenci Notları Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            cmbBox_Value();
            this.tBL_DERSTableAdapter.Fill(this.dbNotKayitDataSet.TBL_DERS);
            sinavEkleTextBox1.Clear();
            sinavEkleTextBox2.Clear();
            sinavEkleTextBox3.Clear();
        }
        private void sinavEkleTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(sinavEkleTextBox1.Text + e.KeyChar) >= 101 ||
                sinavEkleTextBox1.Text == "0") && c != '\b')
                e.Handled = true; // handled = true yapmamız basılan tuşu geçersiz saymak içindir.
        }
        private void sinavEkleTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(sinavEkleTextBox2.Text + e.KeyChar) >= 101 ||
                sinavEkleTextBox2.Text == "0") && c != '\b')
                e.Handled = true; // handled = true yapmamız basılan tuşu geçersiz saymak içindir.
        }
        private void sinavEkleTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(sinavEkleTextBox3.Text + e.KeyChar) >= 101 ||
                sinavEkleTextBox3.Text == "0") && c != '\b')
                e.Handled = true; // handled = true yapmamız basılan tuşu geçersiz saymak içindir.
        }

        private void ogrenciEkleMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ogrenciEkleAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void ogrenciEkleSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
    }
} 
