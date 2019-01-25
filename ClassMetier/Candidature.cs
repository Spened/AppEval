using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetier
{
    public class Candidature
    {
        private int idOffre;
        private int idCandidature;
        private string nomCandidat;
        private string prenomCandidat;
        private DateTime dateCandidature;
        private string etatCandidature;

        public Candidature (int unIdOffre, int unIdCandidature, string unNomCandidat, string unPrenomCandidat, DateTime uneDateCandidature, string unEtatCandidature)
        {
            this.idOffre = unIdOffre;
            this.idCandidature = unIdCandidature;
            this.nomCandidat = unNomCandidat;
            this.prenomCandidat = unPrenomCandidat;
            this.dateCandidature = uneDateCandidature;
            this.etatCandidature = unEtatCandidature;
        }

        public int GetIdOffre { get { return this.idOffre; } set { this.idOffre = value; } }
        public int GetIdCandidature { get { return this.idCandidature; } set { this.idCandidature = value; } }
        public string GetNomCandidat { get { return this.nomCandidat; } set { this.nomCandidat = value; } }
        public string GetPrenomCandidat { get { return this.prenomCandidat; } set { this.prenomCandidat = value; } }
        public DateTime GetDateCandidature { get { return this.dateCandidature; } set { this.dateCandidature = value; } }
        public string GetEtatCandidature { get { return this.etatCandidature; } set { this.etatCandidature = value; } }
    }
}
