using Microsoft.Data.SqlClient;

namespace ProyectoCRUD_BD.BDSQL
{
    public static class SQLCONECTION
    {
        private static string connectionString =
            "Server=localhost;Database=BDAsistenciaTecnica;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        // METODO PARA USAR EN TODAS LAS TABS
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
