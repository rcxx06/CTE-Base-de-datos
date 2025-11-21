namespace ProyectoCRUD_BD.Forms
{
    partial class Garantias
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
            label8 = new Label();
            dtpFechaVencimientoG = new DateTimePicker();
            label7 = new Label();
            dtpFechaInicioG = new DateTimePicker();
            btnMostrarGarantia = new Button();
            btnActualizarGarantia = new Button();
            btnBuscarGarantia = new Button();
            btnEliminarGarantia = new Button();
            dgvGarantias = new DataGridView();
            btnIngresoGarantia = new Button();
            txtDuracionMeses = new TextBox();
            label4 = new Label();
            txtCondiciones = new TextBox();
            label3 = new Label();
            txtFacturaID = new TextBox();
            label2 = new Label();
            txtGarantiaID = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGarantias).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(545, 75);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 101;
            label8.Text = "Fecha de Vencimiento";
            // 
            // dtpFechaVencimientoG
            // 
            dtpFechaVencimientoG.Location = new Point(545, 99);
            dtpFechaVencimientoG.Margin = new Padding(3, 4, 3, 4);
            dtpFechaVencimientoG.Name = "dtpFechaVencimientoG";
            dtpFechaVencimientoG.Size = new Size(278, 27);
            dtpFechaVencimientoG.TabIndex = 100;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(545, 8);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 99;
            label7.Text = "Fecha de Inicio";
            // 
            // dtpFechaInicioG
            // 
            dtpFechaInicioG.Location = new Point(545, 32);
            dtpFechaInicioG.Margin = new Padding(3, 4, 3, 4);
            dtpFechaInicioG.Name = "dtpFechaInicioG";
            dtpFechaInicioG.Size = new Size(278, 27);
            dtpFechaInicioG.TabIndex = 98;
            dtpFechaInicioG.ValueChanged += dtpFechaInicioG_ValueChanged_1;
            // 
            // btnMostrarGarantia
            // 
            btnMostrarGarantia.Location = new Point(247, 188);
            btnMostrarGarantia.Margin = new Padding(3, 4, 3, 4);
            btnMostrarGarantia.Name = "btnMostrarGarantia";
            btnMostrarGarantia.Size = new Size(153, 40);
            btnMostrarGarantia.TabIndex = 97;
            btnMostrarGarantia.Text = "MOSTRAR TODOS";
            btnMostrarGarantia.UseVisualStyleBackColor = true;
            btnMostrarGarantia.Click += btnMostrarGarantia_Click;
            // 
            // btnActualizarGarantia
            // 
            btnActualizarGarantia.Location = new Point(441, 258);
            btnActualizarGarantia.Margin = new Padding(3, 4, 3, 4);
            btnActualizarGarantia.Name = "btnActualizarGarantia";
            btnActualizarGarantia.Size = new Size(153, 40);
            btnActualizarGarantia.TabIndex = 96;
            btnActualizarGarantia.Text = "ACTUALIZAR DATOS";
            btnActualizarGarantia.UseVisualStyleBackColor = true;
            btnActualizarGarantia.Click += btnActualizarGarantia_Click;
            // 
            // btnBuscarGarantia
            // 
            btnBuscarGarantia.Location = new Point(55, 188);
            btnBuscarGarantia.Margin = new Padding(3, 4, 3, 4);
            btnBuscarGarantia.Name = "btnBuscarGarantia";
            btnBuscarGarantia.Size = new Size(153, 40);
            btnBuscarGarantia.TabIndex = 95;
            btnBuscarGarantia.Text = "BUSCAR";
            btnBuscarGarantia.UseVisualStyleBackColor = true;
            btnBuscarGarantia.Click += btnBuscarGarantia_Click;
            // 
            // btnEliminarGarantia
            // 
            btnEliminarGarantia.Location = new Point(247, 258);
            btnEliminarGarantia.Margin = new Padding(3, 4, 3, 4);
            btnEliminarGarantia.Name = "btnEliminarGarantia";
            btnEliminarGarantia.Size = new Size(153, 40);
            btnEliminarGarantia.TabIndex = 94;
            btnEliminarGarantia.Text = "ELIMINAR";
            btnEliminarGarantia.UseVisualStyleBackColor = true;
            btnEliminarGarantia.Click += btnEliminarGarantia_Click;
            // 
            // dgvGarantias
            // 
            dgvGarantias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGarantias.Location = new Point(40, 315);
            dgvGarantias.Margin = new Padding(3, 4, 3, 4);
            dgvGarantias.Name = "dgvGarantias";
            dgvGarantias.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvGarantias.Size = new Size(768, 241);
            dgvGarantias.TabIndex = 93;
            // 
            // btnIngresoGarantia
            // 
            btnIngresoGarantia.Location = new Point(55, 258);
            btnIngresoGarantia.Margin = new Padding(3, 4, 3, 4);
            btnIngresoGarantia.Name = "btnIngresoGarantia";
            btnIngresoGarantia.Size = new Size(153, 40);
            btnIngresoGarantia.TabIndex = 92;
            btnIngresoGarantia.Text = "INGRESAR";
            btnIngresoGarantia.UseVisualStyleBackColor = true;
            btnIngresoGarantia.Click += btnIngresoGarantia_Click;
            // 
            // txtDuracionMeses
            // 
            txtDuracionMeses.Location = new Point(368, 99);
            txtDuracionMeses.Margin = new Padding(3, 4, 3, 4);
            txtDuracionMeses.Name = "txtDuracionMeses";
            txtDuracionMeses.Size = new Size(115, 27);
            txtDuracionMeses.TabIndex = 91;
            txtDuracionMeses.TextChanged += txtDuracionMeses_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 75);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 90;
            label4.Text = "Duracion de meses";
            // 
            // txtCondiciones
            // 
            txtCondiciones.Location = new Point(55, 99);
            txtCondiciones.Margin = new Padding(3, 4, 3, 4);
            txtCondiciones.Name = "txtCondiciones";
            txtCondiciones.Size = new Size(264, 27);
            txtCondiciones.TabIndex = 89;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 75);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 88;
            label3.Text = "Condiciones";
            // 
            // txtFacturaID
            // 
            txtFacturaID.Location = new Point(315, 32);
            txtFacturaID.Margin = new Padding(3, 4, 3, 4);
            txtFacturaID.Name = "txtFacturaID";
            txtFacturaID.Size = new Size(168, 27);
            txtFacturaID.TabIndex = 87;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 8);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 86;
            label2.Text = "Numero de la Factura";
            // 
            // txtGarantiaID
            // 
            txtGarantiaID.Location = new Point(56, 32);
            txtGarantiaID.Margin = new Padding(3, 4, 3, 4);
            txtGarantiaID.Name = "txtGarantiaID";
            txtGarantiaID.Size = new Size(197, 27);
            txtGarantiaID.TabIndex = 85;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 8);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 84;
            label1.Text = "Numero de Garantia";
            // 
            // Garantias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 609);
            Controls.Add(label8);
            Controls.Add(dtpFechaVencimientoG);
            Controls.Add(label7);
            Controls.Add(dtpFechaInicioG);
            Controls.Add(btnMostrarGarantia);
            Controls.Add(btnActualizarGarantia);
            Controls.Add(btnBuscarGarantia);
            Controls.Add(btnEliminarGarantia);
            Controls.Add(dgvGarantias);
            Controls.Add(btnIngresoGarantia);
            Controls.Add(txtDuracionMeses);
            Controls.Add(label4);
            Controls.Add(txtCondiciones);
            Controls.Add(label3);
            Controls.Add(txtFacturaID);
            Controls.Add(label2);
            Controls.Add(txtGarantiaID);
            Controls.Add(label1);
            Name = "Garantias";
            Text = "Garantias";
            Load += Garantias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGarantias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Label label8;
        private TextBox txtImpuestos;
        private Label label5;
        private TextBox txtSubtotal;
        private Label label7;
        private DateTimePicker dtpFechaVencimientoG;
        private DateTimePicker dtpFechaInicioG;
        private Button btnMostrarGarantia;
        private Button btnActualizarGarantia;
        private Button btnBuscarGarantia;
        private Button btnEliminarGarantia;
        private DataGridView dgvGarantias;
        private Button btnIngresoGarantia;
        private TextBox txtDuracionMeses;
        private Label label4;
        private TextBox txtCondiciones;
        private Label label3;
        private TextBox txtFacturaID;
        private Label label2;
        private TextBox txtGarantiaID;
        private Label label1;
    }
}