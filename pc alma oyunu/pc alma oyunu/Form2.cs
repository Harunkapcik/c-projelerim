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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHazirSistem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pek yakında!!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPcBilesen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pek yakında!!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
