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
    public partial class RH : Form
    {
        public RH()
        {
            InitializeComponent();
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            grpEval.Hide();
            foreach (ClassMetier.OffreEmplois offre in pgsql.GetOffreEmplois())
            {
                lstOffreEmplois.Items.Add(offre.GetLibel);
            }

            
            lstOffreEmplois.SelectedIndex = 0;
        }

        public List<ClassMetier.Critere> lesCriteres()
        {
            int idOffre;
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            idOffre = lstOffreEmplois.SelectedIndex + 1;
            List<ClassMetier.Critere> lesCriteres = new List<ClassMetier.Critere>();
            foreach (ClassMetier.Critere c in pgsql.GetCriteres(idOffre))
            {
                lesCriteres.Add(c);
            }
            return lesCriteres;
        }

        private void lstOffreEmplois_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idOffre;
            lstCritere.Items.Clear();
            idOffre = lstOffreEmplois.SelectedIndex + 1;
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            foreach (ClassMetier.Critere c in pgsql.GetCriteres(idOffre))
            {
                lstCritere.Items.Add(c.GetLibel);
            }
            if(pgsql.CountCritere(idOffre) > 0)
            {
                lstCritere.SelectedIndex = 0;
            }
            else
            {
                grpEval.Hide();
            }
        }

        private void lstCritere_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNomCritere.Text = "";
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            int idCritere;
            int idOffre;
            idCritere = lstCritere.SelectedIndex + 1;
            idOffre = lstOffreEmplois.SelectedIndex + 1;
            if (lstCritere.Items.Count > 0)
            {
                grpEval.Show();
                foreach(ClassMetier.Critere c in lesCriteres())
                {
                    if (c.GetIdOffre == idOffre && c.GetLibel == lstCritere.Text)
                    {
                        txtNomCritere.Text = c.GetLibel;
                    }
                }
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();

        }
    }
}
