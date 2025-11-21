using Microsoft.Data.SqlClient;
using ProyectoCRUD_BD.BDSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCRUD_BD.Forms
{
    public partial class Garantias : Form
    {

        public Garantias()
        {
            InitializeComponent();
            CargarGarantias();
            UIStyles.ApplyAllStyles(this);

            // Establecer fechas por defecto
            dtpFechaInicioG.Value = DateTime.Now;
            dtpFechaVencimientoG.Value = DateTime.Now.AddYears(1); // Un anio por defecto
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnBuscarGarantia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGarantiaID.Text, out int garantiaId))
            {
                MessageBox.Show("Ingrese un ID de garantía válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Garantias WHERE garantia_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", garantiaId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvGarantias.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtFacturaID.Text = dt.Rows[0]["factura_id"].ToString();
                txtCondiciones.Text = dt.Rows[0]["condiciones"].ToString();
                txtDuracionMeses.Text = dt.Rows[0]["duracion_meses"].ToString();

                if (dt.Rows[0]["fecha_inicio"] != DBNull.Value)
                {
                    dtpFechaInicioG.Value = Convert.ToDateTime(dt.Rows[0]["fecha_inicio"]);
                }

                if (dt.Rows[0]["fecha_vencimiento"] != DBNull.Value)
                {
                    dtpFechaVencimientoG.Value = Convert.ToDateTime(dt.Rows[0]["fecha_vencimiento"]);
                }
            }
            else
            {
                MessageBox.Show("Garantía no encontrada.");
                LimpiarCampos();
            }
        }

        private void btnActualizarGarantia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGarantiaID.Text, out int garantiaId))
            {
                MessageBox.Show("Ingrese un ID de garantía válido.");
                return;
            }

            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            if (!int.TryParse(txtDuracionMeses.Text, out int duracionMeses))
            {
                MessageBox.Show("Ingrese una duración en meses válida.");
                return;
            }

            // Validar que la fecha de vencimiento sea mayor a la fecha de inicio
            if (dtpFechaVencimientoG.Value <= dtpFechaInicioG.Value)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a la fecha de inicio.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar que la factura existe
            var checkFactura = new SqlCommand("SELECT COUNT(*) FROM Facturas WHERE factura_id = @facturaId;", conn);
            checkFactura.Parameters.AddWithValue("@facturaId", facturaId);
            int countFactura = (int)checkFactura.ExecuteScalar();
            if (countFactura == 0)
            {
                MessageBox.Show("El ID de factura no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                UPDATE Garantias
                SET factura_id = @factura,
                    condiciones = @condiciones,
                    duracion_meses = @duracion,
                    fecha_inicio = @fechaInicio,
                    fecha_vencimiento = @fechaVencimiento
                WHERE garantia_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", garantiaId);
            cmd.Parameters.AddWithValue("@factura", facturaId);
            cmd.Parameters.AddWithValue("@condiciones", txtCondiciones.Text ?? "");
            cmd.Parameters.AddWithValue("@duracion", duracionMeses);
            cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicioG.Value);
            cmd.Parameters.AddWithValue("@fechaVencimiento", dtpFechaVencimientoG.Value);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Garantía actualizada exitosamente.");
                CargarGarantias();
            }
            else
            {
                MessageBox.Show("No se encontró la garantía con ese ID.");
            }
        }

        private void btnMostrarGarantia_Click(object sender, EventArgs e)
        {
            CargarGarantias();
            LimpiarCampos();
        }

        private void btnIngresoGarantia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGarantiaID.Text, out int garantiaId))
            {
                MessageBox.Show("Ingrese un ID de garantía válido.");
                return;
            }

            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            if (!int.TryParse(txtDuracionMeses.Text, out int duracionMeses))
            {
                MessageBox.Show("Ingrese una duración en meses válida.");
                return;
            }

            // Validar que la fecha de vencimiento sea mayor a la fecha de inicio
            if (dtpFechaVencimientoG.Value <= dtpFechaInicioG.Value)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a la fecha de inicio.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Garantias WHERE garantia_id = @id;", conn);
            check.Parameters.AddWithValue("@id", garantiaId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID de garantía ya existe. Ingrese otro.");
                return;
            }

            // Validar que la factura existe
            var checkFactura = new SqlCommand("SELECT COUNT(*) FROM Facturas WHERE factura_id = @facturaId;", conn);
            checkFactura.Parameters.AddWithValue("@facturaId", facturaId);
            int countFactura = (int)checkFactura.ExecuteScalar();
            if (countFactura == 0)
            {
                MessageBox.Show("El ID de factura no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Garantias 
                (garantia_id, factura_id, condiciones, duracion_meses, fecha_inicio, fecha_vencimiento)
                VALUES
                (@id, @factura, @condiciones, @duracion, @fechaInicio, @fechaVencimiento);", conn);

            cmd.Parameters.AddWithValue("@id", garantiaId);
            cmd.Parameters.AddWithValue("@factura", facturaId);
            cmd.Parameters.AddWithValue("@condiciones", txtCondiciones.Text ?? "");
            cmd.Parameters.AddWithValue("@duracion", duracionMeses);
            cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicioG.Value);
            cmd.Parameters.AddWithValue("@fechaVencimiento", dtpFechaVencimientoG.Value);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Garantía ingresada exitosamente.");
            CargarGarantias();
            LimpiarCampos();
        }

        private void btnEliminarGarantia_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGarantiaID.Text, out int garantiaId))
            {
                MessageBox.Show("Ingrese un ID de garantía válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Garantias WHERE garantia_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", garantiaId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Garantía eliminada.");
            else
                MessageBox.Show("No existe una garantía con ese ID.");

            CargarGarantias();
            LimpiarCampos();
        }

        private void CargarGarantias()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Garantias ORDER BY garantia_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvGarantias.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar garantías: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtGarantiaID.Clear();
            txtFacturaID.Clear();
            txtCondiciones.Clear();
            txtDuracionMeses.Clear();
            dtpFechaInicioG.Value = DateTime.Now;
            dtpFechaVencimientoG.Value = DateTime.Now.AddMonths(1);
        }

        private void CalcularFechaVencimiento(object sender, EventArgs e)
        {
            if (int.TryParse(txtDuracionMeses.Text, out int duracionMeses) && duracionMeses > 0)
            {
                dtpFechaVencimientoG.Value = dtpFechaInicioG.Value.AddMonths(duracionMeses);
            }
        }

        private void Garantias_Load(object sender, EventArgs e)
        {
            CargarGarantias();
        }

        private void txtDuracionMeses_TextChanged_1(object sender, EventArgs e)
        {
            CalcularFechaVencimiento(sender, e);
        }

        private void dtpFechaInicioG_ValueChanged_1(object sender, EventArgs e)
        {
            CalcularFechaVencimiento(sender, e);
        }
    }
}
