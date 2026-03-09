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
    public partial class formVulcan : Form
    {
        public formVulcan()
        {
            InitializeComponent();
        }

        private void formVulcan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tebrikler, bilgisayar alındı.","uyarı",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
