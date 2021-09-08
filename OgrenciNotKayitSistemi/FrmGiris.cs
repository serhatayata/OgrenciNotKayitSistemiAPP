using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotKayitSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked){
                    FrmOgrenciDetay frm = new FrmOgrenciDetay();
                    frm.numara = GirisMaskedTextBox.Text;
                    frm.Show();
            }
            else if (radioButton1.Checked && GirisMaskedTextBox.Text == "1881")
            {
                    FrmOgretmenDetay frm = new FrmOgretmenDetay();
                    frm.Show();
                    GirisMaskedTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Yanlış Numara Girdiniz, Tekrar Deneyiniz...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GirisMaskedTextBox.Text = "";
            }
        }
        private void ogrenciMaskTextBox_TextChanged(object sender, EventArgs e)
        {
            //if(ogrenciMaskTextBox.Text == "1111")
            //{
            //    FrmOgretmenDetay frm = new FrmOgretmenDetay();
            //    frm.Show();
            //}
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                girisNumaralabel.Text = "Öğretmen Numara";
            }
            else
            {
                girisNumaralabel.Text = "Öğrenci Numara";
            }
        }
    }
}
