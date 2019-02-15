using System;
using System.Collections.Generic;

//On inclue la librairie
using Npgsql;
using NpgsqlTypes;
//Fin
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Text;


namespace ClassBDD
{
    public class PGSQL
    {
        /// <summary>
        /// Test de connexion à la base de données
        /// </summary>
        /// <returns></returns>
        public string TestConn()
        {
            string str = "";
            bool boolfound = false;

            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.offre_d_emploi", conn());
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                boolfound = true;
                str = "connection established";
            }
            if (boolfound == false)
            { 
                str = "Data does not exist";
            }
            dr.Close();
            return str;
        }

        /// <summary>
        /// Connextion BDD
        /// </summary>
        /// <returns></returns>
        public static NpgsqlConnection conn()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd");
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Ajout d'un critère dans la BDD
        /// </summary>
        /// <param name="unIdOffre"></param>
        /// <param name="unLibel"></param>
        /// <param name="unCoef"></param>
        public void AjoutCritereSQL(int unIdOffre, string unLibel, int unCoef)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO critere(idcritere, idoffre, libellecritere, coeffpond) VALUES( nextval('critere_idcritere_seq') , " + unIdOffre + ", '" + unLibel + "'," + unCoef + ");", conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }

        /// <summary>
        /// Suppression d'un critère dans la BDD
        /// </summary>
        /// <param name="unIdOffre"></param>
        /// <param name="unLibel"></param>
        public void SuppCritereSQL(int unIdOffre, string unLibel)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM critere WHERE idOffre = " + unIdOffre +" AND libellecritere = '"+ unLibel +"'", conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }

        /// <summary>
        /// Modifications d'un critère dans la BDD
        /// </summary>
        /// <param name="unIdOffre"></param>
        /// <param name="unLibel"></param>
        /// <param name="newLibel"></param>
        /// <param name="newCoef"></param>
        public void ModifCritereSQL(int unIdOffre, string unLibel, string newLibel, int newCoef)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE critere SET libellecritere = '"+ newLibel + "', coeffpond = " + newCoef+"WHERE idOffre = " + unIdOffre + " AND libellecritere = '" + unLibel + "'", conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }

        /// <summary>
        /// Obtention de l'ID d'un critère de la BDD
        /// </summary>
        /// <param name="idOffre"></param>
        /// <param name="unLibel"></param>
        /// <returns></returns>
        public int GetIdCritereSQL(int idOffre, string unLibel)
        {
            int id = 0;
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT idcritere FROM critere WHERE idOffre = " + idOffre + " AND libellecritere = '"+ unLibel +"'" , conn());
            NpgsqlDataReader dr = cmd.ExecuteReader();
            cmd.Cancel();
            conn().Close();
            while (dr.Read())
                id = int.Parse(dr[0].ToString());
            return id;
        }

        public void InsertEvaluation(int idOffre, int idCritere,  List<ClassMetier.Note> lesNotes,  string commentaire, decimal bonus)
        {
            int idEvaluation = 1;
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT currval('public.evaluation_idevaluation_seq')", conn());
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idEvaluation = int.Parse(dr[0].ToString());
                }
                conn().Close();
            }
            catch
            {
                idEvaluation = 1;
            }
            NpgsqlCommand command = new NpgsqlCommand("INSERT INTO public.evaluation(idevaluation, nomrh, prenomrh, commentaire, bonus) VALUES (nextval('public.evaluation_idevaluation_seq') , 'Marie' , 'Jean' , '" + commentaire + "'," + bonus.ToString() + ")", conn());
            command.ExecuteNonQuery();
            foreach(ClassMetier.Note note in lesNotes)
            {
                command.CommandText = "INSERT INTO public.noter(idoffre, idcritere, idevaluation, note) VALUES ("+idOffre + ", " + note.GetIdCritere + ", "+ idEvaluation +", " + note.GetNote + ")";
                command.ExecuteNonQuery();
                command.Cancel();
            }
            conn().Close();
        }

        public int GetIdEvaluation(string commentaire, decimal bonus)
        {
            int id = 0;
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT idevaluation FROM public.evaluation WHERE commentaire = '" + commentaire + "' AND bonus = " + bonus + ")", conn());
            NpgsqlDataReader dr = cmd.ExecuteReader();
            cmd.Cancel();
            conn().Close();
            while (dr.Read())
                id = int.Parse(dr[0].ToString());
            return id;
        }

        /// <summary>
        /// Compteur des critères dans la BDD
        /// </summary>
        /// <param name="idOffre"></param>
        /// <returns></returns>
        public int CountCritere(int idOffre)
        {
            int count = 0;
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(idcritere) FROM public.critere WHERE idoffre ="+idOffre, conn());
            try
            {
                count = (int)command.ExecuteScalar();
            }
            catch
            {
                count = 0;
            }
            command.Cancel();
            return count;
        }

        /// <summary>
        /// Retourne la date limite pour postuler à l'offre
        /// </summary>
        /// <param name="idOffre"></param>
        /// <returns></returns>
        public DateTime DateTimeOffre(int idOffre)
        {
            DateTime date = DateTime.Now;
            NpgsqlCommand command = new NpgsqlCommand("SELECT DATE(datelimiteeval) FROM public.offre_d_emploi WHERE idoffre ="+idOffre, conn());
            NpgsqlDataReader dr = command.ExecuteReader();
            while(dr.Read())
                date = DateTime.Parse(dr[0].ToString());
            command.Cancel();
            return date;
        }

        /// <summary>
        /// Recupère les offres d'emplois
        /// </summary>
        /// <returns></returns>
        public List<ClassMetier.OffreEmplois> GetOffreEmplois()
        {
            List<ClassMetier.OffreEmplois> lesOffresEmplois = new List<ClassMetier.OffreEmplois>();
            // Define a query
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.offre_d_emploi", conn());
            // Execute the query and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();
            // Output rows
            while (dr.Read())
            {
                int id = int.Parse(dr[0].ToString());
                DateTime date = DateTime.Parse(dr[2].ToString());
                ClassMetier.OffreEmplois newOffre = new ClassMetier.OffreEmplois(id, dr[1].ToString(), date);
                lesOffresEmplois.Add(newOffre);
            }
            conn().Close();
            command.Cancel();
            return lesOffresEmplois;
        }

        /// <summary>
        /// Compteur des offres d'emplois
        /// </summary>
        /// <returns></returns>
        public int CountOffres()
        {
            int count = 0;
            NpgsqlCommand command = new NpgsqlCommand("SELECT COUNT(*) FROM public.offre_d_emploi" , conn());
            try
            {
                count = (int)command.ExecuteScalar();
            }
            catch
            {
                count = 0;
            }
            command.Cancel();
            return count;
        }

        /// <summary>
        /// Retourne les critères d'une offre
        /// </summary>
        /// <param name="idOffre"></param>
        /// <returns></returns>
        public List<ClassMetier.Critere> GetCriteres(int idOffre)
        {
            List<ClassMetier.Critere> lesCriteres = new List<ClassMetier.Critere>();
            // Define a query
            NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.critere WHERE idoffre="+idOffre, conn());
            // Execute the query and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();
            // Output rows
            while (dr.Read())
            {
                int newIdOffre = int.Parse(dr[0].ToString());
                int newIdCritere = int.Parse(dr[1].ToString());
                int coef = int.Parse(dr[3].ToString());
                ClassMetier.Critere newCritere = new ClassMetier.Critere(newIdOffre, newIdCritere, dr[2].ToString(), coef);
                lesCriteres.Add(newCritere);
            }
            dr.Close();
            conn().Close();
            command.Cancel();
            return lesCriteres;
        }

        /// <summary>
        /// Insertion d'une note un critère
        /// </summary>
        /// <param name="idOffre"></param>
        /// <param name="idCritere"></param>
        public void InsertNote(int idOffre, int idCritere)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.noter(idoffre , idcritere, idevaluation, coeffpond) VALUES("+idOffre+","+idCritere, conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }

        /// <summary>
        /// Retourne les candidats pour une offre d'emploi
        /// </summary>
        /// <param name="idOffre"></param>
        /// <returns></returns>
        public List<ClassMetier.Candidature> getCandidatOffre(int idOffre)
        {
            List<ClassMetier.Candidature> lesCandidatures = new List<ClassMetier.Candidature>();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT candidature.idcandidature, offre_d_emploi.idoffre, candidature.nomcandidat, candidature.prenomcandidat, candidature.datecandidature, candidature.etat FROM candidature INNER JOIN offre_d_emploi ON candidature.idoffre = offre_d_emploi.idoffre WHERE offre_d_emploi.idoffre ="+idOffre, conn());
            NpgsqlDataReader dr = cmd.ExecuteReader();
            // Output rows
            while (dr.Read())
            {
                int idCandidat = int.Parse(dr[0].ToString());
                DateTime date = DateTime.Parse(dr[4].ToString());
                ClassMetier.Candidature candidature = new ClassMetier.Candidature(idOffre,idCandidat ,dr[2].ToString(), dr[3].ToString(),date, dr[5].ToString());
                lesCandidatures.Add(candidature);
            }
            cmd.Cancel();
            conn().Close();
            return lesCandidatures;
        }
    }
}
