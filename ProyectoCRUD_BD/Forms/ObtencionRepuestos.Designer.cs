namespace ProyectoCRUD_BD.Forms
{
    partial class ObtencionRepuestos
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
            btnMostrarObtencion = new Button();
            btnActualizarObtencion = new Button();
            btnBuscarObtencion = new Button();
            btnEliminarObtencion = new Button();
            dgvObtencion = new DataGridView();
            btnIngresoObtencion = new Button();
            txtRepID = new TextBox();
            label2 = new Label();
            txtObtencionID = new TextBox();
            label1 = new Label();
            txtProovedorID = new TextBox();
            label5 = new Label();
            txtOrigen = new TextBox();
            label6 = new Label();
            txtDocComp = new TextBox();
            label3 = new Label();
            textCantidadObRe = new TextBox();
            txtCant = new Label();
            txtCostoUnitario = new TextBox();
            label4 = new Label();
            dtpFechaObtencion = new DateTimePicker();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvObtencion).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarObtencion
            // 
            btnMostrarObtencion.Location = new Point(229, 173);
            btnMostrarObtencion.Margin = new Padding(3, 4, 3, 4);
            btnMostrarObtencion.Name = "btnMostrarObtencion";
            btnMostrarObtencion.Size = new Size(153, 40);
            btnMostrarObtencion.TabIndex = 93;
            btnMostrarObtencion.Text = "MOSTRAR TODOS";
            btnMostrarObtencion.UseVisualStyleBackColor = true;
            btnMostrarObtencion.Click += btnMostrarObtencion_Click;
            // 
            // btnActualizarObtencion
            // 
            btnActualizarObtencion.Location = new Point(423, 221);
            btnActualizarObtencion.Margin = new Padding(3, 4, 3, 4);
            btnActualizarObtencion.Name = "btnActualizarObtencion";
            btnActualizarObtencion.Size = new Size(153, 40);
            btnActualizarObtencion.TabIndex = 92;
            btnActualizarObtencion.Text = "ACTUALIZAR DATOS";
            btnActualizarObtencion.UseVisualStyleBackColor = true;
            btnActualizarObtencion.Click += btnActualizarObtencion_Click;
            // 
            // btnBuscarObtencion
            // 
            btnBuscarObtencion.Location = new Point(37, 173);
            btnBuscarObtencion.Margin = new Padding(3, 4, 3, 4);
            btnBuscarObtencion.Name = "btnBuscarObtencion";
            btnBuscarObtencion.Size = new Size(153, 40);
            btnBuscarObtencion.TabIndex = 91;
            btnBuscarObtencion.Text = "BUSCAR";
            btnBuscarObtencion.UseVisualStyleBackColor = true;
            btnBuscarObtencion.Click += btnBuscarObtencion_Click;
            // 
            // btnEliminarObtencion
            // 
            btnEliminarObtencion.Location = new Point(229, 221);
            btnEliminarObtencion.Margin = new Padding(3, 4, 3, 4);
            btnEliminarObtencion.Name = "btnEliminarObtencion";
            btnEliminarObtencion.Size = new Size(153, 40);
            btnEliminarObtencion.TabIndex = 90;
            btnEliminarObtencion.Text = "ELIMINAR";
            btnEliminarObtencion.UseVisualStyleBackColor = true;
            btnEliminarObtencion.Click += btnEliminarObtencion_Click;
            // 
            // dgvObtencion
            // 
            dgvObtencion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObtencion.Location = new Point(37, 282);
            dgvObtencion.Margin = new Padding(3, 4, 3, 4);
            dgvObtencion.Name = "dgvObtencion";
            dgvObtencion.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvObtencion.Size = new Size(768, 241);
            dgvObtencion.TabIndex = 89;
            // 
            // btnIngresoObtencion
            // 
            btnIngresoObtencion.Location = new Point(37, 221);
            btnIngresoObtencion.Margin = new Padding(3, 4, 3, 4);
            btnIngresoObtencion.Name = "btnIngresoObtencion";
            btnIngresoObtencion.Size = new Size(153, 40);
            btnIngresoObtencion.TabIndex = 88;
            btnIngresoObtencion.Text = "INGRESAR";
            btnIngresoObtencion.UseVisualStyleBackColor = true;
            btnIngresoObtencion.Click += btnIngresoObtencion_Click;
            // 
            // txtRepID
            // 
            txtRepID.Location = new Point(228, 33);
            txtRepID.Margin = new Padding(3, 4, 3, 4);
            txtRepID.Name = "txtRepID";
            txtRepID.Size = new Size(115, 27);
            txtRepID.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 9);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 82;
            label2.Text = "ID del Repuesto";
            // 
            // txtObtencionID
            // 
            txtObtencionID.Location = new Point(37, 33);
            txtObtencionID.Margin = new Padding(3, 4, 3, 4);
            txtObtencionID.Name = "txtObtencionID";
            txtObtencionID.Size = new Size(157, 27);
            txtObtencionID.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 80;
            label1.Text = "Numero de Obtencion";
            // 
            // txtProovedorID
            // 
            txtProovedorID.Location = new Point(373, 33);
            txtProovedorID.Margin = new Padding(3, 4, 3, 4);
            txtProovedorID.Name = "txtProovedorID";
            txtProovedorID.Size = new Size(122, 27);
            txtProovedorID.TabIndex = 95;
            //txtProovedorID.TextChanged += txtProovedorID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 9);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 94;
            label5.Text = "ID del Proovedor";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(538, 33);
            txtOrigen.Margin = new Padding(3, 4, 3, 4);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(176, 27);
            txtOrigen.TabIndex = 97;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 9);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 96;
            label6.Text = "Origen";
            // 
            // txtDocComp
            // 
            txtDocComp.Location = new Point(37, 107);
            txtDocComp.Margin = new Padding(3, 4, 3, 4);
            txtDocComp.Name = "txtDocComp";
            txtDocComp.Size = new Size(192, 27);
            txtDocComp.TabIndex = 99;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 83);
            label3.Name = "label3";
            label3.Size = new Size(192, 20);
            label3.TabIndex = 98;
            label3.Text = "Documentacion de Compra";
            // 
            // textCantidadObRe
            // 
            textCantidadObRe.Location = new Point(266, 107);
            textCantidadObRe.Margin = new Padding(3, 4, 3, 4);
            textCantidadObRe.Name = "textCantidadObRe";
            textCantidadObRe.Size = new Size(115, 27);
            textCantidadObRe.TabIndex = 101;
            textCantidadObRe.TextChanged += textCantidadObRe_TextChanged_1;
            // 
            // txtCant
            // 
            txtCant.AutoSize = true;
            txtCant.Location = new Point(266, 83);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(69, 20);
            txtCant.TabIndex = 100;
            txtCant.Text = "Cantidad";
            // 
            // txtCostoUnitario
            // 
            txtCostoUnitario.Location = new Point(422, 107);
            txtCostoUnitario.Margin = new Padding(3, 4, 3, 4);
            txtCostoUnitario.Name = "txtCostoUnitario";
            txtCostoUnitario.Size = new Size(115, 27);
            txtCostoUnitario.TabIndex = 103;
            txtCostoUnitario.TextChanged += txtCostoUnitario_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 83);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 102;
            label4.Text = "Costo Unitario";
            // 
            // dtpFechaObtencion
            // 
            dtpFechaObtencion.Location = new Point(594, 108);
            dtpFechaObtencion.Margin = new Padding(3, 4, 3, 4);
            dtpFechaObtencion.Name = "dtpFechaObtencion";
            dtpFechaObtencion.Size = new Size(286, 27);
            dtpFechaObtencion.TabIndex = 105;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 84);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 104;
            label7.Text = "Fecha de Obtencion";
            // 
            // ObtencionRepuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 549);
            Controls.Add(dtpFechaObtencion);
            Controls.Add(label7);
            Controls.Add(txtCostoUnitario);
            Controls.Add(label4);
            Controls.Add(textCantidadObRe);
            Controls.Add(txtCant);
            Controls.Add(txtDocComp);
            Controls.Add(label3);
            Controls.Add(txtOrigen);
            Controls.Add(label6);
            Controls.Add(txtProovedorID);
            Controls.Add(label5);
            Controls.Add(btnMostrarObtencion);
            Controls.Add(btnActualizarObtencion);
            Controls.Add(btnBuscarObtencion);
            Controls.Add(btnEliminarObtencion);
            Controls.Add(dgvObtencion);
            Controls.Add(btnIngresoObtencion);
            Controls.Add(txtRepID);
            Controls.Add(label2);
            Controls.Add(txtObtencionID);
            Controls.Add(label1);
            Name = "ObtencionRepuestos";
            Text = "ObtencionRepuestos";
            ((System.ComponentModel.ISupportInitialize)dgvObtencion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarRepUsa;
        private Button btnActualizarRepUsa;
        private Button btnBuscarRepUsa;
        private Button btnEliminarRepUsa;
        private DataGridView dgvRepUsa;
        private Button btnIngresoObtencion;
        private TextBox txtRepID;
        private Label label2;
        private TextBox txtObtencionID;
        private Label label1;
        private TextBox txtProovedorID;
        private Label label5;
        private TextBox txtOrigen;
        private Label label6;
        private TextBox txtDocComp;
        private Label label3;
        private TextBox textCantidadObRe;
        private Label txtCant;
        private TextBox txtCostoUnitario;
        private Label label4;
        private DateTimePicker dtpFechaObtencion;
        private Label label7;
        private Button btnMostrarObtencion;
        private Button btnActualizarObtencion;
        private Button btnBuscarObtencion;
        private Button btnEliminarObtencion;
        private DataGridView dgvObtencion;
    }
}