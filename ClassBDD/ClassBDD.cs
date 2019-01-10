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

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM public.offre_d_emploi", conn);
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

        public void AjoutCritereSQL(int unId, string unLibel, int unCoef)
        {
            MyCnx.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("INSET INTO critere(idcritere, libellecritere, coefpond) VALUES(" +unId+""+unLibel+","+unCoef+");", MyCnx);
            cmd.ExecuteNonQuery();
        }

        public List<ClassMetier.OffreEmplois> OffreEmplois()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd"))
            {
                conn.Open();
                //Création d'un compteur pour parcourir tout les données
                int cntOffres = 0;
                //Création d'une liste d'offres
                List<ClassMetier.OffreEmplois> lesOffresEmplois = new List<ClassMetier.OffreEmplois>();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.offre_d_emploi", conn);
                var nbOffres = cmd.ExecuteNonQuery();
                while (nbOffres > 1)
                {
                    //Requête SQL + Connection BDD
                    NpgsqlCommand cmd1 = new NpgsqlCommand("SELECT * FROM public.offre_d_emploi WHERE idoffre =" + cntOffres + ");", conn);
                    //Stockage de la requête dans dr == row en php
                    NpgsqlDataReader dr = cmd1.ExecuteReader();
                    //Stockage de la valeur ID
                    var id = int.Parse(dr[0].ToString());
                    //Stockage de la valeur date
                    var date = DateTime.Parse(dr[2].ToString());
                    //Création d'un objet OffreEmplois + ajout de valeur
                    ClassMetier.OffreEmplois offreEmploi = new ClassMetier.OffreEmplois(id, dr[1].ToString(), date);
                    //Ajout à la liste lesOffresEmplois
                    lesOffresEmplois.Add(offreEmploi);
                    //Incrémentation du compteur
                    cntOffres++;
                    dr.Close();
                }
                //Retourne la liste lesOffresEmplois
                return lesOffresEmplois;
            }
        }
        /*
            //Création d'un compteur pour parcourir tout les données
            int cntOffres = 0;
            //Création d'une liste d'offres
            List<ClassMetier.OffreEmplois> lesOffresEmplois = new List<ClassMetier.OffreEmplois>();
            //Requête SQL + Connection BDD
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.offre_d_emploi;", );
            //Execution de la requête avec stockage du nombre de ligne retourner
            var nbOffres = cmd.ExecuteNonQuery();
            //Parcours de toutes les offres
            while (nbOffres > 1)
            {
                //Requête SQL + Connection BDD
                NpgsqlCommand cmd1 = new NpgsqlCommand("SELECT * FROM public.offre_d_emploi WHERE idoffre =" + cntOffres + ");", MyCnx);
                //Stockage de la requête dans dr == row en php
                NpgsqlDataReader dr = cmd1.ExecuteReader();
                //Stockage de la valeur ID
                var id = int.Parse(dr[0].ToString());
                //Stockage de la valeur date
                var date = DateTime.Parse(dr[2].ToString());
                //Création d'un objet OffreEmplois + ajout de valeur
                ClassMetier.OffreEmplois offreEmploi = new ClassMetier.OffreEmplois(id, dr[1].ToString(), date);
                //Ajout à la liste lesOffresEmplois
                lesOffresEmplois.Add(offreEmploi);
                //Incrémentation du compteur
                cntOffres ++;
            }
            //Retourne la liste lesOffresEmplois
            return lesOffresEmplois;
            */
    }
}
