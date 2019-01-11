﻿using System;
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

        public int getId { get { return this.id; } set { this.id = value; } }
        public string getLibel { get { return this.libel; } set { this.libel = value; } }
        public DateTime getDateFin { get {this.dateFin; } set {this.dateFin = value; } }
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
