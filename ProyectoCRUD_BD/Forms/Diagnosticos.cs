using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoCRUD_BD.Forms
{
    public partial class Diagnosticos : Form
    {
        string dbPath = @"C:\Users\Usuario\Documents\ProyectoCRUD_BD\ProyectoCRUD_BD\bin\Debug\net10.0-windows\CTE.db";

        public Diagnosticos()
        {
            InitializeComponent();
            CargarDiagnosticos();
            UIStyles.ApplyAllStyles(this);
        }

        private SqliteConnection GetConnection()
        {
            return new SqliteConnection($"Data Source={dbPath}");
        }

        // ===================== CARGAR TODOS =====================
        private void CargarDiagnosticos()
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Diagnosticos;";

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            MostrarDiagnosticos.DataSource = dt;
        }

        // ===================== INGRESAR =====================
        private void btnIngresarD_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = conn.CreateCommand();
            check.CommandText = "SELECT COUNT(*) FROM Diagnosticos WHERE diagnostico_id = @id;";
            check.Parameters.AddWithValue("@id", txtIdDiagnostico.Text);
            long count = (long)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID ya existe. Ingrese otro.");
                return;
            }

            // Combinar fecha y hora
            if (!DateTime.TryParse(txtFecha.Text + " " + txtHora.Text, out DateTime fechaHora))
            {
                MessageBox.Show("Fecha u hora no válida.");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Diagnosticos 
                (diagnostico_id, tecnico_id, equipo_id, falla_reportada, Diagnostico_real, fecha_hora)
                VALUES (@id, @tec, @eq, @falla, @diag, @fechaHora);";

            cmd.Parameters.AddWithValue("@id", txtIdDiagnostico.Text);
            cmd.Parameters.AddWithValue("@tec", txtIdTecnico.Text);
            cmd.Parameters.AddWithValue("@eq", txtIDequipo.Text);
            cmd.Parameters.AddWithValue("@falla", txtFallaReportada.Text);
            cmd.Parameters.AddWithValue("@diag", txtDiagnosticoFinal.Text);
            cmd.Parameters.AddWithValue("@fechaHora", fechaHora);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnóstico ingresado correctamente.");
            CargarDiagnosticos();
        }

        // ===================== MOSTRAR TODOS =====================
        private void btnMostrarD_Click(object sender, EventArgs e)
        {
            CargarDiagnosticos();
        }

        // ===================== ACTUALIZAR =====================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            if (!DateTime.TryParse(txtFecha.Text + " " + txtHora.Text, out DateTime fechaHora))
            {
                MessageBox.Show("Fecha u hora no válida.");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE Diagnosticos
                SET tecnico_id = @tec,
                    equipo_id = @eq,
                    falla_reportada = @falla,
                    Diagnostico_real = @diag,
                    fecha_hora = @fechaHora
                WHERE diagnostico_id = @id;";

            cmd.Parameters.AddWithValue("@id", txtIdDiagnostico.Text);
            cmd.Parameters.AddWithValue("@tec", txtIdTecnico.Text);
            cmd.Parameters.AddWithValue("@eq", txtIDequipo.Text);
            cmd.Parameters.AddWithValue("@falla", txtFallaReportada.Text);
            cmd.Parameters.AddWithValue("@diag", txtDiagnosticoFinal.Text);
            cmd.Parameters.AddWithValue("@fechaHora", fechaHora);

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
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Diagnosticos WHERE diagnostico_id = @id;";
            cmd.Parameters.AddWithValue("@id", txtIdDiagnostico.Text);

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Diagnóstico eliminado correctamente.");
                CargarDiagnosticos();
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
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Diagnosticos WHERE diagnostico_id = @id;";
            cmd.Parameters.AddWithValue("@id", txtIdDiagnostico.Text);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                MostrarDiagnosticos.DataSource = dt;

                txtIdTecnico.Text = dt.Rows[0]["tecnico_id"].ToString();
                txtIDequipo.Text = dt.Rows[0]["equipo_id"].ToString();
                txtFallaReportada.Text = dt.Rows[0]["falla_reportada"].ToString();
                txtDiagnosticoFinal.Text = dt.Rows[0]["Diagnostico_real"].ToString();
                txtFecha.Text = Convert.ToDateTime(dt.Rows[0]["fecha_hora"]).ToString("yyyy-MM-dd");
                txtHora.Text = Convert.ToDateTime(dt.Rows[0]["fecha_hora"]).ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("Diagnóstico no encontrado.");
                MostrarDiagnosticos.DataSource = null;
            }
        }

        private void txtDiagnosticoFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
