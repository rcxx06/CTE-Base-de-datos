namespace ProyectoCRUD_BD.Forms
{
    partial class Facturas
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
            txtTotal = new TextBox();
            label8 = new Label();
            txtImpuestos = new TextBox();
            label5 = new Label();
            btnMostrarFacturas = new Button();
            btnActualizarFactura = new Button();
            btnBuscarFactura = new Button();
            btnEliminarFactura = new Button();
            dgvFacturas = new DataGridView();
            btnIngresoFactura = new Button();
            txtSubtotal = new TextBox();
            label7 = new Label();
            dtpFechaEmision = new DateTimePicker();
            label6 = new Label();
            txtMetodoPago = new TextBox();
            label4 = new Label();
            txtEstadoPago = new TextBox();
            label3 = new Label();
            txtOrdenID = new TextBox();
            label2 = new Label();
            txtFacturaID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(385, 113);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(90, 27);
            txtTotal.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 89);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 86;
            label8.Text = "Total";
            // 
            // txtImpuestos
            // 
            txtImpuestos.Location = new Point(236, 113);
            txtImpuestos.Margin = new Padding(3, 4, 3, 4);
            txtImpuestos.Name = "txtImpuestos";
            txtImpuestos.Size = new Size(90, 27);
            txtImpuestos.TabIndex = 85;
            txtImpuestos.TextChanged += txtImpuestos_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 89);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 84;
            label5.Text = "Impuestos";
            // 
            // btnMostrarFacturas
            // 
            btnMostrarFacturas.Location = new Point(282, 189);
            btnMostrarFacturas.Margin = new Padding(3, 4, 3, 4);
            btnMostrarFacturas.Name = "btnMostrarFacturas";
            btnMostrarFacturas.Size = new Size(153, 40);
            btnMostrarFacturas.TabIndex = 83;
            btnMostrarFacturas.Text = "MOSTRAR TODOS";
            btnMostrarFacturas.UseVisualStyleBackColor = true;
            btnMostrarFacturas.Click += btnMostrarFacturas_Click;
            // 
            // btnActualizarFactura
            // 
            btnActualizarFactura.Location = new Point(476, 259);
            btnActualizarFactura.Margin = new Padding(3, 4, 3, 4);
            btnActualizarFactura.Name = "btnActualizarFactura";
            btnActualizarFactura.Size = new Size(153, 40);
            btnActualizarFactura.TabIndex = 82;
            btnActualizarFactura.Text = "ACTUALIZAR DATOS";
            btnActualizarFactura.UseVisualStyleBackColor = true;
            btnActualizarFactura.Click += btnActualizarFactura_Click;
            // 
            // btnBuscarFactura
            // 
            btnBuscarFactura.Location = new Point(90, 189);
            btnBuscarFactura.Margin = new Padding(3, 4, 3, 4);
            btnBuscarFactura.Name = "btnBuscarFactura";
            btnBuscarFactura.Size = new Size(153, 40);
            btnBuscarFactura.TabIndex = 81;
            btnBuscarFactura.Text = "BUSCAR";
            btnBuscarFactura.UseVisualStyleBackColor = true;
            btnBuscarFactura.Click += btnBuscarFactura_Click;
            // 
            // btnEliminarFactura
            // 
            btnEliminarFactura.Location = new Point(282, 259);
            btnEliminarFactura.Margin = new Padding(3, 4, 3, 4);
            btnEliminarFactura.Name = "btnEliminarFactura";
            btnEliminarFactura.Size = new Size(153, 40);
            btnEliminarFactura.TabIndex = 80;
            btnEliminarFactura.Text = "ELIMINAR";
            btnEliminarFactura.UseVisualStyleBackColor = true;
            btnEliminarFactura.Click += btnEliminarFactura_Click;
            // 
            // dgvFacturas
            // 
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(90, 360);
            dgvFacturas.Margin = new Padding(3, 4, 3, 4);
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvFacturas.Size = new Size(768, 241);
            dgvFacturas.TabIndex = 79;
            // 
            // btnIngresoFactura
            // 
            btnIngresoFactura.Location = new Point(90, 259);
            btnIngresoFactura.Margin = new Padding(3, 4, 3, 4);
            btnIngresoFactura.Name = "btnIngresoFactura";
            btnIngresoFactura.Size = new Size(153, 40);
            btnIngresoFactura.TabIndex = 78;
            btnIngresoFactura.Text = "INGRESAR";
            btnIngresoFactura.UseVisualStyleBackColor = true;
            btnIngresoFactura.Click += btnIngresoFactura_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(90, 113);
            txtSubtotal.Margin = new Padding(3, 4, 3, 4);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(90, 27);
            txtSubtotal.TabIndex = 77;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 89);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 76;
            label7.Text = "Subtotal";
            // 
            // dtpFechaEmision
            // 
            dtpFechaEmision.Location = new Point(575, 113);
            dtpFechaEmision.Margin = new Padding(3, 4, 3, 4);
            dtpFechaEmision.Name = "dtpFechaEmision";
            dtpFechaEmision.Size = new Size(278, 27);
            dtpFechaEmision.TabIndex = 75;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(575, 89);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 74;
            label6.Text = "Fecha de emisión";
            // 
            // txtMetodoPago
            // 
            txtMetodoPago.Location = new Point(733, 33);
            txtMetodoPago.Margin = new Padding(3, 4, 3, 4);
            txtMetodoPago.Name = "txtMetodoPago";
            txtMetodoPago.Size = new Size(141, 27);
            txtMetodoPago.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(733, 9);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 72;
            label4.Text = "Metodo de Pago";
            // 
            // txtEstadoPago
            // 
            txtEstadoPago.Location = new Point(476, 33);
            txtEstadoPago.Margin = new Padding(3, 4, 3, 4);
            txtEstadoPago.Name = "txtEstadoPago";
            txtEstadoPago.Size = new Size(162, 27);
            txtEstadoPago.TabIndex = 71;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 9);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 70;
            label3.Text = "Estado de Pago";
            // 
            // txtOrdenID
            // 
            txtOrdenID.Location = new Point(267, 33);
            txtOrdenID.Margin = new Padding(3, 4, 3, 4);
            txtOrdenID.Name = "txtOrdenID";
            txtOrdenID.Size = new Size(168, 27);
            txtOrdenID.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 68;
            label2.Text = "Numero de la Orden";
            // 
            // txtFacturaID
            // 
            txtFacturaID.Location = new Point(90, 33);
            txtFacturaID.Margin = new Padding(3, 4, 3, 4);
            txtFacturaID.Name = "txtFacturaID";
            txtFacturaID.Size = new Size(141, 27);
            txtFacturaID.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 66;
            label1.Text = "Numero de Factura";
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 611);
            Controls.Add(txtTotal);
            Controls.Add(label8);
            Controls.Add(txtImpuestos);
            Controls.Add(label5);
            Controls.Add(btnMostrarFacturas);
            Controls.Add(btnActualizarFactura);
            Controls.Add(btnBuscarFactura);
            Controls.Add(btnEliminarFactura);
            Controls.Add(dgvFacturas);
            Controls.Add(btnIngresoFactura);
            Controls.Add(txtSubtotal);
            Controls.Add(label7);
            Controls.Add(dtpFechaEmision);
            Controls.Add(label6);
            Controls.Add(txtMetodoPago);
            Controls.Add(label4);
            Controls.Add(txtEstadoPago);
            Controls.Add(label3);
            Controls.Add(txtOrdenID);
            Controls.Add(label2);
            Controls.Add(txtFacturaID);
            Controls.Add(label1);
            Name = "Facturas";
            Text = "Facturas";
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Label label8;
        private TextBox txtImpuestos;
        private Label label5;
        private Button btnMostrarFacturas;
        private Button btnActualizarFactura;
        private Button btnBuscarFactura;
        private Button btnEliminarFactura;
        private DataGridView dgvFacturas;
        private Button btnIngresoFactura;
        private TextBox txtSubtotal;
        private Label label7;
        private DateTimePicker dtpFechaEmision;
        private Label label6;
        private TextBox txtMetodoPago;
        private Label label4;
        private TextBox txtEstadoPago;
        private Label label3;
        private TextBox txtOrdenID;
        private Label label2;
        private TextBox txtFacturaID;
        private Label label1;
    }
}