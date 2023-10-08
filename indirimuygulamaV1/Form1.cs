using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirimuygulamaV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati=Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
            lblİndirimlifiyat.Text=indirimliFiyat.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.25;
            lblİndirimlifiyat.Text = indirimliFiyat.ToString();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.50;
            lblİndirimlifiyat.Text = indirimliFiyat.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int etiketFiyati;
            double indirimliFiyat;
            etiketFiyati = Convert.ToInt32(txtFiyat.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.75;
            lblİndirimlifiyat.Text = indirimliFiyat.ToString();
        }
    }
}
