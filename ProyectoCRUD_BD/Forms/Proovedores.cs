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
    public partial class Proovedores : Form
    {

        public Proovedores()
        {
            InitializeComponent();
            CargarProveedores();
            UIStyles.ApplyAllStyles(this);
        }

        private SqlConnection GetConnection()
        {
            return SQLCONECTION.GetConnection();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProveedorID.Text, out int proveedorId))
            {
                MessageBox.Show("Ingrese un ID de proveedor válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Proveedores WHERE proveedor_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", proveedorId);

            using var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvProveedores.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                txtNombreProvee.Text = dt.Rows[0]["nombre"].ToString();
                txtTelefonoProvee.Text = dt.Rows[0]["telefono"].ToString();
                txtDirProvee.Text = dt.Rows[0]["direccion"].ToString();
                txtCorreoProvee.Text = dt.Rows[0]["correo"].ToString();
            }
            else
            {
                MessageBox.Show("Proveedor no encontrado.");
                LimpiarCampos();
            }
        }

        private void btnMostrarProveedor_Click(object sender, EventArgs e)
        {
            CargarProveedores();
            LimpiarCampos();
        }

        private void btnIngresoProveedor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProveedorID.Text, out int proveedorId))
            {
                MessageBox.Show("Ingrese un ID de proveedor válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProvee.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Validar ID único
            var check = new SqlCommand("SELECT COUNT(*) FROM Proveedores WHERE proveedor_id = @id;", conn);
            check.Parameters.AddWithValue("@id", proveedorId);
            int count = (int)check.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("El ID de proveedor ya existe. Ingrese otro.");
                return;
            }

            var cmd = new SqlCommand(@"
                INSERT INTO Proveedores 
                (proveedor_id, nombre, telefono, direccion, correo)
                VALUES
                (@id, @nombre, @telefono, @direccion, @correo);", conn);

            cmd.Parameters.AddWithValue("@id", proveedorId);
            cmd.Parameters.AddWithValue("@nombre", txtNombreProvee.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTelefonoProvee.Text ?? "");
            cmd.Parameters.AddWithValue("@direccion", txtDirProvee.Text ?? "");
            cmd.Parameters.AddWithValue("@correo", txtCorreoProvee.Text ?? "");

            cmd.ExecuteNonQuery();

            MessageBox.Show("Proveedor ingresado exitosamente.");
            CargarProveedores();
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProveedorID.Text, out int proveedorId))
            {
                MessageBox.Show("Ingrese un ID de proveedor válido.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            // Verificar si el proveedor tiene obtenciones de repuestos asociadas
            var checkObtenciones = new SqlCommand("SELECT COUNT(*) FROM Obtencion_Repuestos WHERE proveedor_id = @id;", conn);
            checkObtenciones.Parameters.AddWithValue("@id", proveedorId);
            int countObtenciones = (int)checkObtenciones.ExecuteScalar();

            if (countObtenciones > 0)
            {
                MessageBox.Show("No se puede eliminar el proveedor porque tiene obtenciones de repuestos asociadas.");
                return;
            }

            var cmd = new SqlCommand("DELETE FROM Proveedores WHERE proveedor_id = @id;", conn);
            cmd.Parameters.AddWithValue("@id", proveedorId);

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
                MessageBox.Show("Proveedor eliminado.");
            else
                MessageBox.Show("No existe un proveedor con ese ID.");

            CargarProveedores();
            LimpiarCampos();
        }

        private void btnActualizarProveedor_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProveedorID.Text, out int proveedorId))
            {
                MessageBox.Show("Ingrese un ID de proveedor válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProvee.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor.");
                return;
            }

            using var conn = GetConnection();
            conn.Open();

            var cmd = new SqlCommand(@"
                UPDATE Proveedores
                SET nombre = @nombre,
                    telefono = @telefono,
                    direccion = @direccion,
                    correo = @correo
                WHERE proveedor_id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", proveedorId);
            cmd.Parameters.AddWithValue("@nombre", txtNombreProvee.Text);
            cmd.Parameters.AddWithValue("@telefono", txtTelefonoProvee.Text ?? "");
            cmd.Parameters.AddWithValue("@direccion", txtDirProvee.Text ?? "");
            cmd.Parameters.AddWithValue("@correo", txtCorreoProvee.Text ?? "");

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show("Proveedor actualizado exitosamente.");
                CargarProveedores();
            }
            else
            {
                MessageBox.Show("No se encontró el proveedor con ese ID.");
            }
        }

        private void CargarProveedores()
        {
            try
            {
                using var conn = GetConnection();
                conn.Open();

                var cmd = new SqlCommand("SELECT * FROM Proveedores ORDER BY proveedor_id;", conn);

                using var reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvProveedores.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            txtProveedorID.Clear();
            txtNombreProvee.Clear();
            txtTelefonoProvee.Clear();
            txtDirProvee.Clear();
            txtCorreoProvee.Clear();
        }

        private void Proovedores_Load_1(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}
