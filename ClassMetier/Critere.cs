using System;

namespace ClassMetier
{
    public class Critere
    {
        private int idOffre;
        private int idCritere;
        private string libel;
        private int coef;

        public Critere(int unIdOffre, int unIdCritere, string unLibel, int unCoef)
        {
            this.idOffre = unIdOffre;
            this.idCritere = unIdCritere;
            this.libel = unLibel;
            this.coef = unCoef;
        }

        public int GetIdOffre { get { return this.idOffre; } set { this.idOffre = value; } }
        public int GetIdCritere { get { return this.idCritere; } set { this.idCritere = value; } }
        public string GetLibel { get { return this.libel; } set { this.libel = value; } }
        public int GetCoef { get { return this.coef; } set { this.coef = value; } }
    }
}
