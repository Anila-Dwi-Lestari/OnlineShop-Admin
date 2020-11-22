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
    public partial class Form3 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\Documents\transaksi.accdb");
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string x = textBox1.Text;
            if(x == "1")
            {
                textBox2.Text += "Sweater";
                textBox6.Text += 100000;
                
            }
            if (x == "2")
            {
                textBox2.Text += "Hoodie";
                textBox6.Text += 150000;

            }
            if (x == "3")
            {
                textBox2.Text += "Kemeja";
                textBox6.Text += 250000;

            }

            //Konversi Typedata
            string y = textBox5.Text;
            string a = textBox6.Text;
            int dbl = int.Parse(y);
            int l = int.Parse(a);
            string z = textBox4.Text;
            int k = int.Parse(z);
            string w = textBox3.Text;
            

            int p = k-l * dbl;
            string j = p.ToString();
            textBox3.Text = j;
        }
    }
}
