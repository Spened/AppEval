using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class OffreEmplois
    {
        private int id;
        private string libel;
        private DateTime dateFin;

        public OffreEmplois(int unId, string unlibel, DateTime uneDateFin)
        {
            this.id = unId;
            this.libel = unlibel;
            this.dateFin = uneDateFin;
        }

        public int getId { get; set; }
        public string getLibel { get; set; }
        public DateTime getDateFin { get; set; }
        /*
        public List<OffreEmplois> lesOffresEmplois()
        {
            List<OffreEmplois> offreEmplois = new List<OffreEmplois>();
            ClassBDD.PGSQL pgsql = new ClassBDD.PGSQL();
            
            return offreEmplois;
        }
        */
    }
}
