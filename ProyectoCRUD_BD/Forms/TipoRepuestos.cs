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
    public partial class TipoRepuestos : Form
    {
      
        public TipoRepuestos()
        {
            InitializeComponent();
            CargarTiposRepuestos();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnBuscarTipoRep_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTipoID.Text, out int tipoId))
            {
                MessageBox.Show("Ingrese un ID de tipo válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Tipo_repuesto WHERE tipo_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", tipoId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvTipoRep.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtTipoNombre.Text = dt.Rows[0]["nombre_tipo"].ToString();
                textTipoElectronico.Text = dt.Rows[0]["electronico"].ToString();
            }
            else
            {
                MessageBox.Show("Tipo de repuesto no encontrado.");
                LimpiarCampos();
            }
        }

        private void btnMostrarTipoRep_Click(object sender, EventArgs e)
        {
            CargarTiposRepuestos();
            LimpiarCampos();
        }

        private void btnIngresoTipoRep_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTipoID.Text, out int tipoId))
            {
                MessageBox.Show("Ingrese un ID de tipo válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipoNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para el tipo.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Tipo_repuesto WHERE tipo_id = @id;", conn);
            check.Parameters.AddWithValue("@id", tipoId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID de tipo ya existe. Ingrese otro.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Tipo_repuesto 
                (tipo_id, nombre_tipo, electronico)
                VALUES
                (@id, @nombre, @electronico);", conn);

            cmd.Parameters.AddWithValue("@id", tipoId);
            cmd.Parameters.AddWithValue("@nombre", txtTipoNombre.Text);
            cmd.Parameters.AddWithValue("@electronico", textTipoElectronico.Text ?? "");

            cmd.ExecuteNonQuery();

            MessageBox.Show("Tipo de repuesto ingresado exitosamente.");
            CargarTiposRepuestos();
            LimpiarCampos();
        }

        private void btnEliminarTipoRep_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTipoID.Text, out int tipoId))
            {
                MessageBox.Show("Ingrese un ID de tipo válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Verificar si el tipo está siendo usado en Repuestos
            var checkUso = new SqlCommand("SELECT COUNT(*) FROM Repuestos WHERE tipo_repuesto_id = @id;", conn);
            checkUso.Parameters.AddWithValue("@id", tipoId);
            int countUso = (int)checkUso.ExecuteScalar();

            if (countUso > 0)
            {
                MessageBox.Show("No se puede eliminar el tipo porque está siendo usado en repuestos.");
                return;
            }

            var cmd = new SqlCommand("DELETE FROM Tipo_repuesto WHERE tipo_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", tipoId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Tipo de repuesto eliminado.");
            else
                MessageBox.Show("No existe un tipo de repuesto con ese ID.");

            CargarTiposRepuestos();
            LimpiarCampos();
        }

        private void btnActualizarTipoRep_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTipoID.Text, out int tipoId))
            {
                MessageBox.Show("Ingrese un ID de tipo válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTipoNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para el tipo.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand(@"
                UPDATE Tipo_repuesto
                SET nombre_tipo = @nombre,
                    electronico = @electronico
                WHERE tipo_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", tipoId);
            cmd.Parameters.AddWithValue("@nombre", txtTipoNombre.Text);
            cmd.Parameters.AddWithValue("@electronico", textTipoElectronico.Text ?? "");

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Tipo de repuesto actualizado exitosamente.");
                CargarTiposRepuestos();
            }
            else
            {
                MessageBox.Show("No se encontró el tipo de repuesto con ese ID.");
            }
        }

        private void CargarTiposRepuestos()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand(@"
                    SELECT 
                        tr.tipo_id,
                        tr.nombre_tipo,
                        tr.electronico,
                        COUNT(r.repuesto_id) as cantidad_repuestos
                    FROM Tipo_repuesto tr
                    LEFT JOIN Repuestos r ON tr.tipo_id = r.tipo_repuesto_id
                    GROUP BY tr.tipo_id, tr.nombre_tipo, tr.electronico
                    ORDER BY tr.tipo_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvTipoRep.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tipos de repuestos: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtTipoID.Clear();
            txtTipoNombre.Clear();
            textTipoElectronico.Clear();
        }

        private void btnMostrarRepuestosTipo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTipoID.Text, out int tipoId))
            {
                MessageBox.Show("Ingrese un ID de tipo válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand(@"
                SELECT 
                    r.repuesto_id,
                    r.nombre,
                    r.n_serie,
                    r.ubicacion,
                    r.costo_unitario
                FROM Repuestos r
                WHERE r.tipo_repuesto_id = @tipoId
                ORDER BY r.repuesto_id;", conn);
            cmd.Parameters.AddWithValue("@tipoId", tipoId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            if (dt.Rows.Count > 0)
            {
                dgvTipoRep.DataSource = dt;
                MessageBox.Show($"Se encontraron {dt.Rows.Count} repuestos de este tipo.");
            }
            else
            {
                MessageBox.Show("No se encontraron repuestos para este tipo.");
            }
        }

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTipoNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre para buscar.");
                return;
            }

            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand(@"
                    SELECT 
                        tr.tipo_id,
                        tr.nombre_tipo,
                        tr.electronico,
                        COUNT(r.repuesto_id) as cantidad_repuestos
                    FROM Tipo_repuesto tr
                    LEFT JOIN Repuestos r ON tr.tipo_id = r.tipo_repuesto_id
                    WHERE tr.nombre_tipo LIKE @nombre
                    GROUP BY tr.tipo_id, tr.nombre_tipo, tr.electronico
                    ORDER BY tr.tipo_id;", conn);

                cmd.Parameters.AddWithValue("@nombre", $"%{txtTipoNombre.Text}%");

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvTipoRep.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron tipos de repuestos con ese nombre.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

    }
}
