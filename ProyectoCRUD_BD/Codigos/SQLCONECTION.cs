using Microsoft.Data.SqlClient;

namespace ProyectoCRUD_BD.BDSQL
{
    public static class SQLCONECTION
    {
        private static string connectionString =
    "Server=DESKTOP-GNLT0BG\\MSSQLSERVER01;Database=Centro_Tecnico_Electronico;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        // METODO PARA USAR EN TODAS LAS TABS
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
