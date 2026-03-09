using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void radyoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kralFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
        wmp.URL = "http://46.20.3.204:80/";
        }

        private void babaRadyoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "http://37.247.98.7:80/;stream.mp3";
        }

        private void imbatFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
       wmp.URL = "http://38.96.148.39:8788/";
        }

        private void alemFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "http://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8";
        }

        private void kralPopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "http://46.20.3.201:80/";
        }

        private void istanbulFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "http://45.32.154.169:9300/";
        }

        private void kordonFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "http://38.96.148.39:8588/";
        }

        private void powerTürkToolStripMenuItem_Click(object sender, EventArgs e)
        {
        wmp.URL="http://icast.powergroup.com.tr/PowerTurk/mpeg/128/home/";
        }

        private void radyoEgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "http://stream2.taksimbilisim.com:8010/;";
        }

        private void slowTürkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "https://r3.rocketcdn.com/slowturk/abr/playlist.m3u8/";

        }

        private void süperFmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wmp.URL = "http://provisioning.streamtheworld.com/pls/SUPER_FMAAC.pls/";
        }
    }
}
