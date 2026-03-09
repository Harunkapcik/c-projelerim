using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_alma_oyunu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu bilgisayarın fiyatı 22.000 TL'dir, almak istediğinize emin misiniz?", "Bilgisayar Fiyatı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Bilgisayar alındı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DialogResult == DialogResult.No)
            {
                MessageBox.Show("Bilgisayar alınmadı", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("İşlem iptal edildi", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formVulcan form4 = new formVulcan();
            form4.Show();
            this.Hide();
        }
    }
}
