using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using ProyectoCRUD_BD.BDSQL;
using System.Data;
using System.Data.SQLite;

namespace ProyectoCRUD_BD
{
    public partial class IngresoCLientes : Form
    {
        public IngresoCLientes()
        {
            InitializeComponent();
            CargarClientes();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnIngresoClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_Cliente.Text))
            {
                UIStyles.ShowAlert("Debe ingresar un ID para el cliente.");
                return;
            }

            if (!int.TryParse(Id_Cliente.Text, out int clienteId))
            {
                UIStyles.ShowAlert("El ID debe ser un número válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar si ya existe el ID
            var check = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE cliente_id = @id;", conn);
            check.Parameters.AddWithValue("@id", clienteId);

            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                UIStyles.ShowAlert("El ID ingresado ya existe. Ingrese otro ID.");
                return;
            }

            // Insertar cliente
            var cmd = new SqlCommand(@"
                INSERT INTO Clientes 
                (cliente_id, nombre, telefono, direccion, correo, contacto_secundario)
                VALUES
                (@id, @n, @t, @d, @c, @cs);", conn);

            cmd.Parameters.AddWithValue("@id", clienteId);
            cmd.Parameters.AddWithValue("@n", Nombre_Cliente.Text ?? "");
            cmd.Parameters.AddWithValue("@t", TelefonoBox.Text ?? "");
            cmd.Parameters.AddWithValue("@d", DireccionBox.Text ?? "");
            cmd.Parameters.AddWithValue("@c", CorreoBox.Text ?? "");
            cmd.Parameters.AddWithValue("@cs", Contacto2.Text ?? "");

            cmd.ExecuteNonQuery();

            UIStyles.ShowAlert("Cliente agregado exitosamente.");
            CargarClientes();
            LimpiarCampos();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_Cliente.Text) || !int.TryParse(Id_Cliente.Text, out int clienteId))
            {
                UIStyles.ShowAlert("Ingrese un ID válido para eliminar.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Clientes WHERE cliente_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", clienteId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                UIStyles.ShowAlert("Cliente eliminado.");
            else
                UIStyles.ShowAlert("No existe un cliente con ese ID.");

            CargarClientes();
            LimpiarCampos();
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Id_Cliente.Text) || !int.TryParse(Id_Cliente.Text, out int clienteId))
            {
                UIStyles.ShowAlert("Ingrese un ID válido para buscar.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Clientes WHERE cliente_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", clienteId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            MostrarClientes.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                // Llenar los TextBox con los datos
                Nombre_Cliente.Text = dt.Rows[0]["nombre"].ToString();
                TelefonoBox.Text = dt.Rows[0]["telefono"].ToString();
                DireccionBox.Text = dt.Rows[0]["direccion"].ToString();
                CorreoBox.Text = dt.Rows[0]["correo"].ToString();
                Contacto2.Text = dt.Rows[0]["contacto_secundario"].ToString();
            }
            else
            {
                UIStyles.ShowAlert("Cliente no encontrado.");
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Id_Cliente.Text, out int clienteId))
            {
                UIStyles.ShowAlert("Ingrese un ID válido.");
                return;
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                string query = @"UPDATE Clientes 
                         SET nombre = @nombre, 
                             telefono = @telefono, 
                             direccion = @direccion, 
                             correo = @correo, 
                             contacto_secundario = @contactoSecundario
                         WHERE cliente_id = @id;";

                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    cmd.Parameters.AddWithValue("@nombre", Nombre_Cliente.Text ?? "");
                    cmd.Parameters.AddWithValue("@telefono", TelefonoBox.Text ?? "");
                    cmd.Parameters.AddWithValue("@direccion", DireccionBox.Text ?? "");
                    cmd.Parameters.AddWithValue("@correo", CorreoBox.Text ?? "");
                    cmd.Parameters.AddWithValue("@contactoSecundario", Contacto2.Text ?? "");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        UIStyles.ShowAlert("Datos actualizados correctamente.");
                        btnBuscarClientes_Click(null, null);
                    }
                    else
                    {
                        UIStyles.ShowAlert("No se encontró el cliente con ese ID.");
                    }
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarClientes();
            LimpiarCampos();
        }

        private void CargarClientes()
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Clientes";

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            MostrarClientes.DataSource = dt;
        }

        private void IngresoCLientes_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            Id_Cliente.Clear();
            Nombre_Cliente.Clear();
            TelefonoBox.Clear();
            DireccionBox.Clear();
            CorreoBox.Clear();
            Contacto2.Clear();
        }
    }
}
