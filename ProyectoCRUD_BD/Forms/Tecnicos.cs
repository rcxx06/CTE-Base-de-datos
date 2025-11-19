using Microsoft.Data.Sqlite;
using System.Data;

namespace ProyectoCRUD_BD.Forms
{
    public partial class Tecnicos : Form
    {
        string dbPath = @"C:\Users\Usuario\Documents\ProyectoCRUD_BD\ProyectoCRUD_BD\bin\Debug\net10.0-windows\CTE.db";

        public Tecnicos()
        {
            InitializeComponent();
            CargarTecnicos();
            UIStyles.ApplyAllStyles(this);

        }

        private SqliteConnection GetConnection()
        {
            return new SqliteConnection($"Data Source={dbPath}");
        }

        private void CargarTecnicos()
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Tecnicos;";

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            MostrarTecnicos.DataSource = dt;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = conn.CreateCommand();
            check.CommandText = "SELECT COUNT(*) FROM Tecnicos WHERE tecnico_id = @id;";
            check.Parameters.AddWithValue("@id", txtId_tecnico.Text);

            long count = (long)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID ya existe. Ingrese otro.");
                return;
            }

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Tecnicos (tecnico_id, nombre, especialidad, horario, contacto)
                VALUES (@id, @nom, @esp, @hor, @cont);";

            cmd.Parameters.AddWithValue("@id", txtId_tecnico.Text);
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
            cmd.Parameters.AddWithValue("@esp", txtEspecialidad.Text);
            cmd.Parameters.AddWithValue("@hor", txtHorario.Text);
            cmd.Parameters.AddWithValue("@cont", txtContacto.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Técnico ingresado correctamente.");
            CargarTecnicos();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Tecnicos WHERE tecnico_id = @id;";
            cmd.Parameters.AddWithValue("@id", txtId_tecnico.Text);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Técnico eliminado.");
                CargarTecnicos();
            }
            else
            {
                MessageBox.Show("No se encontró un técnico con ese ID.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            // Buscar técnico
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Tecnicos WHERE tecnico_id = @id;";
            cmd.Parameters.AddWithValue("@id", txtId_tecnico.Text);

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
                var diagCmd = conn.CreateCommand();
                diagCmd.CommandText = @"
            SELECT diagnostico_id, diagnostico_real, falla_reportada
            FROM Diagnosticos
            WHERE tecnico_id = @id;";
                diagCmd.Parameters.AddWithValue("@id", txtId_tecnico.Text);

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
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using var conn = GetConnection();
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE Tecnicos
                SET nombre = @nom,
                    especialidad = @esp,
                    horario = @hor,
                    contacto = @cont
                WHERE tecnico_id = @id;";

            cmd.Parameters.AddWithValue("@id", txtId_tecnico.Text);
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
            cmd.Parameters.AddWithValue("@esp", txtEspecialidad.Text);
            cmd.Parameters.AddWithValue("@hor", txtHorario.Text);
            cmd.Parameters.AddWithValue("@cont", txtContacto.Text);

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
