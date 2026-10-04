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
    public partial class Tableau : Form
    {
        const int n = 5;
        float[] T = new float[n];
        int i = 0;
        public Tableau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float val;

            // Vérification de la note
            if (float.TryParse(TxtN.Text, out val) && val >= 0 && val <= 20)
            {
                // Stocker la note dans le tableau
                T[i] = val;

                // Afficher la note dans LblT
                LblT.Text = LblT.Text + TxtN.Text + " | ";

                // Passer à l'élève suivant
                i++;

                // Vider la TextBox
                TxtN.Text = "";

                // Remettre le curseur dans TxtN
                TxtN.Focus();

                // Vérifier si les 5 notes sont enregistrées
                if (i == n)
                {
                    BtnCale.Enabled = true;
                    BtnEnreg.Enabled = false;
                    TxtN.Enabled = false;

                    BtnCale.Focus();

                    LblRes.Text = "Les 5 notes sont enregistrées.";
                }
                else
                {
                    LblRes.Text = "Entrez la note de l'élève N° " + (i + 1);
                }
            }
            else
            {
                MessageBox.Show(
                    "Veuillez saisir une note entre 0 et 20.",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                TxtN.SelectAll();
                TxtN.Focus();
            }

        }

        private void Tableau_Load(object sender, EventArgs e)
        {
            // Initialisation
            LblT.Text = "";
            LblMoy.Text = "";
            LblEcart.Text = "";
            LblInf.Text = "";
            LblSup.Text = "";

            BtnCale.Enabled = false;

            TxtN.Focus();

            LblRes.Text = "Entrez la note de l'élève N° 1";
        }

        private void LblRes_Click(object sender, EventArgs e)
        {

        }

        private void TxtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblT_Click(object sender, EventArgs e)
        {

        }

        private void LblMoy_Click(object sender, EventArgs e)
        {

        }

        private void LblEcart_Click(object sender, EventArgs e)
        {

        }

        private void LblInf_Click(object sender, EventArgs e)
        {

        }

        private void LblSup_Click(object sender, EventArgs e)
        {

        }

        private void BtnCale_Click(object sender, EventArgs e)
        {
            float somme = 0;
            float moyenne;
            float variance = 0;
            float ecartType;

            int nbInf = 0;
            int nbSup = 0;



            for (int j = 0; j < n; j++)
            {
                somme = somme + T[j];

                if (T[j] < 10)
                {
                    nbInf++;
                }
                else
                {
                    nbSup++;
                }
            }



            moyenne = somme / n;



            for (int j = 0; j < n; j++)
            {
                variance = variance + (T[j] - moyenne) * (T[j] - moyenne);
            }

            variance = variance / n;

            ecartType = (float)Math.Sqrt(variance);



            LblMoy.Text = moyenne.ToString("0.00");

            LblEcart.Text = ecartType.ToString("0.00");

            LblInf.Text = nbInf.ToString();

            LblSup.Text = nbSup.ToString();

            LblRes.Text = "Calcul terminé.";
        }

        private void BtnQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
