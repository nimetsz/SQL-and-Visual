using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vkutuphane
{
    public partial class anaEkran : Form
    {
        public anaEkran()
        {
            InitializeComponent();
        }

        private void btnkitap_Click(object sender, EventArgs e)
        {
            Form1 ekrkitap = new Form1();
            ekrkitap.Show();
        }

        private void btnyazar_Click(object sender, EventArgs e)
        {
            formEntity formyzr = new formEntity();
            formyzr.Show();
        }

        private void anaEkran_Load(object sender, EventArgs e)
        {

        }

        private void btnyayinevi_Click(object sender, EventArgs e)
        {
            yayineviform formyayin = new yayineviform();
            formyayin.Show();
        }
    }
}
