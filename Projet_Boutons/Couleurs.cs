using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Boutons
{
    public partial class Couleurs : Form
    {
        int compteur = 0;
        int compteur2 = 0;
        int compteur3 = 0;
        public Couleurs()
        {
            InitializeComponent();
            this.BackColor = Color.White;

        }

        private void CmdBleu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            compteur++;
            ClicksBleu.Text = compteur.ToString();
        }

        private void CmdVert_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            compteur2++;
            ClicksVert.Text = compteur2.ToString();

        }

        private void CmdRouge_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            compteur3++;
            ClicksRouge.Text = compteur3.ToString();
        }

        private void CmdRéinitialiser_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            ClicksBleu.Text = "";
            compteur = 0;
            ClicksVert.Text = "";
            compteur2 = 0;
            ClicksRouge.Text = "";
            compteur3 = 0;
        }

        private void CmdFin_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void Couleurs_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
