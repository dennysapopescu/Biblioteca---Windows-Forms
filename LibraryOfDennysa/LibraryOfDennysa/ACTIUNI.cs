using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOfDennysa
{
    public partial class ACTIUNI : Form
    {
        public ACTIUNI()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butonAdd_Click(object sender, EventArgs e)
        {
            ADAUGARE_CARTE f = new ADAUGARE_CARTE();
            f.ShowDialog();
        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            AFISARE_CARTI f = new AFISARE_CARTI();
            f.ShowDialog();
        }

        private void buttonCaut_Click(object sender, EventArgs e)
        {
            CAUTARE_CARTI f = new CAUTARE_CARTI();
            f.ShowDialog();
        }

        private void buttonSterg_Click(object sender, EventArgs e)
        {
            STERGERE_CARTI f = new STERGERE_CARTI();
            f.ShowDialog();
        }

        private void ACTIUNI_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN f = new LOGIN();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IMPRUMUTA f = new IMPRUMUTA();
            f.ShowDialog();
        }
    }
}
