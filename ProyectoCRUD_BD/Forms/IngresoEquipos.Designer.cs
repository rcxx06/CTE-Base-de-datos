namespace ProyectoCRUD_BD
{
    partial class IngresoEquipos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            MostrarEquipos = new DataGridView();
            btnIngresarEquipo = new Button();
            btnEliminarEquipos = new Button();
            btnBuscarEquipo = new Button();
            txtEquipoID = new TextBox();
            txtId_cliente = new TextBox();
            txtMarca = new TextBox();
            txtSerialNumber = new TextBox();
            txtModelo = new TextBox();
            txtTipoEquipo = new TextBox();
            btnActualizar = new Button();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)MostrarEquipos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Equipo ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 48);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Cliente ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 129);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 291);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 205);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "Numero Serial";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 291);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Modelo";
            // 
            // MostrarEquipos
            // 
            MostrarEquipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarEquipos.Location = new Point(375, 13);
            MostrarEquipos.Margin = new Padding(3, 4, 3, 4);
            MostrarEquipos.Name = "MostrarEquipos";
            MostrarEquipos.RowHeadersWidth = 51;
            MostrarEquipos.Size = new Size(526, 247);
            MostrarEquipos.TabIndex = 6;
            // 
            // btnIngresarEquipo
            // 
            btnIngresarEquipo.Location = new Point(31, 381);
            btnIngresarEquipo.Margin = new Padding(3, 4, 3, 4);
            btnIngresarEquipo.Name = "btnIngresarEquipo";
            btnIngresarEquipo.Size = new Size(105, 55);
            btnIngresarEquipo.TabIndex = 7;
            btnIngresarEquipo.Text = "INGRESO";
            btnIngresarEquipo.UseVisualStyleBackColor = true;
            btnIngresarEquipo.Click += btnIngresarEquipo_Click;
            // 
            // btnEliminarEquipos
            // 
            btnEliminarEquipos.Location = new Point(177, 381);
            btnEliminarEquipos.Margin = new Padding(3, 4, 3, 4);
            btnEliminarEquipos.Name = "btnEliminarEquipos";
            btnEliminarEquipos.Size = new Size(121, 55);
            btnEliminarEquipos.TabIndex = 8;
            btnEliminarEquipos.Text = "ELIMINAR";
            btnEliminarEquipos.UseVisualStyleBackColor = true;
            btnEliminarEquipos.Click += btnEliminarEquipos_Click;
            // 
            // btnBuscarEquipo
            // 
            btnBuscarEquipo.Location = new Point(31, 444);
            btnBuscarEquipo.Margin = new Padding(3, 4, 3, 4);
            btnBuscarEquipo.Name = "btnBuscarEquipo";
            btnBuscarEquipo.Size = new Size(129, 48);
            btnBuscarEquipo.TabIndex = 9;
            btnBuscarEquipo.Text = "BUSCAR";
            btnBuscarEquipo.UseVisualStyleBackColor = true;
            btnBuscarEquipo.Click += btnBuscarEquipo_Click;
            // 
            // txtEquipoID
            // 
            txtEquipoID.Location = new Point(31, 81);
            txtEquipoID.Margin = new Padding(3, 4, 3, 4);
            txtEquipoID.Name = "txtEquipoID";
            txtEquipoID.Size = new Size(114, 27);
            txtEquipoID.TabIndex = 10;
            // 
            // txtId_cliente
            // 
            txtId_cliente.Location = new Point(179, 81);
            txtId_cliente.Margin = new Padding(3, 4, 3, 4);
            txtId_cliente.Name = "txtId_cliente";
            txtId_cliente.Size = new Size(114, 27);
            txtId_cliente.TabIndex = 11;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(31, 153);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(114, 27);
            txtMarca.TabIndex = 12;
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Location = new Point(31, 229);
            txtSerialNumber.Margin = new Padding(3, 4, 3, 4);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(114, 27);
            txtSerialNumber.TabIndex = 13;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(31, 315);
            txtModelo.Margin = new Padding(3, 4, 3, 4);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(114, 27);
            txtModelo.TabIndex = 14;
            // 
            // txtTipoEquipo
            // 
            txtTipoEquipo.Location = new Point(179, 315);
            txtTipoEquipo.Margin = new Padding(3, 4, 3, 4);
            txtTipoEquipo.Name = "txtTipoEquipo";
            txtTipoEquipo.Size = new Size(114, 27);
            txtTipoEquipo.TabIndex = 15;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(177, 444);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(121, 48);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(590, 333);
            btnMostrar.Margin = new Padding(3, 4, 3, 4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(119, 52);
            btnMostrar.TabIndex = 17;
            btnMostrar.Text = "MOSTRAR TODOS";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // IngresoEquipos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 531);
            Controls.Add(btnMostrar);
            Controls.Add(btnActualizar);
            Controls.Add(txtTipoEquipo);
            Controls.Add(txtModelo);
            Controls.Add(txtSerialNumber);
            Controls.Add(txtMarca);
            Controls.Add(txtId_cliente);
            Controls.Add(txtEquipoID);
            Controls.Add(btnBuscarEquipo);
            Controls.Add(btnEliminarEquipos);
            Controls.Add(btnIngresarEquipo);
            Controls.Add(MostrarEquipos);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IngresoEquipos";
            Text = "Form2";
            Load += IngresoEquipos_Load;
            ((System.ComponentModel.ISupportInitialize)MostrarEquipos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView MostrarEquipos;
        private Button btnIngresarEquipo;
        private Button btnEliminarEquipos;
        private Button btnBuscarEquipo;
        private TextBox txtEquipoID;
        private TextBox txtId_cliente;
        private TextBox txtMarca;
        private TextBox txtSerialNumber;
        private TextBox txtModelo;
        private TextBox txtTipoEquipo;
        private Button btnActualizar;
        private Button btnMostrar;
    }
}