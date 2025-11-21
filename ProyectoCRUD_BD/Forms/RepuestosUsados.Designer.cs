namespace ProyectoCRUD_BD.Forms
{
    partial class RepuestosUsados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrarRepUsa = new Button();
            btnActualizarRepUsa = new Button();
            btnBuscarRepUsa = new Button();
            btnEliminarRepUsa = new Button();
            dgvRepUsa = new DataGridView();
            btnIngresoRepUsa = new Button();
            txtCantidadUsada = new TextBox();
            label4 = new Label();
            txtRepuestoID = new TextBox();
            label3 = new Label();
            txtFacturaID = new TextBox();
            label2 = new Label();
            txtRepUsaID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRepUsa).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarRepUsa
            // 
            btnMostrarRepUsa.Location = new Point(666, 64);
            btnMostrarRepUsa.Margin = new Padding(3, 4, 3, 4);
            btnMostrarRepUsa.Name = "btnMostrarRepUsa";
            btnMostrarRepUsa.Size = new Size(153, 40);
            btnMostrarRepUsa.TabIndex = 79;
            btnMostrarRepUsa.Text = "MOSTRAR TODOS";
            btnMostrarRepUsa.UseVisualStyleBackColor = true;
            btnMostrarRepUsa.Click += btnMostrarRepUsa_Click;
            // 
            // btnActualizarRepUsa
            // 
            btnActualizarRepUsa.Location = new Point(347, 227);
            btnActualizarRepUsa.Margin = new Padding(3, 4, 3, 4);
            btnActualizarRepUsa.Name = "btnActualizarRepUsa";
            btnActualizarRepUsa.Size = new Size(153, 40);
            btnActualizarRepUsa.TabIndex = 78;
            btnActualizarRepUsa.Text = "ACTUALIZAR DATOS";
            btnActualizarRepUsa.UseVisualStyleBackColor = true;
            btnActualizarRepUsa.Click += btnActualizarRepUsa_Click;
            // 
            // btnBuscarRepUsa
            // 
            btnBuscarRepUsa.Location = new Point(474, 64);
            btnBuscarRepUsa.Margin = new Padding(3, 4, 3, 4);
            btnBuscarRepUsa.Name = "btnBuscarRepUsa";
            btnBuscarRepUsa.Size = new Size(153, 40);
            btnBuscarRepUsa.TabIndex = 77;
            btnBuscarRepUsa.Text = "BUSCAR";
            btnBuscarRepUsa.UseVisualStyleBackColor = true;
            btnBuscarRepUsa.Click += btnBuscarRepUsa_Click;
            // 
            // btnEliminarRepUsa
            // 
            btnEliminarRepUsa.Location = new Point(666, 134);
            btnEliminarRepUsa.Margin = new Padding(3, 4, 3, 4);
            btnEliminarRepUsa.Name = "btnEliminarRepUsa";
            btnEliminarRepUsa.Size = new Size(153, 40);
            btnEliminarRepUsa.TabIndex = 76;
            btnEliminarRepUsa.Text = "ELIMINAR";
            btnEliminarRepUsa.UseVisualStyleBackColor = true;
            btnEliminarRepUsa.Click += btnEliminarRepUsa_Click;
            // 
            // dgvRepUsa
            // 
            dgvRepUsa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepUsa.Location = new Point(36, 320);
            dgvRepUsa.Margin = new Padding(3, 4, 3, 4);
            dgvRepUsa.Name = "dgvRepUsa";
            dgvRepUsa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvRepUsa.Size = new Size(768, 241);
            dgvRepUsa.TabIndex = 75;
            // 
            // btnIngresoRepUsa
            // 
            btnIngresoRepUsa.Location = new Point(474, 134);
            btnIngresoRepUsa.Margin = new Padding(3, 4, 3, 4);
            btnIngresoRepUsa.Name = "btnIngresoRepUsa";
            btnIngresoRepUsa.Size = new Size(153, 40);
            btnIngresoRepUsa.TabIndex = 74;
            btnIngresoRepUsa.Text = "INGRESAR";
            btnIngresoRepUsa.UseVisualStyleBackColor = true;
            btnIngresoRepUsa.Click += btnIngresoRepUsa_Click;
            // 
            // txtCantidadUsada
            // 
            txtCantidadUsada.Location = new Point(249, 144);
            txtCantidadUsada.Margin = new Padding(3, 4, 3, 4);
            txtCantidadUsada.Name = "txtCantidadUsada";
            txtCantidadUsada.Size = new Size(115, 27);
            txtCantidadUsada.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(249, 120);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 70;
            label4.Text = "Cantidad Usada";
            // 
            // txtRepuestoID
            // 
            txtRepuestoID.Location = new Point(35, 144);
            txtRepuestoID.Margin = new Padding(3, 4, 3, 4);
            txtRepuestoID.Name = "txtRepuestoID";
            txtRepuestoID.Size = new Size(197, 27);
            txtRepuestoID.TabIndex = 69;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 120);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 68;
            label3.Text = "ID del Repuesto";
            // 
            // txtFacturaID
            // 
            txtFacturaID.Location = new Point(249, 77);
            txtFacturaID.Margin = new Padding(3, 4, 3, 4);
            txtFacturaID.Name = "txtFacturaID";
            txtFacturaID.Size = new Size(168, 27);
            txtFacturaID.TabIndex = 67;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 53);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 66;
            label2.Text = "Numero de la Factura";
            // 
            // txtRepUsaID
            // 
            txtRepUsaID.Location = new Point(36, 77);
            txtRepUsaID.Margin = new Padding(3, 4, 3, 4);
            txtRepUsaID.Name = "txtRepUsaID";
            txtRepUsaID.Size = new Size(197, 27);
            txtRepUsaID.TabIndex = 65;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 53);
            label1.Name = "label1";
            label1.Size = new Size(196, 20);
            label1.TabIndex = 64;
            label1.Text = "Numero de Repuesto Usado";
            // 
            // RepuestosUsados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 638);
            Controls.Add(btnMostrarRepUsa);
            Controls.Add(btnActualizarRepUsa);
            Controls.Add(btnBuscarRepUsa);
            Controls.Add(btnEliminarRepUsa);
            Controls.Add(dgvRepUsa);
            Controls.Add(btnIngresoRepUsa);
            Controls.Add(txtCantidadUsada);
            Controls.Add(label4);
            Controls.Add(txtRepuestoID);
            Controls.Add(label3);
            Controls.Add(txtFacturaID);
            Controls.Add(label2);
            Controls.Add(txtRepUsaID);
            Controls.Add(label1);
            Name = "RepuestosUsados";
            Text = "RepuestosUsados";
            ((System.ComponentModel.ISupportInitialize)dgvRepUsa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaVencimiento;
        private Label label5;
        private Button btnMostrarGarantia;
        private Button btnMostrarRepUsa;
        private Button btnActualizarRepUsa;
        private Button btnActualizarGarantia;
        private Button btnBuscarRepUsa;
        private Button btnEliminarRepUsa;
        private Button btnBuscarGarantia;
        private Button btnEliminarGarantia;
        private DataGridView dgvRepUsa;
        private Button btnIngresoRepUsa;
        private TextBox txtCantidadUsada;
        private DateTimePicker dtpFechaInicio;
        private Label label6;
        private TextBox txtMetodoPago;
        private Label label4;
        private TextBox txtRepuestoID;
        private TextBox txtCondiciones;
        private Label label3;
        private TextBox txtFacturaID;
        private Label label2;
        private TextBox txtRepUsaID;
        private Label label1;
        private DateTimePicker dtpFechaInicioG;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpFechaVencimientoG;
    }
}