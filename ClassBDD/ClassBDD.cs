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
        NpgsqlConnection MyCnx = new NpgsqlConnection("Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd");
        public string TestConn()
        {
            string str = "";
            bool boolfound = false;
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd"))
            {
                conn.Open();

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
        }

        public NpgsqlConnection conn()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd");
            return conn;
        }

        public void AjoutCritereSQL(int unIdOffre, int unIdCritere, string unLibel, int unCoef)
        {
            conn().Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO critere(idoffre, idcritere, libellecritere, coeffpond) VALUES(" + unIdOffre + "," + unIdCritere + ", '" + unLibel + "'," + unCoef + ");", conn());
            cmd.ExecuteNonQuery();
            conn().Close();
        }

        public List<ClassMetier.OffreEmplois> GetOffreEmplois()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd"))
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                List<ClassMetier.OffreEmplois> lesOffresEmplois = new List<ClassMetier.OffreEmplois>();
                conn.Open();
                // Define a query
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM public.offre_d_emploi", conn);
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
                conn.Close();
                return lesOffresEmplois;
            }
        }
    }
}
