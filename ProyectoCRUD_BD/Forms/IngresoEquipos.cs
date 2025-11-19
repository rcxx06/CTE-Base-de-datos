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

       

        private void btnIngresarEquipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipoID.Text))
            {
                MessageBox.Show("Debe ingresar un ID para el equipo.");
                return;
            }

            using (SqlConnection conn = SQLCONECTION.GetConnection())
            {
                conn.Open();

                // Verificar existencia del ID
                SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM Equipo WHERE id_equipo = @id", conn);
                check.Parameters.AddWithValue("@id", txtEquipoID.Text);
                int count = (int)check.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("El ID ingresado ya existe.");
                    return;
                }

                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Equipo (id_equipo, cliente_id, marca, n_serie, modelo, tipo)
                    VALUES (@id, @cliente, @marca, @serial, @modelo, @tipo)
                ", conn);

                cmd.Parameters.AddWithValue("@id", txtEquipoID.Text);
                cmd.Parameters.AddWithValue("@cliente", txtId_cliente.Text);
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("@serial", txtSerialNumber.Text);
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                cmd.Parameters.AddWithValue("@tipo", txtTipoEquipo.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Equipo agregado exitosamente.");
                CargarEquipos();
            }
        }

        private void btnEliminarEquipos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipoID.Text))
            {
                MessageBox.Show("Ingrese un ID válido para eliminar.");
                return;
            }

            using (SqlConnection conn = SQLCONECTION.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Equipo WHERE id_equipo = @id", conn);
                cmd.Parameters.AddWithValue("@id", txtEquipoID.Text);

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
            if (string.IsNullOrWhiteSpace(txtEquipoID.Text))
            {
                MessageBox.Show("Ingrese un ID válido.");
                return;
            }

            using (SqlConnection conn = SQLCONECTION.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Equipo WHERE id_equipo = @id;", conn);
                cmd.Parameters.AddWithValue("@id", txtEquipoID.Text);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MostrarEquipos.DataSource = dt;

                    txtId_cliente.Text = dt.Rows[0]["cliente_id"].ToString();
                    txtMarca.Text = dt.Rows[0]["marca"].ToString();
                    txtSerialNumber.Text = dt.Rows[0]["n_serie"].ToString();
                    txtModelo.Text = dt.Rows[0]["modelo"].ToString();
                    txtTipoEquipo.Text = dt.Rows[0]["tipo"].ToString();
                }
                else
                {
                    MessageBox.Show("Equipo no encontrado.");
                    MostrarEquipos.DataSource = null;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = SQLCONECTION.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Equipo SET
                        cliente_id = @cliente,
                        marca = @marca,
                        n_serie = @serial,
                        modelo = @modelo,
                        tipo = @tipo
                    WHERE id_equipo = @id
                ", conn);

                cmd.Parameters.AddWithValue("@id", txtEquipoID.Text);
                cmd.Parameters.AddWithValue("@cliente", txtId_cliente.Text);
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                cmd.Parameters.AddWithValue("@serial", txtSerialNumber.Text);
                cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                cmd.Parameters.AddWithValue("@tipo", txtTipoEquipo.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Equipo actualizado correctamente.");
                    btnBuscarEquipo_Click(null, null);
                }
                else
                {
                    MessageBox.Show("No existe un equipo con ese ID.");
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

            using (SqlConnection conn = SQLCONECTION.GetConnection())
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Equipo", conn);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MostrarEquipos.DataSource = dt;
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
