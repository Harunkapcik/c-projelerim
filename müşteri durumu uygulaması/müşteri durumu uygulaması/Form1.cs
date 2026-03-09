using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace müşteri_durumu_uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sonuc;
            sayi1=Convert.ToInt32(textBox1.Text);
            if (sayi1 < 500)
                MessageBox.Show("bütceniz yeterli değil");
            else if (sayi1 > 500)
                MessageBox.Show("yine bekleriz");
            else
                MessageBox.Show("lütfen fiyat giriniz.");
        }
    }
}
