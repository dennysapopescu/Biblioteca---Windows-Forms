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
    public partial class STERGERE_CARTI : Form
    {
        public STERGERE_CARTI()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AFISARE_CARTI f = new AFISARE_CARTI();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-T2DNOF6\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            string sterg = "delete from Library where titlu='" + textBoxSterg.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sterg, cnn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Library");
            sda.Dispose();
            ds.Dispose();
            string update_tab = "select * from Library";
            SqlDataAdapter sda1 = new SqlDataAdapter(update_tab, cnn);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1, "Library");
            sda1.Dispose();
            ds1.Dispose();
            cnn.Close();
            MessageBox.Show("Cartea a fost stearsa din biblioteca!");
            textBoxSterg.Text = String.Empty;
        }
    }
}
