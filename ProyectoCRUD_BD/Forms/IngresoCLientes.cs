using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.SQLite;

namespace ProyectoCRUD_BD
{
    public partial class IngresoCLientes : Form
    {
        string dbPath = @"C:\Users\Usuario\Documents\ProyectoCRUD_BD\ProyectoCRUD_BD\bin\Debug\net10.0-windows\CTE.db";

        public IngresoCLientes()
        {
            InitializeComponent();
            CargarClientes();
            UIStyles.ApplyAllStyles(this);

        }


        private SqliteConnection GetConnection()
        {
            return new SqliteConnection($"Data Source={dbPath}");
        }


        private void btnIngresoClientes_Click(object sender, EventArgs e)
        {
            if (Id_Cliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un ID para el cliente.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar si ya existe el ID
            var check = conn.CreateCommand();
            check.CommandText = "SELECT COUNT(*) FROM Clientes WHERE cliente_id = @id;";
            check.Parameters.AddWithValue("@id", Id_Cliente.Text);

            long count = (long)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID ingresado ya existe. Ingrese otro ID.");
                return;
            }

            // Insertar cliente
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Clientes 
                (cliente_id, nombre, telefono, direccion, correo, contacto_secundario)
                VALUES
                (@id, @n, @t, @d, @c, @cs);
            ";

            cmd.Parameters.AddWithValue("@id", Id_Cliente.Text);
            cmd.Parameters.AddWithValue("@n", Nombre_Cliente.Text);
            cmd.Parameters.AddWithValue("@t", TelefonoBox.Text);
            cmd.Parameters.AddWithValue("@d", DireccionBox.Text);
            cmd.Parameters.AddWithValue("@c", CorreoBox.Text);
            cmd.Parameters.AddWithValue("@cs", Contacto2.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Cliente agregado exitosamente.");
            CargarClientes();
        }



        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Clientes WHERE cliente_id = @id;";
            cmd.Parameters.AddWithValue("@id", Id_Cliente.Text);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Cliente eliminado.");
            else
                MessageBox.Show("No existe un cliente con ese ID.");

            CargarClientes();
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Clientes WHERE cliente_id = @id;";
            cmd.Parameters.AddWithValue("@id", Id_Cliente.Text);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader); // Carga solo el cliente buscado
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
                MessageBox.Show("Cliente no encontrado.");
            }
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Id_Cliente.Text, out int clienteId))
            {
                MessageBox.Show("Ingrese un ID válido.");
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

                using (var cmd = new SqliteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    cmd.Parameters.AddWithValue("@nombre", Nombre_Cliente.Text);
                    cmd.Parameters.AddWithValue("@telefono", TelefonoBox.Text);
                    cmd.Parameters.AddWithValue("@direccion", DireccionBox.Text);
                    cmd.Parameters.AddWithValue("@correo", CorreoBox.Text);
                    cmd.Parameters.AddWithValue("@contactoSecundario", Contacto2.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.");
                        // Refresca la tabla mostrando solo el cliente actualizado
                        btnBuscarClientes_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con ese ID.");
                    }
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarClientes(); // Carga todos los clientes en el DataGridView

            // Limpiar campos de búsqueda si quieres
            Id_Cliente.Clear();
            Nombre_Cliente.Clear();
            TelefonoBox.Clear();
            DireccionBox.Clear();
            CorreoBox.Clear();
            Contacto2.Clear();
        }

        private void CargarClientes()
        {

            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Clientes";

            using var reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);  // ← Esto reemplaza completamente al DataAdapter

            MostrarClientes.DataSource = dt;
        }

        private void IngresoCLientes_Load(object sender, EventArgs e)
        {

        }
    }
}


