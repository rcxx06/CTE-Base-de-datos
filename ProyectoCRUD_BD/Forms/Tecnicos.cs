using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using ProyectoCRUD_BD.BDSQL;
using System.Data;

namespace ProyectoCRUD_BD.Forms
{
    public partial class Tecnicos : Form
    {

        public Tecnicos()
        {
            InitializeComponent();
            CargarTecnicos();
            UIStyles.ApplyAllStyles(this);

        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void CargarTecnicos()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Tecnicos ORDER BY tecnico_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                MostrarTecnicos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar técnicos: {ex.Message}");
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId_tecnico.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Tecnicos WHERE tecnico_id = @id;", conn);
            check.Parameters.AddWithValue("@id", tecnicoId);

            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID ya existe. Ingrese otro.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Tecnicos (tecnico_id, nombre, especialidad, horario, contacto)
                VALUES (@id, @nom, @esp, @hor, @cont);", conn);

            cmd.Parameters.AddWithValue("@id", tecnicoId);
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text ?? "");
            cmd.Parameters.AddWithValue("@esp", txtEspecialidad.Text ?? "");
            cmd.Parameters.AddWithValue("@hor", txtHorario.Text ?? "");
            cmd.Parameters.AddWithValue("@cont", txtContacto.Text ?? "");

            cmd.ExecuteNonQuery();
            MessageBox.Show("Técnico ingresado correctamente.");
            CargarTecnicos();
            LimpiarCampos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId_tecnico.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Tecnicos WHERE tecnico_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", tecnicoId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Técnico eliminado.");
                CargarTecnicos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No se encontró un técnico con ese ID.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId_tecnico.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Buscar técnico
            var cmd = new SqlCommand("SELECT * FROM Tecnicos WHERE tecnico_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", tecnicoId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                // Mostrar datos del técnico
                MostrarTecnicos.DataSource = dt;

                txtNombre.Text = dt.Rows[0]["nombre"].ToString();
                txtEspecialidad.Text = dt.Rows[0]["especialidad"].ToString();
                txtHorario.Text = dt.Rows[0]["horario"].ToString();
                txtContacto.Text = dt.Rows[0]["contacto"].ToString();

                // Mostrar solo los campos requeridos de los diagnósticos
                var diagCmd = new SqlCommand(@"
                    SELECT diagnostico_id, diagnostico_real, falla_reportada
                    FROM Diagnosticos
                    WHERE tecnico_id = @id;", conn);
                diagCmd.Parameters.AddWithValue("@id", tecnicoId);

                using var diagReader = diagCmd.ExecuteReader();
                DataTable dtDiag = new DataTable();
                dtDiag.Load(diagReader);

                Drealizados.DataSource = dtDiag;
            }
            else
            {
                MessageBox.Show("Técnico no encontrado.");
                MostrarTecnicos.DataSource = null;
                Drealizados.DataSource = null;
                LimpiarCampos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId_tecnico.Text, out int tecnicoId))
            {
                MessageBox.Show("Ingrese un ID de técnico válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand(@"
                UPDATE Tecnicos
                SET nombre = @nom,
                    especialidad = @esp,
                    horario = @hor,
                    contacto = @cont
                WHERE tecnico_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", tecnicoId);
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text ?? "");
            cmd.Parameters.AddWithValue("@esp", txtEspecialidad.Text ?? "");
            cmd.Parameters.AddWithValue("@hor", txtHorario.Text ?? "");
            cmd.Parameters.AddWithValue("@cont", txtContacto.Text ?? "");

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Datos del técnico actualizados.");
                CargarTecnicos();
            }
            else
            {
                MessageBox.Show("No se encontró el técnico con ese ID.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarTecnicos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId_tecnico.Clear();
            txtNombre.Clear();
            txtEspecialidad.Clear();
            txtHorario.Clear();
            txtContacto.Clear();
        }

        private void Tecnicos_Load(object sender, EventArgs e)
        {

        }
    }
}
