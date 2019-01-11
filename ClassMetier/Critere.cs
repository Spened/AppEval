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

        public int getIdOffre()
        {
            return this.idOffre;
        }

        public int setIdOffre()
        {
            this.idOffre = unIdOffre;
        }

        public int getIdCritere()
        {
            return this.idCritere;
        }

        public int setIdCritere()
        {
            this.idCritere = unIdCritere;
        }

        public string getLibel()
        {
            return this.libel;
        }

        public int setLibel()
        {
            this.libel = unLibel;
        }
        
        public int getCoef()
        {
            return this.coef;
        }

        public int setCoef()
        {
            this.coef = unCoef;
        }
    }
}
