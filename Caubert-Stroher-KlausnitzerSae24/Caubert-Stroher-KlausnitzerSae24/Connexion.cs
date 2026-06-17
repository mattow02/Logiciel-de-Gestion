using System;
using System.Data.SQLite;

namespace Caubert_Stroher_KlausnitzerSae24
{
    /// <summary>
    /// Singleton database connection manager for SQLite.
    /// Ensures only one connection instance exists throughout the application lifetime.
    /// </summary>
    internal class Connexion
    {
        private static SQLiteConnection _connection;
        private static readonly string ConnectionString = @"Data Source = SDIS67.db";

        private Connexion() { }

        /// <summary>
        /// Gets the singleton SQLite connection, opening it if necessary.
        /// </summary>
        public static SQLiteConnection Connec
        {
            get
            {
                if (_connection == null || _connection.State != System.Data.ConnectionState.Open)
                {
                    try
                    {
                        _connection?.Dispose();
                        _connection = new SQLiteConnection(ConnectionString);
                        _connection.Open();
                    }
                    catch (SQLiteException ex)
                    {
                        Console.WriteLine($"Error opening database connection: {ex.Message}");
                        throw;
                    }
                }
                return _connection;
            }
        }

        /// <summary>
        /// Closes and disposes the database connection cleanly.
        /// </summary>
        public static void CloseConnection()
        {
            if (_connection != null)
            {
                try
                {
                    _connection.Close();
                    _connection.Dispose();
                    _connection = null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error closing database connection: {ex.Message}");
                }
            }
        }
    }
}
