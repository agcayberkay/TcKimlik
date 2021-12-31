using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikNoSorgulama
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TcKimlikNoDogrulama.KPSPublic kPSPublic = new TcKimlikNoDogrulama.KPSPublic();
           bool kontrol = kPSPublic.TCKimlikNoDogrula(long.Parse(txtTc.Text), txtAd.Text.ToUpper(), txtSoyad.Text.ToUpper(), int.Parse(txtDogumYılı.Text));

            if (kontrol)
            {
                MessageBox.Show("Bilgileriniz doğrulandı!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz doğrulanamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
