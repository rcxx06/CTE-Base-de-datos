using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using ProyectoCRUD_BD.BDSQL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD_BD.Forms
{
    public partial class Diagnosticos : Form
    {
        public Diagnosticos()
        {
            InitializeComponent();
            CargarDiagnosticos();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        // ===================== CARGAR TODOS =====================
        private void CargarDiagnosticos()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Diagnosticos ORDER BY diagnostico_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                MostrarDiagnosticos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar diagnósticos: {ex.Message}");
            }
        }

        // ===================== INGRESAR =====================
        private void btnIngresarD_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdDiagnostico.Text, out int diagnosticoId))
            {
                MessageBox.Show("Ingrese un ID de diagnóstico válido.");
                return;
            }

            if (!int.TryParse(txtIdTecnico.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            if (!int.TryParse(txtIDequipo.Text, out int equipoId))
            {
                MessageBox.Show("Ingrese un ID de equipo válido.");
                return;
            }

            // Combinar fecha y hora
            if (!DateTime.TryParse(txtFecha.Text + " " + txtHora.Text, out DateTime fechaHora))
            {
                MessageBox.Show("Fecha u hora no válida.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Diagnosticos WHERE diagnostico_id = @id;", conn);
            check.Parameters.AddWithValue("@id", diagnosticoId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID ya existe. Ingrese otro.");
                return;
            }

            // Validar que técnico existe
            var checkTecnico = new SqlCommand("SELECT COUNT(*) FROM Tecnicos WHERE tecnico_id = @tecId;", conn);
            checkTecnico.Parameters.AddWithValue("@tecId", tecnicoId);
            int countTecnico = (int)checkTecnico.ExecuteScalar();
            if (countTecnico == 0)
            {
                MessageBox.Show("El ID de técnico no existe.");
                return;
            }

            // Validar que equipo existe
            var checkEquipo = new SqlCommand("SELECT COUNT(*) FROM Equipo WHERE equipo_id = @eqId;", conn);
            checkEquipo.Parameters.AddWithValue("@eqId", equipoId);
            int countEquipo = (int)checkEquipo.ExecuteScalar();
            if (countEquipo == 0)
            {
                MessageBox.Show("El ID de equipo no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Diagnosticos 
                (diagnostico_id, tecnico_id, equipo_id, falla_reportada, diagnostico_real, fecha_hora, fecha, hora)
                VALUES (@id, @tec, @eq, @falla, @diag, @fechaHora, @fecha, @hora);", conn);

            cmd.Parameters.AddWithValue("@id", diagnosticoId);
            cmd.Parameters.AddWithValue("@tec", tecnicoId);
            cmd.Parameters.AddWithValue("@eq", equipoId);
            cmd.Parameters.AddWithValue("@falla", txtFallaReportada.Text ?? "");
            cmd.Parameters.AddWithValue("@diag", txtDiagnosticoFinal.Text ?? "");
            cmd.Parameters.AddWithValue("@fechaHora", fechaHora);
            cmd.Parameters.AddWithValue("@fecha", fechaHora.Date);
            cmd.Parameters.AddWithValue("@hora", fechaHora.TimeOfDay);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnóstico ingresado correctamente.");
            CargarDiagnosticos();
            LimpiarCampos();
        }

        // ===================== MOSTRAR TODOS =====================
        private void btnMostrarD_Click(object sender, EventArgs e)
        {
            CargarDiagnosticos();
            LimpiarCampos();
        }


        // ===================== ACTUALIZAR =====================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdDiagnostico.Text, out int diagnosticoId))
            {
                MessageBox.Show("Ingrese un ID de diagnóstico válido.");
                return;
            }

            if (!int.TryParse(txtIdTecnico.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            if (!int.TryParse(txtIDequipo.Text, out int equipoId))
            {
                MessageBox.Show("Ingrese un ID de equipo válido.");
                return;
            }

            if (!DateTime.TryParse(txtFecha.Text + " " + txtHora.Text, out DateTime fechaHora))
            {
                MessageBox.Show("Fecha u hora no válida.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar que técnico existe
            var checkTecnico = new SqlCommand("SELECT COUNT(*) FROM Tecnicos WHERE tecnico_id = @tecId;", conn);
            checkTecnico.Parameters.AddWithValue("@tecId", tecnicoId);
            int countTecnico = (int)checkTecnico.ExecuteScalar();
            if (countTecnico == 0)
            {
                MessageBox.Show("El ID de técnico no existe.");
                return;
            }

            // Validar que equipo existe
            var checkEquipo = new SqlCommand("SELECT COUNT(*) FROM Equipo WHERE equipo_id = @eqId;", conn);
            checkEquipo.Parameters.AddWithValue("@eqId", equipoId);
            int countEquipo = (int)checkEquipo.ExecuteScalar();
            if (countEquipo == 0)
            {
                MessageBox.Show("El ID de equipo no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                UPDATE Diagnosticos
                SET tecnico_id = @tec,
                    equipo_id = @eq,
                    falla_reportada = @falla,
                    diagnostico_real = @diag,
                    fecha_hora = @fechaHora,
                    fecha = @fecha,
                    hora = @hora
                WHERE diagnostico_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", diagnosticoId);
            cmd.Parameters.AddWithValue("@tec", tecnicoId);
            cmd.Parameters.AddWithValue("@eq", equipoId);
            cmd.Parameters.AddWithValue("@falla", txtFallaReportada.Text ?? "");
            cmd.Parameters.AddWithValue("@diag", txtDiagnosticoFinal.Text ?? "");
            cmd.Parameters.AddWithValue("@fechaHora", fechaHora);
            cmd.Parameters.AddWithValue("@fecha", fechaHora.Date);
            cmd.Parameters.AddWithValue("@hora", fechaHora.TimeOfDay);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Diagnóstico actualizado correctamente.");
                CargarDiagnosticos();
            }
            else
            {
                MessageBox.Show("No se encontró el diagnóstico con ese ID.");
            }
        }

        // ===================== ELIMINAR =====================
        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdDiagnostico.Text, out int diagnosticoId))
            {
                MessageBox.Show("Ingrese un ID de diagnóstico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Diagnosticos WHERE diagnostico_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", diagnosticoId);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Diagnóstico eliminado correctamente.");
                CargarDiagnosticos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se encontró el diagnóstico con ese ID.");
            }
        }


        private void Diagnosticos_Load(object sender, EventArgs e)
        {
            CargarDiagnosticos();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdDiagnostico.Text, out int diagnosticoId))
            {
                MessageBox.Show("Ingrese un ID de diagnóstico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Diagnosticos WHERE diagnostico_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", diagnosticoId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                MostrarDiagnosticos.DataSource = dt;

                txtIdTecnico.Text = dt.Rows[0]["tecnico_id"].ToString();
                txtIDequipo.Text = dt.Rows[0]["equipo_id"].ToString();
                txtFallaReportada.Text = dt.Rows[0]["falla_reportada"].ToString();
                txtDiagnosticoFinal.Text = dt.Rows[0]["diagnostico_real"].ToString();

                if (dt.Rows[0]["fecha_hora"] != DBNull.Value)
                {
                    DateTime fechaHora = Convert.ToDateTime(dt.Rows[0]["fecha_hora"]);
                    txtFecha.Text = fechaHora.ToString("yyyy-MM-dd");
                    txtHora.Text = fechaHora.ToString("HH:mm");
                }
            }
            else
            {
                MessageBox.Show("Diagnóstico no encontrado.");
                MostrarDiagnosticos.DataSource = null;
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtIdDiagnostico.Clear();
            txtIdTecnico.Clear();
            txtIDequipo.Clear();
            txtFallaReportada.Clear();
            txtDiagnosticoFinal.Clear();
            txtFecha.Clear();
            txtHora.Clear();
        }

        private void txtDiagnosticoFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
