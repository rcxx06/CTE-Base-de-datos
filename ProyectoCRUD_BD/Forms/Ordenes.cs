using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using System.Data;

namespace ProyectoCRUD_BD.Forms
{
    public partial class Ordenes : Form
    {
        private static string connectionString =
            "Server=DESKTOP-GNLT0BG\\MSSQLSERVER01;Database=Centro_Tecnico_Electronico;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

        public Ordenes()
        {
            InitializeComponent();
            CargarOrdenes();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private void btnIngresoOrden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdenID.Text) || !int.TryParse(txtOrdenID.Text, out int ordenId))
            {
                MessageBox.Show("Debe ingresar un Número de Orden válido.");
                return;
            }

            if (!int.TryParse(txtDiagnosticoID.Text, out int diagnosticoId))
            {
                MessageBox.Show("Ingrese un ID de diagnóstico válido.");
                return;
            }

            if (!int.TryParse(txtTecnicoID.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Verificar si la orden ya existe
            var check = new SqlCommand("SELECT COUNT(*) FROM Ordenes WHERE orden_id = @id;", conn);
            check.Parameters.AddWithValue("@id", ordenId);

            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El Número de Orden ya existe. Ingrese otro.");
                return;
            }

            // Verificar que el diagnóstico existe
            var checkDiagnostico = new SqlCommand("SELECT COUNT(*) FROM Diagnosticos WHERE diagnostico_id = @diagId;", conn);
            checkDiagnostico.Parameters.AddWithValue("@diagId", diagnosticoId);
            int countDiag = (int)checkDiagnostico.ExecuteScalar();
            if (countDiag == 0)
            {
                MessageBox.Show("El ID de diagnóstico no existe.");
                return;
            }

            // Verificar que el técnico existe
            var checkTecnico = new SqlCommand("SELECT COUNT(*) FROM Tecnicos WHERE tecnico_id = @tecId;", conn);
            checkTecnico.Parameters.AddWithValue("@tecId", tecnicoId);
            int countTec = (int)checkTecnico.ExecuteScalar();
            if (countTec == 0)
            {
                MessageBox.Show("El ID de técnico no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Ordenes 
                (orden_id, diagnostico_id, tecnico_id, prioridad, estado, fecha_ingreso, tipo_equipo)
                VALUES
                (@id, @diag, @tec, @pri, @est, @fecha, @tipo);", conn);

            cmd.Parameters.AddWithValue("@id", ordenId);
            cmd.Parameters.AddWithValue("@diag", diagnosticoId);
            cmd.Parameters.AddWithValue("@tec", tecnicoId);
            cmd.Parameters.AddWithValue("@pri", txtPrioridad.Text ?? "");
            cmd.Parameters.AddWithValue("@est", txtEstado.Text ?? "");
            cmd.Parameters.AddWithValue("@fecha", dtpFechaIngreso.Value);
            cmd.Parameters.AddWithValue("@tipo", txtTipoElectronico.Text ?? "");

            cmd.ExecuteNonQuery();

            MessageBox.Show("Orden ingresada exitosamente.");
            CargarOrdenes();
            LimpiarCampos();
        }

        private void btnEliminarOrden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdenID.Text) || !int.TryParse(txtOrdenID.Text, out int ordenId))
            {
                MessageBox.Show("Ingrese un Número de Orden válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Ordenes WHERE orden_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", ordenId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Orden eliminada.");
            else
                MessageBox.Show("No existe una orden con ese Número.");

            CargarOrdenes();
            LimpiarCampos();
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdenID.Text) || !int.TryParse(txtOrdenID.Text, out int ordenId))
            {
                MessageBox.Show("Ingrese un Número de Orden válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Ordenes WHERE orden_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", ordenId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Orden eliminada.");
            else
                MessageBox.Show("No existe una orden con ese Número.");

            CargarOrdenes();
            LimpiarCampos();
        }

        private void btnActualizarOrden_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOrdenID.Text) || !int.TryParse(txtOrdenID.Text, out int ordenId))
            {
                MessageBox.Show("Ingrese un Número de Orden válido.");
                return;
            }

            if (!int.TryParse(txtDiagnosticoID.Text, out int diagnosticoId))
            {
                MessageBox.Show("Ingrese un ID de diagnóstico válido.");
                return;
            }

            if (!int.TryParse(txtTecnicoID.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Verificar que el diagnóstico existe
            var checkDiagnostico = new SqlCommand("SELECT COUNT(*) FROM Diagnosticos WHERE diagnostico_id = @diagId;", conn);
            checkDiagnostico.Parameters.AddWithValue("@diagId", diagnosticoId);
            int countDiag = (int)checkDiagnostico.ExecuteScalar();
            if (countDiag == 0)
            {
                MessageBox.Show("El ID de diagnóstico no existe.");
                return;
            }

            // Verificar que el técnico existe
            var checkTecnico = new SqlCommand("SELECT COUNT(*) FROM Tecnicos WHERE tecnico_id = @tecId;", conn);
            checkTecnico.Parameters.AddWithValue("@tecId", tecnicoId);
            int countTec = (int)checkTecnico.ExecuteScalar();
            if (countTec == 0)
            {
                MessageBox.Show("El ID de técnico no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                UPDATE Ordenes
                SET diagnostico_id = @diag,
                    tecnico_id = @tec,
                    prioridad = @pri,
                    estado = @est,
                    fecha_ingreso = @fecha,
                    tipo_equipo = @tipo
                WHERE orden_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", ordenId);
            cmd.Parameters.AddWithValue("@diag", diagnosticoId);
            cmd.Parameters.AddWithValue("@tec", tecnicoId);
            cmd.Parameters.AddWithValue("@pri", txtPrioridad.Text ?? "");
            cmd.Parameters.AddWithValue("@est", txtEstado.Text ?? "");
            cmd.Parameters.AddWithValue("@fecha", dtpFechaIngreso.Value);
            cmd.Parameters.AddWithValue("@tipo", txtTipoElectronico.Text ?? "");

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Orden actualizada.");
                CargarOrdenes();
            }
            else
            {
                MessageBox.Show("No se encontró la orden con ese Número.");
            }
        }

        private void btnMostrarOrdenes_Click(object sender, EventArgs e)
        {
            CargarOrdenes();

            LimpiarCampos();
        }

        private void CargarOrdenes()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Ordenes ORDER BY orden_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvOrdenes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar órdenes: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtOrdenID.Clear();
            txtDiagnosticoID.Clear();
            txtTecnicoID.Clear();
            txtPrioridad.Clear();
            txtEstado.Clear();
            txtTipoElectronico.Clear();
            dtpFechaIngreso.Value = DateTime.Now;
        }

        private void Ordenes_Load(object sender, EventArgs e)
        {
        }
    }
}
