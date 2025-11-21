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
    public partial class ObtencionRepuestos : Form
    {

        public ObtencionRepuestos()
        {
            InitializeComponent();
            CargarObtencionRepuestos();
            UIStyles.ApplyAllStyles(this);

            // Establecer fecha actual por defecto
            dtpFechaObtencion.Value = DateTime.Now;
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnBuscarObtencion_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtObtencionID.Text, out int obtencionId))
            {
                MessageBox.Show("Ingrese un ID de obtención válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Obtencion_Repuestos WHERE obtencion_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", obtencionId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvObtencion.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtRepID.Text = dt.Rows[0]["repuesto_id"].ToString();
                txtProovedorID.Text = dt.Rows[0]["proveedor_id"].ToString();
                txtOrigen.Text = dt.Rows[0]["origen_proveedor"].ToString();
                txtDocComp.Text = dt.Rows[0]["documento"].ToString();
                textCantidadObRe.Text = dt.Rows[0]["cantidad"].ToString();
                txtCostoUnitario.Text = dt.Rows[0]["costo_unitario"].ToString();

                if (dt.Rows[0]["fecha_obtencion"] != DBNull.Value)
                {
                    dtpFechaObtencion.Value = Convert.ToDateTime(dt.Rows[0]["fecha_obtencion"]);
                }
            }
            else
            {
                MessageBox.Show("Obtención no encontrada.");
                LimpiarCampos();
            }
        }

        private void btnIngresoObtencion_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtObtencionID.Text, out int obtencionId))
            {
                MessageBox.Show("Ingrese un ID de obtención válido.");
                return;
            }

            if (!int.TryParse(txtRepID.Text, out int repuestoId))
            {
                MessageBox.Show("Ingrese un ID de repuesto válido.");
                return;
            }

            if (!int.TryParse(txtProovedorID.Text, out int proveedorId))
            {
                MessageBox.Show("Ingrese un ID de proveedor válido.");
                return;
            }

            if (!int.TryParse(textCantidadObRe.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            if (!decimal.TryParse(txtCostoUnitario.Text, out decimal costoUnitario))
            {
                MessageBox.Show("Ingrese un costo unitario válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Obtencion_Repuestos WHERE obtencion_id = @id;", conn);
            check.Parameters.AddWithValue("@id", obtencionId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID de obtención ya existe. Ingrese otro.");
                return;
            }

            // Validar que el repuesto existe
            var checkRepuesto = new SqlCommand("SELECT COUNT(*) FROM Repuestos WHERE repuesto_id = @repuestoId;", conn);
            checkRepuesto.Parameters.AddWithValue("@repuestoId", repuestoId);
            int countRepuesto = (int)checkRepuesto.ExecuteScalar();
            if (countRepuesto == 0)
            {
                MessageBox.Show("El ID de repuesto no existe.");
                return;
            }

            // Validar que el proveedor existe
            var checkProveedor = new SqlCommand("SELECT COUNT(*) FROM Proveedores WHERE proveedor_id = @proveedorId;", conn);
            checkProveedor.Parameters.AddWithValue("@proveedorId", proveedorId);
            int countProveedor = (int)checkProveedor.ExecuteScalar();
            if (countProveedor == 0)
            {
                MessageBox.Show("El ID de proveedor no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Obtencion_Repuestos 
                (obtencion_id, repuesto_id, proveedor_id, origen_proveedor, documento, fecha_obtencion, cantidad, costo_unitario)
                VALUES
                (@id, @repuesto, @proveedor, @origen, @documento, @fecha, @cantidad, @costo);", conn);

            cmd.Parameters.AddWithValue("@id", obtencionId);
            cmd.Parameters.AddWithValue("@repuesto", repuestoId);
            cmd.Parameters.AddWithValue("@proveedor", proveedorId);
            cmd.Parameters.AddWithValue("@origen", txtOrigen.Text ?? "");
            cmd.Parameters.AddWithValue("@documento", txtDocComp.Text ?? "");
            cmd.Parameters.AddWithValue("@fecha", dtpFechaObtencion.Value);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            cmd.Parameters.AddWithValue("@costo", costoUnitario);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Obtención de repuesto ingresada exitosamente.");
            CargarObtencionRepuestos();
            LimpiarCampos();
        }

        private void btnMostrarObtencion_Click(object sender, EventArgs e)
        {
            CargarObtencionRepuestos();
            LimpiarCampos();
        }

        private void btnEliminarObtencion_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtObtencionID.Text, out int obtencionId))
            {
                MessageBox.Show("Ingrese un ID de obtención válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Obtencion_Repuestos WHERE obtencion_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", obtencionId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Obtención de repuesto eliminada.");
            else
                MessageBox.Show("No existe una obtención con ese ID.");

            CargarObtencionRepuestos();
            LimpiarCampos();
        }

        private void btnActualizarObtencion_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtObtencionID.Text, out int obtencionId))
            {
                MessageBox.Show("Ingrese un ID de obtención válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Obtencion_Repuestos WHERE obtencion_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", obtencionId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvObtencion.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtRepID.Text = dt.Rows[0]["repuesto_id"].ToString();
                txtProovedorID.Text = dt.Rows[0]["proveedor_id"].ToString();
                txtOrigen.Text = dt.Rows[0]["origen_proveedor"].ToString();
                txtDocComp.Text = dt.Rows[0]["documento"].ToString();
                textCantidadObRe.Text = dt.Rows[0]["cantidad"].ToString();
                txtCostoUnitario.Text = dt.Rows[0]["costo_unitario"].ToString();

                if (dt.Rows[0]["fecha_obtencion"] != DBNull.Value)
                {
                    dtpFechaObtencion.Value = Convert.ToDateTime(dt.Rows[0]["fecha_obtencion"]);
                }
            }
            else
            {
                MessageBox.Show("Obtención no encontrada.");
                LimpiarCampos();
            }
        }

        private void CargarObtencionRepuestos()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Obtencion_Repuestos ORDER BY obtencion_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvObtencion.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar obtenciones: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtObtencionID.Clear();
            txtRepID.Clear();
            txtProovedorID.Clear();
            txtOrigen.Clear();
            txtDocComp.Clear();
            textCantidadObRe.Clear();
            txtCostoUnitario.Clear();
            dtpFechaObtencion.Value = DateTime.Now;
        }

        // Evento para calcular el costo total automáticamente
        private void CalcularCostoTotal(object sender, EventArgs e)
        {
            if (int.TryParse(textCantidadObRe.Text, out int cantidad) &&
                decimal.TryParse(txtCostoUnitario.Text, out decimal costoUnitario))
            {
                decimal costoTotal = cantidad * costoUnitario;
                // Puedes mostrar el costo total en un label si lo deseas
                // lblCostoTotal.Text = $"Costo Total: {costoTotal:C}";
            }
        }


        private void txtCostoUnitario_TextChanged_1(object sender, EventArgs e)
        {
            CalcularCostoTotal(sender, e);
        }

        private void textCantidadObRe_TextChanged_1(object sender, EventArgs e)
        {
            CalcularCostoTotal(sender, e);
        }
    }
}
