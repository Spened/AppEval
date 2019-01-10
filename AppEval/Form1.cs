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
        ClassBDD.Connexion connexion = new ClassBDD.Connexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(connexion.ConnnexionBDD());
        }

        private void cmbChoixOffre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
