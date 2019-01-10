using System;
using System.Collections.Generic;

//On inclue la librairie
using Npgsql;
using NpgsqlTypes;
//Fin
using System.Linq;
using System.Data;
using System.Text;


namespace ClassBDD
{
    public class PGSQL
    {
        string Conx = "Server=localhost;Port=6666;Database=postgres;User Id=louis;Password=passwd;";
        NpgsqlCommand MyCmd = null;
        NpgsqlConnection MyCnx = null;

        public void AjoutCritereSQL(int unId, string unLibel, int unCoef)
        {
            var conn = new NpgsqlConnection(Conx);
            conn.Open();
            MyCmd.Connection = conn;
            MyCmd.CommandText = "INSET INTO critere(idcritere, libellecritere, coefpond) VALUES("+unId+""+unLibel+","+unCoef+");";
            MyCmd.ExecuteNonQuery();
        }
    }
}
