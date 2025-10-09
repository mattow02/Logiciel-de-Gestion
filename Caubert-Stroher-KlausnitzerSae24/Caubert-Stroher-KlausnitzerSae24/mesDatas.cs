using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Caubert_Stroher_KlausnitzerSae24;

namespace Caubert_Stroher_KlausnitzerSae24
{
    public class MesDatas
    {
        private static DataSet dsGlobal = new DataSet();
     
        public static DataSet DsGlobal { get {  return MesDatas.dsGlobal; } }

        public static void initDs() //initialisation du DataSet dsGlobal (a utiliser lors du FormLoad du Form de base)
        {
            string[] tables = { "Admin", "Affectation", "Caserne", "Embarquer", "Engin", "Grade", "Habilitation", "Mission", "Mobiliser", "NatureSinistre", "Necessiter", "PartirAvec", "Passer", "Pompier", "TypeEngin", "sqlite_sequence" };

            dsGlobal.Tables.Clear();

            foreach(string table in tables)
            {
                string qry = "select * from " + table;
                SQLiteDataAdapter da = new SQLiteDataAdapter(qry, Connexion.Connec);
                DataTable dt = new DataTable(table);
                da.Fill(dt);
                dsGlobal.Tables.Add(dt);
            }
        }
    }
}
