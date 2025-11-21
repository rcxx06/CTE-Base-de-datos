namespace ProyectoCRUD_BD.Forms
{
    partial class Ordenes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            txtOrdenID = new TextBox();
            label2 = new Label();
            txtDiagnosticoID = new TextBox();
            label3 = new Label();
            txtTecnicoID = new TextBox();
            label4 = new Label();
            txtPrioridad = new TextBox();
            label5 = new Label();
            txtEstado = new TextBox();
            label6 = new Label();
            dtpFechaIngreso = new DateTimePicker();
            label7 = new Label();
            txtTipoElectronico = new TextBox();
            btnIngresoOrden = new Button();
            dgvOrdenes = new DataGridView();
            btnEliminarOrden = new Button();
            btnBuscarOrden = new Button();
            btnActualizarOrden = new Button();
            btnMostrarOrdenes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 34);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de Orden";
            // 
            // txtOrdenID
            // 
            txtOrdenID.Location = new Point(50, 58);
            txtOrdenID.Margin = new Padding(3, 4, 3, 4);
            txtOrdenID.Name = "txtOrdenID";
            txtOrdenID.Size = new Size(141, 27);
            txtOrdenID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 34);
            label2.Name = "label2";
            label2.Size = new Size(168, 20);
            label2.TabIndex = 2;
            label2.Text = "Numero de Diagnostico";
            // 
            // txtDiagnosticoID
            // 
            txtDiagnosticoID.Location = new Point(242, 58);
            txtDiagnosticoID.Margin = new Padding(3, 4, 3, 4);
            txtDiagnosticoID.Name = "txtDiagnosticoID";
            txtDiagnosticoID.Size = new Size(168, 27);
            txtDiagnosticoID.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 34);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 4;
            label3.Text = "ID del tecnico";
            // 
            // txtTecnicoID
            // 
            txtTecnicoID.Location = new Point(477, 58);
            txtTecnicoID.Margin = new Padding(3, 4, 3, 4);
            txtTecnicoID.Name = "txtTecnicoID";
            txtTecnicoID.Size = new Size(141, 27);
            txtTecnicoID.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(693, 34);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 6;
            label4.Text = "Prioridad";
            // 
            // txtPrioridad
            // 
            txtPrioridad.Location = new Point(693, 58);
            txtPrioridad.Margin = new Padding(3, 4, 3, 4);
            txtPrioridad.Name = "txtPrioridad";
            txtPrioridad.Size = new Size(141, 27);
            txtPrioridad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 114);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 8;
            label5.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(302, 138);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(168, 27);
            txtEstado.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(535, 114);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 10;
            label6.Text = "Fecha de ingreso";
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(535, 138);
            dtpFechaIngreso.Margin = new Padding(3, 4, 3, 4);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(228, 27);
            dtpFechaIngreso.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 114);
            label7.Name = "label7";
            label7.Size = new Size(117, 20);
            label7.TabIndex = 12;
            label7.Text = "Tipo Electronico";
            // 
            // txtTipoElectronico
            // 
            txtTipoElectronico.Location = new Point(50, 138);
            txtTipoElectronico.Margin = new Padding(3, 4, 3, 4);
            txtTipoElectronico.Name = "txtTipoElectronico";
            txtTipoElectronico.Size = new Size(198, 27);
            txtTipoElectronico.TabIndex = 13;
            // 
            // btnIngresoOrden
            // 
            btnIngresoOrden.Location = new Point(50, 284);
            btnIngresoOrden.Margin = new Padding(3, 4, 3, 4);
            btnIngresoOrden.Name = "btnIngresoOrden";
            btnIngresoOrden.Size = new Size(153, 40);
            btnIngresoOrden.TabIndex = 14;
            btnIngresoOrden.Text = "INGRESAR";
            btnIngresoOrden.UseVisualStyleBackColor = true;
            btnIngresoOrden.Click += btnIngresoOrden_Click;
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(50, 385);
            dgvOrdenes.Margin = new Padding(3, 4, 3, 4);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvOrdenes.Size = new Size(768, 241);
            dgvOrdenes.TabIndex = 15;
            // 
            // btnEliminarOrden
            // 
            btnEliminarOrden.Location = new Point(242, 284);
            btnEliminarOrden.Margin = new Padding(3, 4, 3, 4);
            btnEliminarOrden.Name = "btnEliminarOrden";
            btnEliminarOrden.Size = new Size(153, 40);
            btnEliminarOrden.TabIndex = 16;
            btnEliminarOrden.Text = "ELIMINAR";
            btnEliminarOrden.UseVisualStyleBackColor = true;
            btnEliminarOrden.Click += btnEliminarOrden_Click;
            // 
            // btnBuscarOrden
            // 
            btnBuscarOrden.Location = new Point(50, 214);
            btnBuscarOrden.Margin = new Padding(3, 4, 3, 4);
            btnBuscarOrden.Name = "btnBuscarOrden";
            btnBuscarOrden.Size = new Size(153, 40);
            btnBuscarOrden.TabIndex = 17;
            btnBuscarOrden.Text = "BUSCAR";
            btnBuscarOrden.UseVisualStyleBackColor = true;
            btnBuscarOrden.Click += btnBuscarOrden_Click;
            // 
            // btnActualizarOrden
            // 
            btnActualizarOrden.Location = new Point(456, 284);
            btnActualizarOrden.Margin = new Padding(3, 4, 3, 4);
            btnActualizarOrden.Name = "btnActualizarOrden";
            btnActualizarOrden.Size = new Size(153, 40);
            btnActualizarOrden.TabIndex = 18;
            btnActualizarOrden.Text = "ACTUALIZAR DATOS";
            btnActualizarOrden.UseVisualStyleBackColor = true;
            btnActualizarOrden.Click += btnActualizarOrden_Click;
            // 
            // btnMostrarOrdenes
            // 
            btnMostrarOrdenes.Location = new Point(242, 214);
            btnMostrarOrdenes.Margin = new Padding(3, 4, 3, 4);
            btnMostrarOrdenes.Name = "btnMostrarOrdenes";
            btnMostrarOrdenes.Size = new Size(153, 40);
            btnMostrarOrdenes.TabIndex = 19;
            btnMostrarOrdenes.Text = "MOSTRAR TODOS";
            btnMostrarOrdenes.UseVisualStyleBackColor = true;
            btnMostrarOrdenes.Click += btnMostrarOrdenes_Click;
            // 
            // Ordenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            Controls.Add(btnMostrarOrdenes);
            Controls.Add(btnActualizarOrden);
            Controls.Add(btnBuscarOrden);
            Controls.Add(btnEliminarOrden);
            Controls.Add(dgvOrdenes);
            Controls.Add(btnIngresoOrden);
            Controls.Add(txtTipoElectronico);
            Controls.Add(label7);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(label6);
            Controls.Add(txtEstado);
            Controls.Add(label5);
            Controls.Add(txtPrioridad);
            Controls.Add(label4);
            Controls.Add(txtTecnicoID);
            Controls.Add(label3);
            Controls.Add(txtDiagnosticoID);
            Controls.Add(label2);
            Controls.Add(txtOrdenID);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ordenes";
            Text = "Ordenes";
            Load += Ordenes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrdenID;
        private Label label2;
        private TextBox txtDiagnosticoID;
        private Label label3;
        private TextBox txtTecnicoID;
        private Label label4;
        private TextBox txtPrioridad;
        private Label label5;
        private TextBox txtEstado;
        private Label label6;
        private DateTimePicker dtpFechaIngreso;
        private Label label7;
        private TextBox txtTipoElectronico;
        private Button btnIngresoOrden;
        private DataGridView dgvOrdenes;
        private Button btnEliminarOrden;
        private Button btnBuscarOrden;
        private Button btnActualizarOrden;
        private Button btnMostrarOrdenes;
    }
}
