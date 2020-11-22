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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Create connection with database
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\Documents\login.accdb");

            // Create dataadapter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "' ", con);

            // create datatable
            DataTable dt = new DataTable();

            // fill datatable
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                // means the username and password is correct
                Form2 f2 = new Form2();
                f2.Show();
               
            }
            else
            {
                // means the username and password is incorret
                MessageBox.Show("invalid username or password try again ...");
            }
        }
    }
}
