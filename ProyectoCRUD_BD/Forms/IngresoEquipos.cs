using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using ProyectoCRUD_BD.BDSQL;
using System.Data;

namespace ProyectoCRUD_BD
{
    public partial class IngresoEquipos : Form
    {
  
        public IngresoEquipos()
        {
            InitializeComponent();
            CargarEquipos();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnIngresarEquipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipoID.Text) || !int.TryParse(txtEquipoID.Text, out int equipoId))
            {
                MessageBox.Show("Debe ingresar un ID válido para el equipo.");
                return;
            }

            if (!int.TryParse(txtId_cliente.Text, out int clienteId))
            {
                MessageBox.Show("Debe ingresar un ID de cliente válido.");
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                // Verificar existencia del ID
                SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Equipo WHERE equipo_id = @id", conn);
                check.Parameters.AddWithValue("@id", equipoId);
                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("El ID ingresado ya existe.");
                    return;
                }

                // Verificar que el cliente existe
                SqlCommand checkCliente = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE cliente_id = @clienteId", conn);
                checkCliente.Parameters.AddWithValue("@clienteId", clienteId);
                int clienteCount = (int)checkCliente.ExecuteScalar();

                if (clienteCount == 0)
                {
                    MessageBox.Show("El ID de cliente no existe.");
                    return;
                }

                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Equipo (equipo_id, cliente_id, marca, numero_serie, modelo, tipo)
                    VALUES (@id, @cliente, @marca, @serial, @modelo, @tipo)
                ", conn);

                cmd.Parameters.AddWithValue("@id", equipoId);
                cmd.Parameters.AddWithValue("@cliente", clienteId);
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text ?? "");
                cmd.Parameters.AddWithValue("@serial", txtSerialNumber.Text ?? "");
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text ?? "");
                cmd.Parameters.AddWithValue("@tipo", txtTipoEquipo.Text ?? "");

                cmd.ExecuteNonQuery();

                MessageBox.Show("Equipo agregado exitosamente.");
                CargarEquipos();
                LimpiarCampos();
            }
        }

        private void btnEliminarEquipos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipoID.Text) || !int.TryParse(txtEquipoID.Text, out int equipoId))
            {
                MessageBox.Show("Ingrese un ID válido para eliminar.");
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Equipo WHERE equipo_id = @id", conn);
                cmd.Parameters.AddWithValue("@id", equipoId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Equipo eliminado correctamente.");
                    CargarEquipos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró un equipo con ese ID.");
                }
            }
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipoID.Text) || !int.TryParse(txtEquipoID.Text, out int equipoId))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Equipo WHERE equipo_id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", equipoId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MostrarEquipos.DataSource = dt;

                    txtId_cliente.Text = dt.Rows[0]["cliente_id"].ToString();
                    txtMarca.Text = dt.Rows[0]["marca"].ToString();
                    txtSerialNumber.Text = dt.Rows[0]["numero_serie"].ToString();
                    txtModelo.Text = dt.Rows[0]["modelo"].ToString();
                    txtTipoEquipo.Text = dt.Rows[0]["tipo"].ToString();
                }
                else
                {
                    MessageBox.Show("Equipo no encontrado.");
                    MostrarEquipos.DataSource = null;
                    LimpiarCampos();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipoID.Text) || !int.TryParse(txtEquipoID.Text, out int equipoId))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Equipo WHERE equipo_id = @id;", conn);
                cmd.Parameters.AddWithValue("@id", equipoId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MostrarEquipos.DataSource = dt;

                    txtId_cliente.Text = dt.Rows[0]["cliente_id"].ToString();
                    txtMarca.Text = dt.Rows[0]["marca"].ToString();
                    txtSerialNumber.Text = dt.Rows[0]["numero_serie"].ToString();
                    txtModelo.Text = dt.Rows[0]["modelo"].ToString();
                    txtTipoEquipo.Text = dt.Rows[0]["tipo"].ToString();
                }
                else
                {
                    MessageBox.Show("Equipo no encontrado.");
                    MostrarEquipos.DataSource = null;
                    LimpiarCampos();
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarEquipos();
            LimpiarCampos();
        }

        public void CargarEquipos()
        {

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Equipo ORDER BY equipo_id", conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    MostrarEquipos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos: {ex.Message}");
            }

        }

        public void LimpiarCampos()
        {
            txtEquipoID.Clear();
            txtId_cliente.Clear();
            txtMarca.Clear();
            txtSerialNumber.Clear();
            txtModelo.Clear();
            txtTipoEquipo.Clear();

        }

        private void IngresoEquipos_Load(object sender, EventArgs e)
        {

        }
    }
}
