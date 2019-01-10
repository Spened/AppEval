using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            InitializeComponent();
            MessageBox.Show(pgsql.TestConn());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassBDD.PGSQL offreEmplois = new ClassBDD.PGSQL();
            foreach (ClassMetier.OffreEmplois offres in offreEmplois.OffreEmplois())
            {
                cmbChoixOffre.Items.Add(offres.getLibel);
            }
        }

        private void cmbChoixOffre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterCritere_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbChoixOffre.SelectedIndex.ToString());
            int coef = int.Parse(txtCoeffCritere.ToString());
            int id = int.Parse(txtIdCritere.ToString());
            ClassBDD.PGSQL critere = new ClassBDD.PGSQL();
            critere.AjoutCritereSQL(id, txtNomCritere.ToString(), coef);
        }
    }
}
