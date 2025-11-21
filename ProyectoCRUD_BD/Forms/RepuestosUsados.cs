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
    public partial class RepuestosUsados : Form
    {

        public RepuestosUsados()
        {
            InitializeComponent();
            CargarRepuestosUsados();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnBuscarRepUsa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepUsaID.Text, out int repUsaId))
            {
                MessageBox.Show("Ingrese un ID de repuesto usado válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand(@"
                SELECT ru.*, r.nombre as nombre_repuesto, f.total as total_factura
                FROM Repuestos_Usados ru
                LEFT JOIN Repuestos r ON ru.repuesto_id = r.repuesto_id
                LEFT JOIN Facturas f ON ru.factura_id = f.factura_id
                WHERE ru.repuestos_usados_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", repUsaId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvRepUsa.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtRepuestoID.Text = dt.Rows[0]["repuesto_id"].ToString();
                txtFacturaID.Text = dt.Rows[0]["factura_id"].ToString();
                txtCantidadUsada.Text = dt.Rows[0]["cantidad_usada"].ToString();
            }
            else
            {
                MessageBox.Show("Registro de repuesto usado no encontrado.");
                LimpiarCampos();
            }
        }

        private void btnIngresoRepUsa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepUsaID.Text, out int repUsaId))
            {
                MessageBox.Show("Ingrese un ID de repuesto usado válido.");
                return;
            }

            if (!int.TryParse(txtRepuestoID.Text, out int repuestoId))
            {
                MessageBox.Show("Ingrese un ID de repuesto válido.");
                return;
            }

            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            if (!int.TryParse(txtCantidadUsada.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a 0.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Repuestos_Usados WHERE repuestos_usados_id = @id;", conn);
            check.Parameters.AddWithValue("@id", repUsaId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID de repuesto usado ya existe. Ingrese otro.");
                return;
            }

            // Validar que el repuesto existe
            var checkRepuesto = new SqlCommand("SELECT COUNT(*) FROM Repuestos WHERE repuesto_id = @repId;", conn);
            checkRepuesto.Parameters.AddWithValue("@repId", repuestoId);
            int countRepuesto = (int)checkRepuesto.ExecuteScalar();
            if (countRepuesto == 0)
            {
                MessageBox.Show("El ID de repuesto no existe.");
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

            // Verificar stock disponible
            var checkStock = new SqlCommand(@"
                SELECT (COALESCE(SUM(or.cantidad), 0) - COALESCE(SUM(ru.cantidad_usada), 0)) as stock_disponible
                FROM Repuestos r
                LEFT JOIN Obtencion_Repuestos or ON r.repuesto_id = or.repuesto_id
                LEFT JOIN Repuestos_Usados ru ON r.repuesto_id = ru.repuesto_id
                WHERE r.repuesto_id = @repId
                GROUP BY r.repuesto_id;", conn);
            checkStock.Parameters.AddWithValue("@repId", repuestoId);

            var stockResult = checkStock.ExecuteScalar();
            int stockDisponible = stockResult != DBNull.Value ? Convert.ToInt32(stockResult) : 0;

            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"Stock insuficiente. Stock disponible: {stockDisponible}");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Repuestos_Usados 
                (repuestos_usados_id, repuesto_id, factura_id, cantidad_usada)
                VALUES
                (@id, @repuesto, @factura, @cantidad);", conn);

            cmd.Parameters.AddWithValue("@id", repUsaId);
            cmd.Parameters.AddWithValue("@repuesto", repuestoId);
            cmd.Parameters.AddWithValue("@factura", facturaId);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Repuesto usado registrado exitosamente.");
            CargarRepuestosUsados();
            LimpiarCampos();
        }

        private void btnMostrarRepUsa_Click(object sender, EventArgs e)
        {
            CargarRepuestosUsados();
            LimpiarCampos();
        }

        private void btnEliminarRepUsa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepUsaID.Text, out int repUsaId))
            {
                MessageBox.Show("Ingrese un ID de repuesto usado válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("DELETE FROM Repuestos_Usados WHERE repuestos_usados_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", repUsaId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Registro de repuesto usado eliminado.");
            else
                MessageBox.Show("No existe un registro de repuesto usado con ese ID.");

            CargarRepuestosUsados();
            LimpiarCampos();
        }

        private void btnActualizarRepUsa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepUsaID.Text, out int repUsaId))
            {
                MessageBox.Show("Ingrese un ID de repuesto usado válido.");
                return;
            }

            if (!int.TryParse(txtRepuestoID.Text, out int repuestoId))
            {
                MessageBox.Show("Ingrese un ID de repuesto válido.");
                return;
            }

            if (!int.TryParse(txtFacturaID.Text, out int facturaId))
            {
                MessageBox.Show("Ingrese un ID de factura válido.");
                return;
            }

            if (!int.TryParse(txtCantidadUsada.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a 0.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar que el repuesto existe
            var checkRepuesto = new SqlCommand("SELECT COUNT(*) FROM Repuestos WHERE repuesto_id = @repId;", conn);
            checkRepuesto.Parameters.AddWithValue("@repId", repuestoId);
            int countRepuesto = (int)checkRepuesto.ExecuteScalar();
            if (countRepuesto == 0)
            {
                MessageBox.Show("El ID de repuesto no existe.");
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

            // Verificar stock disponible (excluyendo la cantidad actual de este registro)
            var checkStock = new SqlCommand(@"
                SELECT (COALESCE(SUM(or.cantidad), 0) - 
                       (COALESCE(SUM(ru.cantidad_usada), 0) - 
                       COALESCE((SELECT cantidad_usada FROM Repuestos_Usados WHERE repuestos_usados_id = @repUsaId), 0))) as stock_disponible
                FROM Repuestos r
                LEFT JOIN Obtencion_Repuestos or ON r.repuesto_id = or.repuesto_id
                LEFT JOIN Repuestos_Usados ru ON r.repuesto_id = ru.repuesto_id
                WHERE r.repuesto_id = @repId
                GROUP BY r.repuesto_id;", conn);
            checkStock.Parameters.AddWithValue("@repId", repuestoId);
            checkStock.Parameters.AddWithValue("@repUsaId", repUsaId);

            var stockResult = checkStock.ExecuteScalar();
            int stockDisponible = stockResult != DBNull.Value ? Convert.ToInt32(stockResult) : 0;

            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"Stock insuficiente. Stock disponible: {stockDisponible}");
                return;
            }

            var cmd = new SqlCommand(@"
                UPDATE Repuestos_Usados
                SET repuesto_id = @repuesto,
                    factura_id = @factura,
                    cantidad_usada = @cantidad
                WHERE repuestos_usados_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", repUsaId);
            cmd.Parameters.AddWithValue("@repuesto", repuestoId);
            cmd.Parameters.AddWithValue("@factura", facturaId);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Registro de repuesto usado actualizado exitosamente.");
                CargarRepuestosUsados();
            }
            else
            {
                MessageBox.Show("No se encontró el registro de repuesto usado con ese ID.");
            }


        }

        private void CargarRepuestosUsados()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand(@"
                    SELECT ru.repuestos_usados_id, ru.repuesto_id, r.nombre as repuesto, 
                           ru.factura_id, ru.cantidad_usada, f.total as total_factura
                    FROM Repuestos_Usados ru
                    LEFT JOIN Repuestos r ON ru.repuesto_id = r.repuesto_id
                    LEFT JOIN Facturas f ON ru.factura_id = f.factura_id
                    ORDER BY ru.repuestos_usados_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvRepUsa.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar repuestos usados: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtRepUsaID.Clear();
            txtRepuestoID.Clear();
            txtFacturaID.Clear();
            txtCantidadUsada.Clear();
        }

        private void RepuestosUsados_Load(object sender, EventArgs e)
        {
            CargarRepuestosUsados();
        }

        /*
         * txtRepUsaID
         * txtRepuestoID
         * txtFacturaID
         * txtCantidadUsada
         * 
         */

    }
}
