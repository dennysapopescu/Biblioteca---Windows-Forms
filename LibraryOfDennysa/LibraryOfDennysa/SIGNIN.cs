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
    public partial class SIGNIN : Form
    {
        public SIGNIN()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butonSign_Click(object sender, EventArgs e)
        {
            timer1.Start();
            using (System.IO.StreamWriter wr = File.AppendText("D://POLI//LibraryOfDennysa//LibraryOfDennysa//bin//Debug//users.txt"))
            {
                wr.WriteLine(textBoxUs.Text + ", " + textBoxPs.Text + "\n");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            progressBar1.Value = progressBar1.Value - 1;
            progressBar1.Value = progressBar1.Value + 1;
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("V-ati inregistrat cu succes!");
                Application.Restart();
            }
        }
    }
}
