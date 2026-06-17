using System;
using System.Data;
using System.Data.SQLite;

namespace Caubert_Stroher_KlausnitzerSae24
{
    /// <summary>
    /// Central data access layer. Loads all database tables into a shared DataSet
    /// that can be used across the application's UserControls.
    /// </summary>
    public class MesDatas
    {
        private static readonly DataSet _globalDataSet = new DataSet();

        public static DataSet DsGlobal => _globalDataSet;

        /// <summary>
        /// Initializes the global DataSet by loading all tables from the SQLite database.
        /// Should be called once during the main form's Load event.
        /// </summary>
        public static void initDs()
        {
            string[] tables = {
                "Admin", "Affectation", "Caserne", "Embarquer", "Engin",
                "Grade", "Habilitation", "Mission", "Mobiliser", "NatureSinistre",
                "Necessiter", "PartirAvec", "Passer", "Pompier", "TypeEngin",
                "sqlite_sequence"
            };

            _globalDataSet.Tables.Clear();

            foreach (string table in tables)
            {
                try
                {
                    string query = $"SELECT * FROM {table}";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, Connexion.Connec);
                    DataTable dt = new DataTable(table);
                    adapter.Fill(dt);
                    _globalDataSet.Tables.Add(dt);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading table '{table}': {ex.Message}");
                }
            }
        }
    }
}
