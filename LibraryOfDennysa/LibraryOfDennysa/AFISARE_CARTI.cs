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
    public partial class AFISARE_CARTI : Form
    {
        public AFISARE_CARTI()
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

        private void AFISARE_CARTI_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-T2DNOF6\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            string inserare_tabel = "select * from Library";
            SqlDataAdapter ins = new SqlDataAdapter(inserare_tabel, con);
            DataSet ins_set = new DataSet();
            ins.Fill(ins_set, "Library");
            dataGridView1.DataSource = ins_set.Tables["Library"].DefaultView;
            cnn.Close();
        }
    }
}
