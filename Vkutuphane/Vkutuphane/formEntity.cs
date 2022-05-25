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
    public partial class formEntity : Form
    {
        public formEntity()
        {
            InitializeComponent();
        }
        kutuphaneVEntities1 kef = new kutuphaneVEntities1();
        


        public void getData()
        {
            yazardgw.DataSource = kef.efYazars.ToList();
        
        }
        public void clear()
        {
            txtId.Text = yazar.Text = bio.Text = eser.Text = txtAra.Text = " ";
        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bio_TextChanged(object sender, EventArgs e)
        {

        }

        private void eser_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void formEntity_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void yazardgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = yazardgw.Rows[e.RowIndex].Cells[0].Value.ToString();
            yazar.Text = yazardgw.Rows[e.RowIndex].Cells[1].Value.ToString();
            bio.Text = yazardgw.Rows[e.RowIndex].Cells[2].Value.ToString();
            eser.Text = yazardgw.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            efYazar tyazar = new efYazar();
            tyazar.id = Convert.ToInt32(txtId.Text);
            tyazar.yazar = yazar.Text;
            tyazar.bio = bio.Text;
            tyazar.eser = eser.Text;

            kef.efYazars.Add(tyazar);
            kef.SaveChanges();
            MessageBox.Show("Yazar bilgileri kaydedildi.");
            getData();
            clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int tyazar = Convert.ToInt32(txtId.Text);
            var sil = kef.efYazars.First(x => x.id == tyazar);

            kef.efYazars.Remove(sil);
            kef.SaveChanges();
            MessageBox.Show("Yazar bilgileri silindi.");
            getData();
            clear();

        }

        private void btngnc_Click(object sender, EventArgs e)
        {
            int tyazar = Convert.ToInt32(txtId.Text);
            var gunc = kef.efYazars.First(x => x.id == tyazar);

            gunc.yazar = yazar.Text;
            gunc.bio = bio.Text;
            gunc.eser = eser.Text;

            kef.SaveChanges();
            MessageBox.Show("Kayıt güncellendi!");
            getData();
            clear();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (txtAra.Text != string.Empty)
            {
                var ara = kef.efYazars.Where(x => x.yazar.Contains(txtAra.Text));
                yazardgw.DataSource = ara.ToList();
            }
            else
            {
                getData();
            }
        }
    }
}
