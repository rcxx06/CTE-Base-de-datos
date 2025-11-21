namespace ProyectoCRUD_BD.Forms
{
    partial class Repuestos
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
            btnMostrarRepuesto = new Button();
            btnActualizarRepuesto = new Button();
            btnBuscarRepuesto = new Button();
            btnEliminarRepuesto = new Button();
            dgvRepuesto = new DataGridView();
            btnIngresoRepuesto = new Button();
            txtRepuestoID = new TextBox();
            label1 = new Label();
            txtTipoID = new TextBox();
            label2 = new Label();
            txtUbiRep = new TextBox();
            label5 = new Label();
            txtSerie = new TextBox();
            label3 = new Label();
            txtCosto = new TextBox();
            label4 = new Label();
            txtRepNombre = new TextBox();
            label6 = new Label();
            txtDescRep = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRepuesto).BeginInit();
            SuspendLayout();
            // 
            // btnMostrarRepuesto
            // 
            btnMostrarRepuesto.Location = new Point(231, 199);
            btnMostrarRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnMostrarRepuesto.Name = "btnMostrarRepuesto";
            btnMostrarRepuesto.Size = new Size(153, 40);
            btnMostrarRepuesto.TabIndex = 115;
            btnMostrarRepuesto.Text = "MOSTRAR TODOS";
            btnMostrarRepuesto.UseVisualStyleBackColor = true;
            btnMostrarRepuesto.Click += btnMostrarRepuesto_Click;
            // 
            // btnActualizarRepuesto
            // 
            btnActualizarRepuesto.Location = new Point(425, 256);
            btnActualizarRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnActualizarRepuesto.Name = "btnActualizarRepuesto";
            btnActualizarRepuesto.Size = new Size(153, 40);
            btnActualizarRepuesto.TabIndex = 114;
            btnActualizarRepuesto.Text = "ACTUALIZAR DATOS";
            btnActualizarRepuesto.UseVisualStyleBackColor = true;
            btnActualizarRepuesto.Click += btnActualizarRepuesto_Click;
            // 
            // btnBuscarRepuesto
            // 
            btnBuscarRepuesto.Location = new Point(39, 199);
            btnBuscarRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnBuscarRepuesto.Name = "btnBuscarRepuesto";
            btnBuscarRepuesto.Size = new Size(153, 40);
            btnBuscarRepuesto.TabIndex = 113;
            btnBuscarRepuesto.Text = "BUSCAR";
            btnBuscarRepuesto.UseVisualStyleBackColor = true;
            btnBuscarRepuesto.Click += btnBuscarRepuesto_Click;
            // 
            // btnEliminarRepuesto
            // 
            btnEliminarRepuesto.Location = new Point(231, 256);
            btnEliminarRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnEliminarRepuesto.Name = "btnEliminarRepuesto";
            btnEliminarRepuesto.Size = new Size(153, 40);
            btnEliminarRepuesto.TabIndex = 112;
            btnEliminarRepuesto.Text = "ELIMINAR";
            btnEliminarRepuesto.UseVisualStyleBackColor = true;
            btnEliminarRepuesto.Click += btnEliminarRepuesto_Click;
            // 
            // dgvRepuesto
            // 
            dgvRepuesto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepuesto.Location = new Point(39, 330);
            dgvRepuesto.Margin = new Padding(3, 4, 3, 4);
            dgvRepuesto.Name = "dgvRepuesto";
            dgvRepuesto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvRepuesto.Size = new Size(768, 241);
            dgvRepuesto.TabIndex = 111;
            // 
            // btnIngresoRepuesto
            // 
            btnIngresoRepuesto.Location = new Point(39, 256);
            btnIngresoRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnIngresoRepuesto.Name = "btnIngresoRepuesto";
            btnIngresoRepuesto.Size = new Size(153, 40);
            btnIngresoRepuesto.TabIndex = 110;
            btnIngresoRepuesto.Text = "INGRESAR";
            btnIngresoRepuesto.UseVisualStyleBackColor = true;
            btnIngresoRepuesto.Click += btnIngresoRepuesto_Click;
            // 
            // txtRepuestoID
            // 
            txtRepuestoID.Location = new Point(40, 43);
            txtRepuestoID.Margin = new Padding(3, 4, 3, 4);
            txtRepuestoID.Name = "txtRepuestoID";
            txtRepuestoID.Size = new Size(115, 27);
            txtRepuestoID.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 102;
            label1.Text = "ID del Repuesto";
            // 
            // txtTipoID
            // 
            txtTipoID.Location = new Point(182, 43);
            txtTipoID.Margin = new Padding(3, 4, 3, 4);
            txtTipoID.Name = "txtTipoID";
            txtTipoID.Size = new Size(170, 27);
            txtTipoID.TabIndex = 121;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 19);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 120;
            label2.Text = "ID del Tipo de Repuesto";
            // 
            // txtUbiRep
            // 
            txtUbiRep.Location = new Point(372, 43);
            txtUbiRep.Margin = new Padding(3, 4, 3, 4);
            txtUbiRep.Name = "txtUbiRep";
            txtUbiRep.Size = new Size(166, 27);
            txtUbiRep.TabIndex = 123;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 19);
            label5.Name = "label5";
            label5.Size = new Size(166, 20);
            label5.TabIndex = 122;
            label5.Text = "Ubicacion del Repuesto";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(562, 43);
            txtSerie.Margin = new Padding(3, 4, 3, 4);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(115, 27);
            txtSerie.TabIndex = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 19);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 124;
            label3.Text = "Numero de Serie";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(713, 43);
            txtCosto.Margin = new Padding(3, 4, 3, 4);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(115, 27);
            txtCosto.TabIndex = 127;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(714, 20);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 126;
            label4.Text = "Costo Unitario";
            // 
            // txtRepNombre
            // 
            txtRepNombre.Location = new Point(40, 121);
            txtRepNombre.Margin = new Padding(3, 4, 3, 4);
            txtRepNombre.Name = "txtRepNombre";
            txtRepNombre.Size = new Size(312, 27);
            txtRepNombre.TabIndex = 129;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 97);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 128;
            label6.Text = "Nombre del Repuesto";
            // 
            // txtDescRep
            // 
            txtDescRep.Location = new Point(439, 121);
            txtDescRep.Margin = new Padding(3, 4, 3, 4);
            txtDescRep.Name = "txtDescRep";
            txtDescRep.Size = new Size(389, 27);
            txtDescRep.TabIndex = 131;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(439, 97);
            label9.Name = "label9";
            label9.Size = new Size(178, 20);
            label9.TabIndex = 130;
            label9.Text = "Descripcion del Repuesto";
            // 
            // Repuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 640);
            Controls.Add(txtDescRep);
            Controls.Add(label9);
            Controls.Add(txtRepNombre);
            Controls.Add(label6);
            Controls.Add(txtCosto);
            Controls.Add(label4);
            Controls.Add(txtSerie);
            Controls.Add(label3);
            Controls.Add(txtUbiRep);
            Controls.Add(label5);
            Controls.Add(txtTipoID);
            Controls.Add(label2);
            Controls.Add(btnMostrarRepuesto);
            Controls.Add(btnActualizarRepuesto);
            Controls.Add(btnBuscarRepuesto);
            Controls.Add(btnEliminarRepuesto);
            Controls.Add(dgvRepuesto);
            Controls.Add(btnIngresoRepuesto);
            Controls.Add(txtRepuestoID);
            Controls.Add(label1);
            Name = "Repuestos";
            Text = "Repuestos";
            Load += Repuestos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepuesto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private DateTimePicker dtpFechaVencimientoG;
        private Label label7;
        private DateTimePicker dtpFechaInicioG;
        private Button btnMostrarGarantia;
        private Button btnMostrarRepuesto;
        private Button btnActualizarRepuesto;
        private Button btnActualizarGarantia;
        private Button btnBuscarRepuesto;
        private Button btnEliminarRepuesto;
        private Button btnBuscarGarantia;
        private Button btnEliminarGarantia;
        private DataGridView dgvRepuesto;
        private Button btnIngresoRepuesto;
        private TextBox txtDuracionMeses;
        private TextBox txtCondiciones;
        private TextBox txtFacturaID;
        private TextBox txtRepuestoID;
        private Label label1;
        private TextBox txtTipoID;
        private Label label2;
        private TextBox txtUbiRep;
        private Label label5;
        private TextBox txtSerie;
        private Label label3;
        private TextBox txtCosto;
        private Label label4;
        private TextBox txtRepNombre;
        private Label label6;
        private TextBox txtDescRep;
        private Label label9;
    }
}