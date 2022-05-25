using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vkutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kitapListele();
            
        }
        SqlConnection baglan = new SqlConnection(@"server=.\SQLEXPRESS; initial catalog=kutuphaneV; integrated security=true");


        private void button3_Click(object sender, EventArgs e)
        {

        }


        public void kitapListele()
        {
            baglan.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM tKitap",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgkitap.DataSource = dt;
            baglan.Close();


        }

        private void btngunc_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand gunc = new SqlCommand("update tKitap set kitapAdi=@book, yazar=@writer, yayinevi=@publisher, kategori=@category where kitapId=@id", baglan);
            gunc.Parameters.AddWithValue("@book", txtkitap.Text);
            gunc.Parameters.AddWithValue("@writer", txtyazar.Text);
            gunc.Parameters.AddWithValue("@publisher", txtyayinevi.Text);
            gunc.Parameters.AddWithValue("@category", txtkategori.Text);
            gunc.Parameters.AddWithValue("@id", txtid.Text);
            gunc.ExecuteNonQuery();
            MessageBox.Show("Ürün güncellendi", "Bilgi");
            baglan.Close();
            kitapListele();
        }


        private void btnSi_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("Delete from tKitap where kitapId= @kitapId", baglan);
            sil.Parameters.AddWithValue("@kitapId", txtid.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Ürün kaydı silindi");
            baglan.Close();
            kitapListele();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO tKitap values (@kitapAdi, @yazar, @yayinevi, @kategori)", baglan);
            ekle.Parameters.AddWithValue("@kitapAdi", txtkitap.Text);
            ekle.Parameters.AddWithValue("@yazar", txtyazar.Text);
            ekle.Parameters.AddWithValue("@yayinevi", txtyayinevi.Text);
            ekle.Parameters.AddWithValue("@kategori", txtkategori.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Kayıt eklendi", "Bilgi");
            baglan.Close();
            kitapListele();
            txtid.Text = txtkitap.Text = txtyazar.Text = txtyayinevi.Text = txtkategori.Text = " ";
        }

        private void dgkitap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgkitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgkitap.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtkitap.Text = dgkitap.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtyazar.Text = dgkitap.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtyayinevi.Text = dgkitap.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtkategori.Text = dgkitap.Rows[e.RowIndex].Cells[4].Value.ToString();




        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            anaEkran anaekr = new anaEkran();
            anaekr.Show();
        }
    }
}
