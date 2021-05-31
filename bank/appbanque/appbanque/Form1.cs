using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appbanque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addclient = new addclient();
            addclient.Show();
        }

        private void epargneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addcompteepargne = new addcompteepargne();
            addcompteepargne.Show();
        }

        private void courantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form addcomptecourant = new addcomptecourant();
            addcomptecourant.Show();
        }

        private void convertisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            convertisseur convertisseur = new convertisseur();
            convertisseur.Show();
        }

        private void virementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void virementCCourantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form virementc = new virementcourant();
            virementc.Show();
        }

        private void virementCEpargneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form viremente = new virementepargne();
            viremente.Show();
        }
    }
}
