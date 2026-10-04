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
    public partial class Jeux : Form
    {
        List<TextBox> LTxtC = new List<TextBox>();
        List<TextBox> LTxtP = new List<TextBox>();

        int nbJeux = 0;
        bool animation = false;

        Random random = new Random();
        public Jeux()
        {
            InitializeComponent();
        }

        private void Txt2_Click(object sender, EventArgs e)
        {

        }

        private void Jeux_Load(object sender, EventArgs e)
        {
            // Ajouter les TextBox du nombre caché
            LTxtC.Add(Txt1);
            LTxtC.Add(Txt2);
            LTxtC.Add(Txt3);
            LTxtC.Add(Txt4);

            // Ajouter les TextBox de la proposition
            LTxtP.Add(TxtP1);
            LTxtP.Add(TxtP2);
            LTxtP.Add(TxtP3);
            LTxtP.Add(TxtP4);


            // ======================================
            // Génération du nombre caché
            // ======================================

            int n1, n2, n3, n4;

            // Premier chiffre
            n1 = random.Next(0, 10);
            Txt1.Text = n1.ToString();


            // Deuxième chiffre
            do
            {
                n2 = random.Next(0, 10);
            }
            while (n2 == n1);

            Txt2.Text = n2.ToString();


            // Troisième chiffre
            do
            {
                n3 = random.Next(0, 10);
            }
            while (n3 == n1 || n3 == n2);

            Txt3.Text = n3.ToString();


            // Quatrième chiffre
            do
            {
                n4 = random.Next(0, 10);
            }
            while (n4 == n1 || n4 == n2 || n4 == n3);

            Txt4.Text = n4.ToString();


            // ======================================
            // Initialisation
            // ======================================

            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].Text = "";
                LTxtP[i].BackColor = Color.White;
            }

            // Cacher le nombre
            for (int i = 0; i < 4; i++)
            {
                LTxtC[i].ForeColor = Color.White;
            }

            nbJeux = 0;

            LblNbJeu.Text = "1";
        }

        private void nouvP_Click(object sender, EventArgs e)
        {
            Rejouer_Click(sender, e);
        }

        private void affiich_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtC[i].ForeColor = Color.Black;
            }
        }

        private void Cacher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                LTxtC[i].ForeColor = Color.White;
            }
        }

        private void Verif_Click(object sender, EventArgs e)
        {
            int correct = 0;

            // Vérifier que les 4 chiffres sont saisis
            for (int i = 0; i < 4; i++)
            {
                if (LTxtP[i].Text == "")
                {
                    MessageBox.Show(
                        "Veuillez saisir les 4 chiffres.",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }


            // ======================================
            // Comparaison
            // ======================================

            for (int i = 0; i < 4; i++)
            {
                // Chiffre correctement placé
                if (LTxtP[i].Text == LTxtC[i].Text)
                {
                    LTxtP[i].BackColor = Color.Lime;

                    correct++;
                }
                else
                {
                    // Recherche si le chiffre existe ailleurs
                    for (int j = 0; j < 4; j++)
                    {
                        if (LTxtP[i].Text == LTxtC[j].Text)
                        {
                            LTxtP[i].BackColor = Color.Yellow;

                            break;
                        }
                        else
                        {
                            LTxtP[i].BackColor = Color.White;
                        }
                    }
                }
            }


            // ======================================
            // Vérifier si le joueur a gagné
            // ======================================

            if (correct == 4)
            {
                MessageBox.Show(
                    "Félicitations ! Vous avez trouvé le nombre.",
                    "Bravo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }


            // ======================================
            // Compter la tentative
            // ======================================

            nbJeux++;

            LblNbJeu.Text = (nbJeux + 1).ToString();


            // ======================================
            // Maximum 3 propositions
            // ======================================

            if (nbJeux == 3)
            {
                // Afficher le nombre caché
                for (int i = 0; i < 4; i++)
                {
                    LTxtC[i].ForeColor = Color.Black;
                }

                MessageBox.Show(
                    "Vous avez perdu",
                    "Game Over",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                );

                Verif.Enabled = false;
            }
        }

        private void Rejouer_Click(object sender, EventArgs e)
        {
            // Nettoyer les propositions
            for (int i = 0; i < 4; i++)
            {
                LTxtP[i].BackColor = Color.White;
                LTxtP[i].Text = "";
            }


            // Générer un nouveau nombre
            int n1, n2, n3, n4;

            n1 = random.Next(0, 10);
            Txt1.Text = n1.ToString();

            do
            {
                n2 = random.Next(0, 10);
            }
            while (n2 == n1);

            Txt2.Text = n2.ToString();

            do
            {
                n3 = random.Next(0, 10);
            }
            while (n3 == n1 || n3 == n2);

            Txt3.Text = n3.ToString();

            do
            {
                n4 = random.Next(0, 10);
            }
            while (n4 == n1 || n4 == n2 || n4 == n3);

            Txt4.Text = n4.ToString();


            // Cacher le nouveau nombre
            for (int i = 0; i < 4; i++)
            {
                LTxtC[i].ForeColor = Color.White;
            }


            // Réinitialiser le nombre de tentatives
            nbJeux = 0;

            LblNbJeu.Text = "1";

            Verif.Enabled = true;

            LTxtP[0].Focus();

        }

        private void LblNbJeu_Click(object sender, EventArgs e)
        {

        }

        private void TxtP4_Click(object sender, EventArgs e)
        {

        }

        private void quiter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
