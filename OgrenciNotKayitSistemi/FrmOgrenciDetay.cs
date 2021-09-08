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
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-34G34T7\SQLEXPRESS01;Initial Catalog=DbNotKayit;Integrated Security=True");
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            numaraLbl.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBL_DERS where OGRNUMARA=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1",numara);
            SqlDataReader dr = komut.ExecuteReader(); //Veri okuyucu komutu
            // Veritabanındaki verileri okuduğu sürece, aynı numarayla karşılaşana kadar
            while (dr.Read()) 
            {
                adSoyadLabel.Text = dr[2].ToString() +" "+ dr[3].ToString();
                sinav1Label.Text = dr[4].ToString();
                sinav2Label.Text = dr[5].ToString();
                sinav3Label.Text = dr[6].ToString();
                ortalamaLabel.Text = dr[7].ToString();
                if (dr[8].ToString() == "false")
                {
                    durumLabel.Text = "Başarısız";
                }
                else
                {
                    durumLabel.Text = "Başarılı";
                }
            }
            baglanti.Close();



        }
    }
}
