using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOfDennysa
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            string[] users = File.ReadAllLines("D://POLI//LibraryOfDennysa//LibraryOfDennysa//bin//Debug//users.txt");
            foreach(var linie in users)
            {
                string[] signin = linie.Split(',');
                comboBoxUser.Items.Add(signin[0]);
            }
        }
        private int trycnt = 0;

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void butonLogin_Click(object sender, EventArgs e)
        {
            string[] users = File.ReadAllLines("D://POLI//LibraryOfDennysa//LibraryOfDennysa//bin//Debug//users.txt");
            foreach(var linie in users)
            {
                string[] signin = linie.Split(',');
                if((comboBoxUser.Text).Equals(signin[0]))
                {
                    if((textBoxPass.Text.Trim()).Equals(signin[1].Trim()))
                    {
                        ACTIUNI f = new ACTIUNI();
                        f.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        trycnt++;
                        MessageBox.Show("Parola introdusa este gresita! V-au mai ramas " + (5 - trycnt).ToString() + " incercari!");
                        textBoxPass.Text = String.Empty;
                    }
                }
                if(trycnt==5)
                {
                    MessageBox.Show("Numarul de incercari a fost depasit!");
                    Application.Exit();
                }
            }
        }

        private void butonSign_Click(object sender, EventArgs e)
        {
            SIGNIN f = new SIGNIN();
            f.ShowDialog();
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
