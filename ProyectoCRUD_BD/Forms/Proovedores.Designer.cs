namespace ProyectoCRUD_BD.Forms
{
    partial class Proovedores
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
            txtCorreoProvee = new TextBox();
            label9 = new Label();
            txtDirProvee = new TextBox();
            label6 = new Label();
            txtTelefonoProvee = new TextBox();
            label4 = new Label();
            txtNombreProvee = new TextBox();
            label2 = new Label();
            btnMostrarProveedor = new Button();
            btnActualizarProveedor = new Button();
            btnBuscarProveedor = new Button();
            dgvProveedores = new DataGridView();
            btnIngresoProveedor = new Button();
            txtProveedorID = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtCorreoProvee
            // 
            txtCorreoProvee.Location = new Point(435, 120);
            txtCorreoProvee.Margin = new Padding(3, 4, 3, 4);
            txtCorreoProvee.Name = "txtCorreoProvee";
            txtCorreoProvee.Size = new Size(389, 27);
            txtCorreoProvee.TabIndex = 151;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(435, 96);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 150;
            label9.Text = "Correo";
            // 
            // txtDirProvee
            // 
            txtDirProvee.Location = new Point(36, 120);
            txtDirProvee.Margin = new Padding(3, 4, 3, 4);
            txtDirProvee.Name = "txtDirProvee";
            txtDirProvee.Size = new Size(312, 27);
            txtDirProvee.TabIndex = 149;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 96);
            label6.Name = "label6";
            label6.Size = new Size(169, 20);
            label6.TabIndex = 148;
            label6.Text = "Direccion del Proveedor";
            // 
            // txtTelefonoProvee
            // 
            txtTelefonoProvee.Location = new Point(637, 42);
            txtTelefonoProvee.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoProvee.Name = "txtTelefonoProvee";
            txtTelefonoProvee.Size = new Size(165, 27);
            txtTelefonoProvee.TabIndex = 147;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 19);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 146;
            label4.Text = "Telefono del Proveedor";
            // 
            // txtNombreProvee
            // 
            txtNombreProvee.Location = new Point(178, 42);
            txtNombreProvee.Margin = new Padding(3, 4, 3, 4);
            txtNombreProvee.Name = "txtNombreProvee";
            txtNombreProvee.Size = new Size(418, 27);
            txtNombreProvee.TabIndex = 141;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 18);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 140;
            label2.Text = "Nombre del Proveedor";
            // 
            // btnMostrarProveedor
            // 
            btnMostrarProveedor.Location = new Point(227, 175);
            btnMostrarProveedor.Margin = new Padding(3, 4, 3, 4);
            btnMostrarProveedor.Name = "btnMostrarProveedor";
            btnMostrarProveedor.Size = new Size(153, 40);
            btnMostrarProveedor.TabIndex = 139;
            btnMostrarProveedor.Text = "MOSTRAR TODOS";
            btnMostrarProveedor.UseVisualStyleBackColor = true;
            btnMostrarProveedor.Click += btnMostrarProveedor_Click;
            // 
            // btnActualizarProveedor
            // 
            btnActualizarProveedor.Location = new Point(414, 175);
            btnActualizarProveedor.Margin = new Padding(3, 4, 3, 4);
            btnActualizarProveedor.Name = "btnActualizarProveedor";
            btnActualizarProveedor.Size = new Size(153, 40);
            btnActualizarProveedor.TabIndex = 138;
            btnActualizarProveedor.Text = "ACTUALIZAR DATOS";
            btnActualizarProveedor.UseVisualStyleBackColor = true;
            btnActualizarProveedor.Click += btnActualizarProveedor_Click;
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Location = new Point(35, 175);
            btnBuscarProveedor.Margin = new Padding(3, 4, 3, 4);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(153, 40);
            btnBuscarProveedor.TabIndex = 137;
            btnBuscarProveedor.Text = "BUSCAR";
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProveedores.Location = new Point(36, 291);
            dgvProveedores.Margin = new Padding(3, 4, 3, 4);
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvProveedores.Size = new Size(768, 241);
            dgvProveedores.TabIndex = 135;
            // 
            // btnIngresoProveedor
            // 
            btnIngresoProveedor.Location = new Point(35, 223);
            btnIngresoProveedor.Margin = new Padding(3, 4, 3, 4);
            btnIngresoProveedor.Name = "btnIngresoProveedor";
            btnIngresoProveedor.Size = new Size(153, 40);
            btnIngresoProveedor.TabIndex = 134;
            btnIngresoProveedor.Text = "INGRESAR";
            btnIngresoProveedor.UseVisualStyleBackColor = true;
            btnIngresoProveedor.Click += btnIngresoProveedor_Click;
            // 
            // txtProveedorID
            // 
            txtProveedorID.Location = new Point(36, 42);
            txtProveedorID.Margin = new Padding(3, 4, 3, 4);
            txtProveedorID.Name = "txtProveedorID";
            txtProveedorID.Size = new Size(121, 27);
            txtProveedorID.TabIndex = 133;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 18);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 132;
            label1.Text = "ID del Proveedor";
            // 
            // button1
            // 
            button1.Location = new Point(227, 223);
            button1.Name = "button1";
            button1.Size = new Size(153, 40);
            button1.TabIndex = 152;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Proovedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 561);
            Controls.Add(button1);
            Controls.Add(txtCorreoProvee);
            Controls.Add(label9);
            Controls.Add(txtDirProvee);
            Controls.Add(label6);
            Controls.Add(txtTelefonoProvee);
            Controls.Add(label4);
            Controls.Add(txtNombreProvee);
            Controls.Add(label2);
            Controls.Add(btnMostrarProveedor);
            Controls.Add(btnActualizarProveedor);
            Controls.Add(btnBuscarProveedor);
            Controls.Add(dgvProveedores);
            Controls.Add(btnIngresoProveedor);
            Controls.Add(txtProveedorID);
            Controls.Add(label1);
            Name = "Proovedores";
            Text = "Proovedores";
            Load += Proovedores_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreoProvee;
        private Label label9;
        private TextBox txtDirProvee;
        private Label label6;
        private TextBox txtTelefonoProvee;
        private Label label4;
        private TextBox txtNombreProvee;
        private Label label2;
        private Button btnMostrarProveedor;
        private Button btnActualizarProveedor;
        private Button btnMostrarRepuesto;
        private Button btnActualizarRepuesto;
        private Button btnBuscarRepuesto;
        private Button btnEliminarRepuesto;
        private DataGridView dgvRepuesto;
        private Button btnIngresoProveedor;
        private TextBox txtProveedorID;
        private Label label1;
        private Button btnBuscarProveedor;

        public Button btnEliminarProveedor { get; private set; }

        private DataGridView dgvProveedores;
        private Button button1;
    }
}