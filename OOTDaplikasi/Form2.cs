using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOTDaplikasi
{
    public partial class Form2 : Form
    { // Koneksi Database
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\Documents\Database1.accdb");

        void ShowData()
        {
            // Buka Database
            koneksi.Open();
            string query = "select * from barang";
            OleDbDataAdapter da = new OleDbDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();

        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "insert into barang (Nama, Stock, Harga) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            //eksekusi perintah
            cmd.ExecuteNonQuery();
            //
            koneksi.Close();
            MessageBox.Show("Data Tersimpan");
            ShowData();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Update barang set Stock = '" + textBox2.Text + "', Harga = '" + textBox3.Text + "' Where Nama = '" + textBox1.Text + "' ";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            //eksekusi perintah
            cmd.ExecuteNonQuery();
            //
            koneksi.Close();
            MessageBox.Show("Data Telah Diubah");
            ShowData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            koneksi.Open();
            string printah = "SELECT * FROM barang WHERE Nama='" + textBox1.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(printah, koneksi);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Delete from barang where ID=" + textBox4.Text;
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            //eksekusi perintah
            cmd.ExecuteNonQuery();
            //
            koneksi.Close();
            MessageBox.Show("Data Telah Dihapus");
            ShowData();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
