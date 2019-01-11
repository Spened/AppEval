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

        public int GetId { get { return this.id; } set { this.id = value; } }
        public string GetLibel { get { return this.libel; } set { this.libel = value; } }
        public DateTime GetDateFin { get {return this.dateFin; } set {this.dateFin = value; } }
        public List<OffreEmplois> lesOffresEmplois()
        {
            List<OffreEmplois> offreEmplois = new List<OffreEmplois>();
            
            
            return offreEmplois;
        }
    }
}
