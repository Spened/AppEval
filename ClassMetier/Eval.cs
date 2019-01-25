using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class Eval
    {
        private int idEval;
        private string nomRh;
        private string prenomRh;
        private string commentaire;
        private int bonus;

        public Eval(int unIdEval, string unNomRh, string unPrenomRh, string unCommentaire, int unBonus)
        {
            this.idEval = unIdEval;
            this.nomRh = unNomRh;
            this.prenomRh = unPrenomRh;
            this.commentaire = unCommentaire;
            this.bonus = unBonus;
        }

        public int GetIdEval { get { return this.idEval; } set { this.idEval = value; } }
        public string GetNomRh { get { return this.nomRh; } set { this.nomRh = value; } }
        public string GetPrenomRh { get { return this.prenomRh; } set { this.prenomRh = value; } }
        public string GetCommentaire { get { return this.commentaire; } set { this.commentaire = value; } }
        public int GetBonus {  get { return this.bonus; } set { this.bonus = value; } }

    }
}
