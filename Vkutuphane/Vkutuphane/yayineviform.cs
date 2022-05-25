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
    public partial class yayineviform : Form
    {
        public yayineviform()
        {
            InitializeComponent();
        }

        yayinEF yynef = new yayinEF();

        public void getdata()
        {
            yayindgv.DataSource = yynef.tyayins.ToList();
        }


        public void clear()
        {
            txtid.Text = txtkitap.Text = txtyayin.Text = txtkateg.Text = " ";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtkateg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            int tablyyn = Convert.ToInt32(txtid.Text);
            var gunc = yynef.tyayins.First(x => x.id == tablyyn);

            gunc.yayn = txtyayin.Text;
            gunc.ktp = txtkitap.Text;
            gunc.ktgr = txtkateg.Text;


            yynef.SaveChanges();
            MessageBox.Show("Güncelleme yapıldı..");
            clear();
            getdata();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            tyayin tablyyn = new tyayin();

            tablyyn.id = Convert.ToInt32(txtid.Text);
            tablyyn.yayn = txtyayin.Text;
            tablyyn.ktp = txtkitap.Text;
            tablyyn.ktgr = txtkateg.Text;

            yynef.tyayins.Add(tablyyn);
            yynef.SaveChanges();
            MessageBox.Show("Bilgiler eklendi!");
            clear();
            getdata();


        }

        private void yayindgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = yayindgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtyayin.Text = yayindgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtkitap.Text = yayindgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtkateg.Text = yayindgv.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void yayineviform_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int tablyyn = Convert.ToInt32(txtid.Text);
            var sil = yynef.tyayins.First(x => x.id == tablyyn);

            yynef.tyayins.Remove(sil);
            yynef.SaveChanges();
            MessageBox.Show("Bilgiler silindi.");
            clear();
            getdata();
        }
    }
}
