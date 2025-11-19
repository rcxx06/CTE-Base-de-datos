using System;
using Microsoft.Data.Sqlite;
using System.Data.SqlClient;

namespace ProyectoCRUD_BD
{
    public static class Inicializador
    {
        // Ruta de tu base de datos
        private static readonly string dbPath = @"C:\Users\Usuario\Documents\ProyectoCRUD_BD\ProyectoCRUD_BD\bin\Debug\net10.0-windows\CTE.db";

        // Cadena de conexión
        private static readonly string connectionString = $"Data Source={dbPath}";

        // Método para obtener la conexión abierta
        public static SqliteConnection GetConnection()
        {
            try
            {
                var connection = new SqliteConnection(connectionString);
                connection.Open();
                Console.WriteLine("Conexión a la base de datos establecida correctamente.");
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
                throw;
            }
        }

        // Método de prueba para ejecutar consultas simples
        public static void EjecutarConsulta(string query)
        {
            using var connection = GetConnection();
            using var command = new SqliteCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
