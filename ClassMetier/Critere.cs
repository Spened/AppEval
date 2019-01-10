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
    }
}
