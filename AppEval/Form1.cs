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
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            foreach (ClassMetier.OffreEmplois offre in pgsql.GetOffreEmplois())
            {
                cmbChoixOffre.Items.Add(offre.getLibel);
            }
            nbCoefCritere.Value = 0;
            nbIdCritere.Value = 1;
            if(cmbChoixOffre.SelectedIndex < 0)
            {
                lstCriteres.Enabled = false;
                nbCoefCritere.Enabled = false;
                nbIdCritere.Enabled = false;
                txtNomCritere.Enabled = false;
                btnAjouterCritere.Enabled = false;
            }
        }

        private void cmbChoixOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbChoixOffre.SelectedIndex >= 0)
            {
                lstCriteres.Enabled = true;
                nbCoefCritere.Enabled = true;
                nbIdCritere.Enabled = true;
                txtNomCritere.Enabled = true;
                btnAjouterCritere.Enabled = true;
            }
            else
            {
                lstCriteres.Enabled = false;
                nbCoefCritere.Enabled = false;
                nbIdCritere.Enabled = false;
                txtNomCritere.Enabled = false;
                btnAjouterCritere.Enabled = false;
            }
        }

        private void btnAjouterCritere_Click(object sender, EventArgs e)
        {
            int idOffre = cmbChoixOffre.SelectedIndex + 1;
            ClassBDD.PGSQL critere = new ClassBDD.PGSQL();
            critere.AjoutCritereSQL(idOffre, (int)nbIdCritere.Value, txtNomCritere.Text, (int)nbCoefCritere.Value);
            txtNomCritere.Clear();
            nbCoefCritere.Value = 0;
            nbIdCritere.Value = 1;
        }
    }
}
