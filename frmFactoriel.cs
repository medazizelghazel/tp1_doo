using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp0
{
    public partial class frmFactoriel : Form
    {
        public frmFactoriel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TxtN.Text);
            if (n < 0) {
                LblRes.Text = "le nmbre doit etre superieur a 0";
            }
            else
            {
                int fact = 1;

                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

                LblRes.Text = fact.ToString();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
