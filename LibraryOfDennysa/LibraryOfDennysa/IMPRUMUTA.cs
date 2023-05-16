using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOfDennysa
{
    public partial class IMPRUMUTA : Form
    {
        public IMPRUMUTA()
        {
            InitializeComponent();
            string[] users = File.ReadAllLines("D://POLI//LibraryOfDennysa//LibraryOfDennysa//bin//Debug//users.txt");
            foreach (var linie in users)
            {
                string[] signin = linie.Split(',');
                comboBoxUser.Items.Add(signin[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                string titluCarte = textBoxImp.Text;
                string numeUtilizator = comboBoxUser.Text;
                DateTime dataImprumut = DateTime.Now;


            string[] users = File.ReadAllLines("D://POLI//LibraryOfDennysa//LibraryOfDennysa//bin//Debug//users.txt");
            foreach (var linie in users)
            {
                string[] signin = linie.Split(',');
                if ((comboBoxUser.Text).Equals(signin[0]))
                {


                    // Salvare in baza de date
                    try
                    {
                        string connectionString = @"Data Source=DESKTOP-T2DNOF6\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security=True";

                        SqlConnection cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        string inserare = "insert into ImprumutCarte ([TitluCarte], [NumeUtilizator], [DataImprumut]) values (@TitluCarte, @NumeUtilizator, @DataImprumut)";
                        SqlCommand command = new SqlCommand(inserare, cnn);
                        command.Parameters.AddWithValue("@TitluCarte", titluCarte);
                        command.Parameters.AddWithValue("@NumeUtilizator", numeUtilizator);
                        command.Parameters.AddWithValue("@DataImprumut", dataImprumut);
                        command.ExecuteNonQuery();
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Cartea a fost împrumutată cu succes!");
                        cnn.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare la împrumutarea cărții: " + ex.Message);
                    }
                }
            }

        }


        private void IMPRUMUTA_Load(object sender, EventArgs e)
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

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-T2DNOF6\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            string sterg = "delete from ImprumutCarte where TitluCarte='" + textBoxImp.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sterg, cnn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "ImprumutCarte");
            sda.Dispose();
            ds.Dispose();
            string update_tab = "select * from ImprumutCarte";
            SqlDataAdapter sda1 = new SqlDataAdapter(update_tab, cnn);
            DataSet ds1 = new DataSet();
            sda1.Fill(ds1, "ImprumutCarte");
            sda1.Dispose();
            ds1.Dispose();
            cnn.Close();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Cartea a fost returnata!");
            textBoxImp.Text = String.Empty;
        }
    }
}
