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
    public class Connexion
    {
        string Conx = "Server=localhost;Port=6666;Database=postgres;User Id=openpg;Password=;";
        NpgsqlCommand MyCmd = null;
        NpgsqlConnection MyCnx = null;

        public string ConnnexionBDD()
        {
            MyCnx = new NpgsqlConnection(Conx);
            MyCnx.Open();
            if(MyCnx.State == System.Data.ConnectionState.Open)
            {
                return "Connexion BDD Réussite !";
            }
            else
            {
                return "Connexion BDD Échoué !";
            }
        }        
    }
}
