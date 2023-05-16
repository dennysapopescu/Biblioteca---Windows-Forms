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
    public partial class ADAUGARE_CARTE : Form
    {
        public ADAUGARE_CARTE()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=DESKTOP-T2DNOF6\SQLEXPRESS; Initial Catalog=Biblioteca; Integrated Security=True";
            SqlConnection cnn = new SqlConnection(con);
            cnn.Open();
            string inserare = "insert into Library ([id], [titlu], [autor], [editura], [domeniu], [anaparitie], [nrpag]) values (@id, @titlu, @autor, @editura, @domeniu, @anaparitie, @nrpag)";
            SqlCommand sc = new SqlCommand(inserare, cnn);
            sc.Parameters.AddWithValue("@id", textBoxID.Text);
            sc.Parameters.AddWithValue("@titlu", textBoxTitlu.Text);
            sc.Parameters.AddWithValue("@autor", textBoxAutor.Text);
            sc.Parameters.AddWithValue("@editura", textBoxEditura.Text);
            sc.Parameters.AddWithValue("@domeniu", textBoxDom.Text);
            sc.Parameters.AddWithValue("@anaparitie", textBoxAn.Text);
            sc.Parameters.AddWithValue("@nrpag", textBoxPag.Text);
            sc.ExecuteNonQuery();
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Cartea a fost adaugata cu succes!");
            this.Close();
            cnn.Close();
        }

        private bool validare_titlu(string sender)
        {
            bool ok = true;
            List<string> Pattern = new List<string> { "^", "<", ">", ";", "|", "'", "/",".", ",", "\\", ":", "=", "?", "*" };
            for(int i=0; i<Pattern.Count;i++)
            {
                if(sender.Contains(Pattern[i]))
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        private bool validare_autor(string sender)
        {
            bool ok = true;
            List<string> Pattern = new List<string> { "^", "<", ">", ";", "|", "'", "/", ",", "\\", ":", "=", "?", "*","0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            for(int i=0; i<Pattern.Count;i++)
            {
                if(sender.Contains(Pattern[i]))
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }


        private void textBoxTitlu_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTitlu.Text))
            {
                button1.Enabled = false;
                textBoxTitlu.Focus();
                errorProviderTitlu.SetError(textBoxTitlu, "In acest camp nu a fost introdus nimic!");
            }
            else  if (validare_titlu(textBoxTitlu.Text) != true)
            {
                button1.Enabled = false;
                textBoxTitlu.Focus();
                errorProviderTitlu.SetError(textBoxTitlu, "Titlul introdus este invalid!");
            }
            
            else
            {
                button1.Enabled = true;
                errorProviderTitlu.SetError(textBoxTitlu, null);
            }
        }

        private void textBoxAutor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAutor.Text))
            {
                button1.Enabled = false;
                textBoxAutor.Focus();
                errorProviderAutor.SetError(textBoxAutor, "In acest camp nu a fost introdus nimic!");
            }
            else if (validare_autor(textBoxAutor.Text) != true)
            {
                button1.Enabled = false;
                textBoxAutor.Focus();
                errorProviderAutor.SetError(textBoxAutor, "Numele autorului este invalid!");
            }
            else
            {
                button1.Enabled = true;
                errorProviderAutor.SetError(textBoxAutor, null);
                
            }

            
        }
    }
}
