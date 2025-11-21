namespace ProyectoCRUD_BD.Forms
{
    partial class TipoRepuestos
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
            btnMostrarTipoRep = new Button();
            btnActualizarTipoRep = new Button();
            btnBuscarTipoRep = new Button();
            btnEliminarTipoRep = new Button();
            dgvTipoRep = new DataGridView();
            btnIngresoTipoRep = new Button();
            txtTipoNombre = new TextBox();
            label2 = new Label();
            txtTipoID = new TextBox();
            label1 = new Label();
            textTipoElectronico = new TextBox();
            label3 = new Label();
            btnMostrarRepuestosTipo = new Button();
            btnBuscarPorNombre = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvTipoRep).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMostrarTipoRep
            // 
            btnMostrarTipoRep.Location = new Point(56, 138);
            btnMostrarTipoRep.Margin = new Padding(3, 4, 3, 4);
            btnMostrarTipoRep.Name = "btnMostrarTipoRep";
            btnMostrarTipoRep.Size = new Size(153, 40);
            btnMostrarTipoRep.TabIndex = 93;
            btnMostrarTipoRep.Text = "MOSTRAR TODOS";
            btnMostrarTipoRep.UseVisualStyleBackColor = true;
            btnMostrarTipoRep.Click += btnMostrarTipoRep_Click;
            // 
            // btnActualizarTipoRep
            // 
            btnActualizarTipoRep.Location = new Point(232, 90);
            btnActualizarTipoRep.Margin = new Padding(3, 4, 3, 4);
            btnActualizarTipoRep.Name = "btnActualizarTipoRep";
            btnActualizarTipoRep.Size = new Size(153, 40);
            btnActualizarTipoRep.TabIndex = 92;
            btnActualizarTipoRep.Text = "ACTUALIZAR DATOS";
            btnActualizarTipoRep.UseVisualStyleBackColor = true;
            btnActualizarTipoRep.Click += btnActualizarTipoRep_Click;
            // 
            // btnBuscarTipoRep
            // 
            btnBuscarTipoRep.Location = new Point(6, 59);
            btnBuscarTipoRep.Margin = new Padding(3, 4, 3, 4);
            btnBuscarTipoRep.Name = "btnBuscarTipoRep";
            btnBuscarTipoRep.Size = new Size(153, 40);
            btnBuscarTipoRep.TabIndex = 91;
            btnBuscarTipoRep.Text = "Por id";
            btnBuscarTipoRep.UseVisualStyleBackColor = true;
            btnBuscarTipoRep.Click += btnBuscarTipoRep_Click;
            // 
            // btnEliminarTipoRep
            // 
            btnEliminarTipoRep.Location = new Point(232, 138);
            btnEliminarTipoRep.Margin = new Padding(3, 4, 3, 4);
            btnEliminarTipoRep.Name = "btnEliminarTipoRep";
            btnEliminarTipoRep.Size = new Size(153, 40);
            btnEliminarTipoRep.TabIndex = 90;
            btnEliminarTipoRep.Text = "ELIMINAR";
            btnEliminarTipoRep.UseVisualStyleBackColor = true;
            btnEliminarTipoRep.Click += btnEliminarTipoRep_Click;
            // 
            // dgvTipoRep
            // 
            dgvTipoRep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoRep.Location = new Point(40, 186);
            dgvTipoRep.Margin = new Padding(3, 4, 3, 4);
            dgvTipoRep.Name = "dgvTipoRep";
            dgvTipoRep.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvTipoRep.Size = new Size(681, 241);
            dgvTipoRep.TabIndex = 89;
            // 
            // btnIngresoTipoRep
            // 
            btnIngresoTipoRep.Location = new Point(56, 90);
            btnIngresoTipoRep.Margin = new Padding(3, 4, 3, 4);
            btnIngresoTipoRep.Name = "btnIngresoTipoRep";
            btnIngresoTipoRep.Size = new Size(153, 40);
            btnIngresoTipoRep.TabIndex = 88;
            btnIngresoTipoRep.Text = "INGRESAR";
            btnIngresoTipoRep.UseVisualStyleBackColor = true;
            btnIngresoTipoRep.Click += btnIngresoTipoRep_Click;
            // 
            // txtTipoNombre
            // 
            txtTipoNombre.Location = new Point(252, 37);
            txtTipoNombre.Margin = new Padding(3, 4, 3, 4);
            txtTipoNombre.Name = "txtTipoNombre";
            txtTipoNombre.Size = new Size(168, 27);
            txtTipoNombre.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 13);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 82;
            label2.Text = "Nombre del tipo de repuesto";
            // 
            // txtTipoID
            // 
            txtTipoID.Location = new Point(39, 37);
            txtTipoID.Margin = new Padding(3, 4, 3, 4);
            txtTipoID.Name = "txtTipoID";
            txtTipoID.Size = new Size(197, 27);
            txtTipoID.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 13);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 80;
            label1.Text = "ID del Tipo de Repuesto";
            // 
            // textTipoElectronico
            // 
            textTipoElectronico.Location = new Point(480, 37);
            textTipoElectronico.Margin = new Padding(3, 4, 3, 4);
            textTipoElectronico.Name = "textTipoElectronico";
            textTipoElectronico.Size = new Size(168, 27);
            textTipoElectronico.TabIndex = 94;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 13);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 95;
            label3.Text = "Tipo electronico";
            // 
            // btnMostrarRepuestosTipo
            // 
            btnMostrarRepuestosTipo.Location = new Point(165, 60);
            btnMostrarRepuestosTipo.Name = "btnMostrarRepuestosTipo";
            btnMostrarRepuestosTipo.Size = new Size(153, 40);
            btnMostrarRepuestosTipo.TabIndex = 96;
            btnMostrarRepuestosTipo.Text = "De un solo tipo";
            btnMostrarRepuestosTipo.UseVisualStyleBackColor = true;
            btnMostrarRepuestosTipo.Click += btnMostrarRepuestosTipo_Click;
            // 
            // btnBuscarPorNombre
            // 
            btnBuscarPorNombre.Location = new Point(165, 17);
            btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            btnBuscarPorNombre.Size = new Size(153, 40);
            btnBuscarPorNombre.TabIndex = 97;
            btnBuscarPorNombre.Text = "Por Nombre";
            btnBuscarPorNombre.UseVisualStyleBackColor = true;
            btnBuscarPorNombre.Click += btnBuscarPorNombre_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscarTipoRep);
            groupBox1.Controls.Add(btnMostrarRepuestosTipo);
            groupBox1.Controls.Add(btnBuscarPorNombre);
            groupBox1.Location = new Point(398, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 106);
            groupBox1.TabIndex = 98;
            groupBox1.TabStop = false;
            groupBox1.Text = "buaquedas";
            // 
            // TipoRepuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(textTipoElectronico);
            Controls.Add(btnMostrarTipoRep);
            Controls.Add(btnActualizarTipoRep);
            Controls.Add(btnEliminarTipoRep);
            Controls.Add(dgvTipoRep);
            Controls.Add(btnIngresoTipoRep);
            Controls.Add(txtTipoNombre);
            Controls.Add(label2);
            Controls.Add(txtTipoID);
            Controls.Add(label1);
            Name = "TipoRepuestos";
            Text = "TipoRepuestos";
            ((System.ComponentModel.ISupportInitialize)dgvTipoRep).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarTipoRep;
        private Button btnActualizarTipoRep;
        private Button btnBuscarTipoRep;
        private Button btnEliminarTipoRep;
        private DataGridView dgvTipoRep;
        private Button btnIngresoTipoRep;
        private TextBox txtTipoNombre;
        private Label label2;
        private TextBox txtTipoID;
        private Label label1;
        private TextBox textTipoElectronico;
        private Label label3;
        private Button btnMostrarRepuestosTipo;
        private Button btnBuscarPorNombre;
        private GroupBox groupBox1;
    }
}