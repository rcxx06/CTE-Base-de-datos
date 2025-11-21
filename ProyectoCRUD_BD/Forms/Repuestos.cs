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
    public partial class Repuestos : Form
    {

        public Repuestos()
        {
            InitializeComponent();
            CargarRepuestos();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void Repuestos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepuestoID.Text, out int repuestoId))
            {
                MessageBox.Show("Ingrese un ID de repuesto válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand(@"
                SELECT r.*, tr.nombre_tipo as tipo_repuesto
                FROM Repuestos r
                LEFT JOIN Tipo_repuesto tr ON r.tipo_repuesto_id = tr.tipo_id
                WHERE r.repuesto_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", repuestoId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvRepuesto.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtTipoID.Text = dt.Rows[0]["tipo_repuesto_id"].ToString();
                txtUbiRep.Text = dt.Rows[0]["ubicacion"].ToString();
                txtSerie.Text = dt.Rows[0]["n_serie"].ToString();
                txtRepNombre.Text = dt.Rows[0]["nombre"].ToString();
                txtDescRep.Text = dt.Rows[0]["descripcion"].ToString();
                txtCosto.Text = dt.Rows[0]["costo_unitario"].ToString();
            }
            else
            {
                MessageBox.Show("Repuesto no encontrado.");
                LimpiarCampos();
            }
        }

        private void btnMostrarRepuesto_Click(object sender, EventArgs e)
        {
            CargarRepuestos();
            LimpiarCampos();
        }

        private void btnIngresoRepuesto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepuestoID.Text, out int repuestoId))
            {
                MessageBox.Show("Ingrese un ID de repuesto válido.");
                return;
            }

            if (!int.TryParse(txtTipoID.Text, out int tipoId))
            {
                MessageBox.Show("Ingrese un ID de tipo válido.");
                return;
            }

            if (!decimal.TryParse(txtCosto.Text, out decimal costo) || costo < 0)
            {
                MessageBox.Show("Ingrese un costo válido mayor o igual a 0.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Repuestos WHERE repuesto_id = @id;", conn);
            check.Parameters.AddWithValue("@id", repuestoId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID de repuesto ya existe. Ingrese otro.");
                return;
            }

            // Validar que el tipo existe
            var checkTipo = new SqlCommand("SELECT COUNT(*) FROM Tipo_repuesto WHERE tipo_id = @tipoId;", conn);
            checkTipo.Parameters.AddWithValue("@tipoId", tipoId);
            int countTipo = (int)checkTipo.ExecuteScalar();
            if (countTipo == 0)
            {
                MessageBox.Show("El ID de tipo no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Repuestos 
                (repuesto_id, tipo_repuesto_id, ubicacion, n_serie, nombre, descripcion, costo_unitario)
                VALUES
                (@id, @tipo, @ubicacion, @serie, @nombre, @descripcion, @costo);", conn);

            cmd.Parameters.AddWithValue("@id", repuestoId);
            cmd.Parameters.AddWithValue("@tipo", tipoId);
            cmd.Parameters.AddWithValue("@ubicacion", txtUbiRep.Text ?? "");
            cmd.Parameters.AddWithValue("@serie", txtSerie.Text ?? "");
            cmd.Parameters.AddWithValue("@nombre", txtRepNombre.Text ?? "");
            cmd.Parameters.AddWithValue("@descripcion", txtDescRep.Text ?? "");
            cmd.Parameters.AddWithValue("@costo", costo);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Repuesto ingresado exitosamente.");
            CargarRepuestos();
            LimpiarCampos();
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepuestoID.Text, out int repuestoId))
            {
                MessageBox.Show("Ingrese un ID de repuesto válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Verificar si el repuesto está siendo usado en Repuestos_Usados
            var checkUso = new SqlCommand("SELECT COUNT(*) FROM Repuestos_Usados WHERE repuesto_id = @id;", conn);
            checkUso.Parameters.AddWithValue("@id", repuestoId);
            int countUso = (int)checkUso.ExecuteScalar();

            if (countUso > 0)
            {
                MessageBox.Show("No se puede eliminar el repuesto porque está siendo usado en reparaciones.");
                return;
            }

            var cmd = new SqlCommand("DELETE FROM Repuestos WHERE repuesto_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", repuestoId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Repuesto eliminado.");
            else
                MessageBox.Show("No existe un repuesto con ese ID.");

            CargarRepuestos();
            LimpiarCampos();
        }

        private void btnActualizarRepuesto_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRepuestoID.Text, out int repuestoId))
            {
                MessageBox.Show("Ingrese un ID de repuesto válido.");
                return;
            }

            if (!int.TryParse(txtTipoID.Text, out int tipoId))
            {
                MessageBox.Show("Ingrese un ID de tipo válido.");
                return;
            }

            if (!decimal.TryParse(txtCosto.Text, out decimal costo) || costo < 0)
            {
                MessageBox.Show("Ingrese un costo válido mayor o igual a 0.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar que el tipo existe
            var checkTipo = new SqlCommand("SELECT COUNT(*) FROM Tipo_repuesto WHERE tipo_id = @tipoId;", conn);
            checkTipo.Parameters.AddWithValue("@tipoId", tipoId);
            int countTipo = (int)checkTipo.ExecuteScalar();
            if (countTipo == 0)
            {
                MessageBox.Show("El ID de tipo no existe.");
                return;
            }

            var cmd = new SqlCommand(@"
                UPDATE Repuestos
                SET tipo_repuesto_id = @tipo,
                    ubicacion = @ubicacion,
                    n_serie = @serie,
                    nombre = @nombre,
                    descripcion = @descripcion,
                    costo_unitario = @costo
                WHERE repuesto_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", repuestoId);
            cmd.Parameters.AddWithValue("@tipo", tipoId);
            cmd.Parameters.AddWithValue("@ubicacion", txtUbiRep.Text ?? "");
            cmd.Parameters.AddWithValue("@serie", txtSerie.Text ?? "");
            cmd.Parameters.AddWithValue("@nombre", txtRepNombre.Text ?? "");
            cmd.Parameters.AddWithValue("@descripcion", txtDescRep.Text ?? "");
            cmd.Parameters.AddWithValue("@costo", costo);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Repuesto actualizado exitosamente.");
                CargarRepuestos();
            }
            else
            {
                MessageBox.Show("No se encontró el repuesto con ese ID.");
            }
        }

        private void CargarRepuestos()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand(@"
                    SELECT 
                        r.repuesto_id,
                        r.nombre,
                        r.n_serie,
                        r.ubicacion,
                        r.descripcion,
                        r.costo_unitario,
                        tr.nombre_tipo as tipo,
                        tr.electronico
                    FROM Repuestos r
                    LEFT JOIN Tipo_repuesto tr ON r.tipo_repuesto_id = tr.tipo_id
                    ORDER BY r.repuesto_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvRepuesto.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar repuestos: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtRepuestoID.Clear();
            txtTipoID.Clear();
            txtUbiRep.Clear();
            txtSerie.Clear();
            txtRepNombre.Clear();
            txtDescRep.Clear();
            txtCosto.Clear();
        }

        /*
         * txtRepuestoID
         * txtTipoID
         * txtUbiRep
         * txtSerie
         * txtCosto
         * txtRepNombre
         * txtDescRep
         * 
         * el dat gred view 
         * dgvRepuesto
         * 
         * 
         */

    }
}
