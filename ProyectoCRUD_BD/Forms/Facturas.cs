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
    public partial class Facturas : Form
    {

        public Facturas()
        {
            InitializeComponent();
            CargarFacturas();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Facturas WHERE factura_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", facturaId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvFacturas.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtOrdenID.Text = dt.Rows[0]["orden_id"].ToString();

                if (dt.Rows[0]["fecha_emision"] != DBNull.Value)
                {
                    dtpFechaEmision.Value = Convert.ToDateTime(dt.Rows[0]["fecha_emision"]);
                }

                txtSubtotal.Text = dt.Rows[0]["subtotal"].ToString();
                txtImpuestos.Text = dt.Rows[0]["impuestos"].ToString();
                txtTotal.Text = dt.Rows[0]["total"].ToString();
                txtEstadoPago.Text = dt.Rows[0]["estado_pago"].ToString();
                txtMetodoPago.Text = dt.Rows[0]["metodo_pago"].ToString();
            }
            else
            {
                MessageBox.Show("Factura no encontrada.");
                LimpiarCampos();
            }
        }

        private void btnMostrarFacturas_Click(object sender, EventArgs e)
        {
            CargarFacturas();
            LimpiarCampos();
        }

        private void btnIngresoFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            if (!int.TryParse(txtOrdenID.Text, out int ordenId))
            {
                MessageBox.Show("Ingrese un ID de orden válido.");
                return;
            }

            if (!decimal.TryParse(txtSubtotal.Text, out decimal subtotal))
            {
                MessageBox.Show("Ingrese un subtotal válido.");
                return;
            }

            if (!decimal.TryParse(txtImpuestos.Text, out decimal impuestos))
            {
                MessageBox.Show("Ingrese un valor de impuestos válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Facturas WHERE factura_id = @id;", conn);
            check.Parameters.AddWithValue("@id", facturaId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID de factura ya existe. Ingrese otro.");
                return;
            }

            // Validar que la orden existe
            var checkOrden = new SqlCommand("SELECT COUNT(*) FROM Ordenes WHERE orden_id = @ordenId;", conn);
            checkOrden.Parameters.AddWithValue("@ordenId", ordenId);
            int countOrden = (int)checkOrden.ExecuteScalar();
            if (countOrden == 0)
            {
                MessageBox.Show("El ID de orden no existe.");
                return;
            }

            // Calcular total automáticamente
            decimal total = subtotal + impuestos;

            var cmd = new SqlCommand(@"
                INSERT INTO Facturas 
                (factura_id, orden_id, fecha_emision, subtotal, impuestos, total, estado_pago, metodo_pago)
                VALUES
                (@id, @orden, @fecha, @subtotal, @impuestos, @total, @estado, @metodo);", conn);

            cmd.Parameters.AddWithValue("@id", facturaId);
            cmd.Parameters.AddWithValue("@orden", ordenId);
            cmd.Parameters.AddWithValue("@fecha", dtpFechaEmision.Value);
            cmd.Parameters.AddWithValue("@subtotal", subtotal);
            cmd.Parameters.AddWithValue("@impuestos", impuestos);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@estado", txtEstadoPago.Text ?? "");
            cmd.Parameters.AddWithValue("@metodo", txtMetodoPago.Text ?? "");

            cmd.ExecuteNonQuery();

            MessageBox.Show("Factura ingresada exitosamente.");
            CargarFacturas();
            LimpiarCampos();
        }

        private void btnEliminarFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Facturas WHERE factura_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", facturaId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Factura eliminada.");
            else
                MessageBox.Show("No existe una factura con ese ID.");

            CargarFacturas();
            LimpiarCampos();
        }

        private void btnActualizarFactura_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            if (!int.TryParse(txtOrdenID.Text, out int ordenId))
            {
                MessageBox.Show("Ingrese un ID de orden válido.");
                return;
            }

            if (!decimal.TryParse(txtSubtotal.Text, out decimal subtotal))
            {
                MessageBox.Show("Ingrese un subtotal válido.");
                return;
            }

            if (!decimal.TryParse(txtImpuestos.Text, out decimal impuestos))
            {
                MessageBox.Show("Ingrese un valor de impuestos válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar que la orden existe
            var checkOrden = new SqlCommand("SELECT COUNT(*) FROM Ordenes WHERE orden_id = @ordenId;", conn);
            checkOrden.Parameters.AddWithValue("@ordenId", ordenId);
            int countOrden = (int)checkOrden.ExecuteScalar();
            if (countOrden == 0)
            {
                MessageBox.Show("El ID de orden no existe.");
                return;
            }

            // Calcular total automáticamente
            decimal total = subtotal + impuestos;

            var cmd = new SqlCommand(@"
                UPDATE Facturas
                SET orden_id = @orden,
                    fecha_emision = @fecha,
                    subtotal = @subtotal,
                    impuestos = @impuestos,
                    total = @total,
                    estado_pago = @estado,
                    metodo_pago = @metodo
                WHERE factura_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", facturaId);
            cmd.Parameters.AddWithValue("@orden", ordenId);
            cmd.Parameters.AddWithValue("@fecha", dtpFechaEmision.Value);
            cmd.Parameters.AddWithValue("@subtotal", subtotal);
            cmd.Parameters.AddWithValue("@impuestos", impuestos);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@estado", txtEstadoPago.Text ?? "");
            cmd.Parameters.AddWithValue("@metodo", txtMetodoPago.Text ?? "");

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Factura actualizada exitosamente.");
                CargarFacturas();
            }
            else
            {
                MessageBox.Show("No se encontró la factura con ese ID.");
            }
        }

        private void CargarFacturas()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Facturas ORDER BY factura_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvFacturas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar facturas: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtFacturaID.Clear();
            txtOrdenID.Clear();
            dtpFechaEmision.Value = DateTime.Now;
            txtSubtotal.Clear();
            txtImpuestos.Clear();
            txtTotal.Clear();
            txtEstadoPago.Clear();
            txtMetodoPago.Clear();
        }

        private void CalcularTotal(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSubtotal.Text, out decimal subtotal) &&
               decimal.TryParse(txtImpuestos.Text, out decimal impuestos))
            {
                decimal total = subtotal + impuestos;
                txtTotal.Text = total.ToString("F2");
            }
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void txtImpuestos_TextChanged_1(object sender, EventArgs e)
        {
            CalcularTotal(sender, e);
        }

        private void txtSubtotal_TextChanged_1(object sender, EventArgs e)
        {
            CalcularTotal(sender, e);
        }
    }
}
