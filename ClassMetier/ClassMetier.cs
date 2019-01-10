using System;

namespace ClassMetier
{
    public class Critere
    {
        private int id;
        private string libel;
        private int coef;

        public void critere(int unId, string unLibel, int unCoef)
        {
            this.id = unId;
            this.libel = unLibel;
            this.coef = unCoef;
        }
    }
}
