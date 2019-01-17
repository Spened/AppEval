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
    public partial class DRH : Form
    {
        public DRH()
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
                cmbChoixOffre.Items.Add(offre.GetLibel);
            }
            nbCoefCritere.Value = 0;
            if(cmbChoixOffre.SelectedIndex < 0)
            {
                lstCriteres.Enabled = false;
                nbCoefCritere.Enabled = false;
                txtNomCritere.Enabled = false;
                btnAjouterCritere.Enabled = false;
            }
            grpAdd.Hide();
            if(lstCriteres.Items.Count == 0)
            {
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            if(cmbChoixOffre.Items.Count > 0)
            {
                cmbChoixOffre.SelectedIndex = 0;
            }
            
        }

        private void cmbChoixOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCriteres.Items.Clear();
            txtExpirationOffre.Clear();
            int idOffre = cmbChoixOffre.SelectedIndex + 1;
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            txtExpirationOffre.Text = pgsql.DateTimeOffre(idOffre).ToString();
            if (cmbChoixOffre.SelectedIndex >= 0)
            {
                lstCriteres.Enabled = true;
                nbCoefCritere.Enabled = true;
                txtNomCritere.Enabled = true;
                btnAjouterCritere.Enabled = true;
                foreach (ClassMetier.Critere critere in pgsql.GetCriteres(cmbChoixOffre.SelectedIndex + 1))
                {
                    lstCriteres.Items.Add(critere.GetLibel);
                }
            }
            else
            {
                lstCriteres.Enabled = false;
                nbCoefCritere.Enabled = false;
                txtNomCritere.Enabled = false;
                btnAjouterCritere.Enabled = false;
            }
            if (lstCriteres.Items.Count == 0)
            {
                btnModifier.Enabled = false;
                btnSupprimer.Enabled = false;
            }
            else
            {
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
            }
        }

        private void btnAjouterCritere_Click(object sender, EventArgs e)
        {
            if (btnAjouterCritere.Text == "Ajouter un critère")
            {
                //ADD Critere
                lstCriteres.Items.Clear();
                int idOffre = cmbChoixOffre.SelectedIndex + 1;
                ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
                pgsql.AjoutCritereSQL(idOffre, txtNomCritere.Text, (int)nbCoefCritere.Value);
                txtNomCritere.Clear();
                nbCoefCritere.Value = 0;
                foreach (ClassMetier.Critere critere in pgsql.GetCriteres(cmbChoixOffre.SelectedIndex + 1))
                {
                    lstCriteres.Items.Add(critere.GetLibel);
                }
                //Cacher les options pour ajouter
                grpAdd.Hide();
                //Verifier si des nouveaux critéres ADD
                if (lstCriteres.Items.Count == 0)
                {
                    btnModifier.Enabled = false;
                    btnSupprimer.Enabled = false;
                }
                else
                {
                    btnModifier.Enabled = true;
                    btnSupprimer.Enabled = true;
                }
            }
            else if (btnAjouterCritere.Text == "Modifier le critère")
            {
                int idOffre = cmbChoixOffre.SelectedIndex + 1;
                ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
                pgsql.ModifCritereSQL(idOffre, lstCriteres.Items[lstCriteres.SelectedIndex].ToString(), txtNomCritere.Text, (int)nbCoefCritere.Value);
                lstCriteres.Items.Clear();
                foreach (ClassMetier.Critere critere in pgsql.GetCriteres(cmbChoixOffre.SelectedIndex + 1))
                {
                    lstCriteres.Items.Add(critere.GetLibel);
                }
            }
               
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            grpAdd.Show();
            btnAjouterCritere.Text = "Ajouter un critère";
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int idOffre = cmbChoixOffre.SelectedIndex + 1;
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            pgsql.SuppCritereSQL(idOffre, lstCriteres.Items[lstCriteres.SelectedIndex].ToString());
            lstCriteres.Items.Clear();
            foreach (ClassMetier.Critere critere in pgsql.GetCriteres(cmbChoixOffre.SelectedIndex + 1))
            {
                lstCriteres.Items.Add(critere.GetLibel);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            grpAdd.Show();
            btnAjouterCritere.Text = "Modifier le critère";
        }
    }
}
