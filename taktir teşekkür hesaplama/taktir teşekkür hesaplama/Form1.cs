using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taktir_teşekkür_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float ortalama;
            ortalama = Convert.ToSingle(textBox1.Text);
            if (ortalama >=50) {
                if (ortalama > 70)
                    MessageBox.Show("Tebrikler,teşekkür belgesi aldınız");
                else if (ortalama > 85)

                    MessageBox.Show("tebrikler,teşekkür belgesi aldınız");

                else if (ortalama >= 50)
                    MessageBox.Show("tebrikler,sınıfı geçtiniz");
            }
            if (ortalama < 50)
                MessageBox.Show("sınıfta kaldınız");
        }
    }
}
