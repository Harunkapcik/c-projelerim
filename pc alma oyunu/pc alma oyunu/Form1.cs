using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_alma_oyunu
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

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (cikis == DialogResult.No)
            {
                // Do nothing
            }
        }
        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txtKullaniciAdi.Text;
            var sifre = txtSifre.Text;
            
            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
