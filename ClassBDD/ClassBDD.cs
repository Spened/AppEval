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
        NpgsqlCommand MyCmd = new NpgsqlCommand();
        NpgsqlConnection MyCnx = new NpgsqlConnection("Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd;");

        public void AjoutCritereSQL(int unId, string unLibel, int unCoef)
        {
            MyCnx.Open();
            MyCmd.CommandText = "INSET INTO critere(idcritere, libellecritere, coefpond) VALUES("+unId+""+unLibel+","+unCoef+");";
            MyCmd.ExecuteNonQuery();
        }

        public List<ClassMetier.OffreEmplois> OffreEmplois()
        {
            DataTable table = new DataTable();
            DataRow row;
            row = table.NewRow();
            int cntOffres = 0;
            List<ClassMetier.OffreEmplois> lesOffresEmplois = new List<ClassMetier.OffreEmplois>();
            NpgsqlCommand MyCmd = new NpgsqlCommand("SELECT COUNT(*) FROM public.offre_d_emploi;", MyCnx);
            var nbOffres = MyCmd.ExecuteNonQuery();
            while (nbOffres > 1)
            {
                NpgsqlCommand MyCmd1 = new NpgsqlCommand("SELECT * FROM public.offre_d_emploi WHERE idoffre =" + cntOffres + ");", MyCnx);
                NpgsqlDataReader dr = MyCmd1.ExecuteReader();
                var id = int.Parse(dr[0].ToString());
                var date = DateTime.Parse(dr[2].ToString());
                ClassMetier.OffreEmplois offreEmploi = new ClassMetier.OffreEmplois(id, dr[1].ToString(), date);
                lesOffresEmplois.Add(offreEmploi);
                cntOffres++;
            }
            return lesOffresEmplois;
        }
    }
}
