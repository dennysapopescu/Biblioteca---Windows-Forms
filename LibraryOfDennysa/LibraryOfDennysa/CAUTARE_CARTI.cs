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

namespace LibraryOfDennysa
{
    public partial class CAUTARE_CARTI : Form
    {
        public CAUTARE_CARTI()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CAUTARE_CARTI_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-T2DNOF6\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            string cautare_tabel = "select * from Library";
            SqlDataAdapter sd = new SqlDataAdapter(cautare_tabel, con);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Library");
            dataGridView1.DataSource = ds.Tables["Library"].DefaultView;
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-T2DNOF6\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security=True";
            SqlConnection con1 = new SqlConnection(con);
            SqlConnection con2 = new SqlConnection(con);
            con1.Open();
            con2.Open();
            string caut = "select * from Library where domeniu='" + textBoxCaut.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(caut, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Library");
            dataGridView1.DataSource = ds.Tables["Library"].DefaultView;
            con1.Close();
            con2.Close();
            sda.Dispose();
            ds.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxCaut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
