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

        public static NpgsqlConnection conn()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=7777;Database=postgres;User Id=openpg;Password=openpgpwd");
            conn.Open();
            return conn;
        }

        public void AjoutCritereSQL(int unIdOffre, string unLibel, int unCoef)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO critere(idcritere, idoffre, libellecritere, coeffpond) VALUES( nextval('critere_idcritere_seq') , " + unIdOffre + ", '" + unLibel + "'," + unCoef + ");", conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }

        public void SuppCritereSQL(int unIdOffre, string unLibel)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("DELETE FROM critere WHERE idOffre = " + unIdOffre +" AND libellecritere = '"+ unLibel +"'", conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }

        public void ModifCritereSQL(int unIdOffre, string unLibel, string newLibel, int newCoef)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE critere SET libellecritere = '"+ newLibel + "', coeffpond = " + newCoef+"WHERE idOffre = " + unIdOffre + " AND libellecritere = '" + unLibel + "'", conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }

        /// <summary>
        /// 
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
        /// 
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

        public void InsertNote(int idOffre, int idCritere)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO public.noter(idoffre , idcritere, idevaluation, coeffpond) VALUES("+idOffre+","+idCritere, conn());
            cmd.ExecuteNonQuery();
            cmd.Cancel();
            conn().Close();
        }
    }
}
