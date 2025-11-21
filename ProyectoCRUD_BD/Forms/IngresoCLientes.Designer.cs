namespace ProyectoCRUD_BD
{
    partial class IngresoCLientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Id_Cliente = new TextBox();
            label2 = new Label();
            Nombre_Cliente = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TelefonoBox = new TextBox();
            CorreoBox = new TextBox();
            DireccionBox = new TextBox();
            Contacto2 = new TextBox();
            btnIngresoClientes = new Button();
            MostrarClientes = new DataGridView();
            btnEliminarCliente = new Button();
            btnBuscarClientes = new Button();
            btnActualizar = new Button();
            btnMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)MostrarClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 49);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero de cliente";
            // 
            // Id_Cliente
            // 
            Id_Cliente.Location = new Point(40, 73);
            Id_Cliente.Margin = new Padding(3, 4, 3, 4);
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.Size = new Size(141, 27);
            Id_Cliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre(Completo)";
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.Location = new Point(40, 162);
            Nombre_Cliente.Margin = new Padding(3, 4, 3, 4);
            Nombre_Cliente.Name = "Nombre_Cliente";
            Nombre_Cliente.Size = new Size(326, 27);
            Nombre_Cliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 49);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 221);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 5;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 385);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 6;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 303);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 7;
            label6.Text = "Contacto Secundario";
            // 
            // TelefonoBox
            // 
            TelefonoBox.Location = new Point(232, 73);
            TelefonoBox.Margin = new Padding(3, 4, 3, 4);
            TelefonoBox.Name = "TelefonoBox";
            TelefonoBox.Size = new Size(114, 27);
            TelefonoBox.TabIndex = 8;
            // 
            // CorreoBox
            // 
            CorreoBox.Location = new Point(40, 422);
            CorreoBox.Margin = new Padding(3, 4, 3, 4);
            CorreoBox.Name = "CorreoBox";
            CorreoBox.Size = new Size(266, 27);
            CorreoBox.TabIndex = 9;
            // 
            // DireccionBox
            // 
            DireccionBox.Location = new Point(40, 245);
            DireccionBox.Margin = new Padding(3, 4, 3, 4);
            DireccionBox.Name = "DireccionBox";
            DireccionBox.Size = new Size(185, 27);
            DireccionBox.TabIndex = 10;
            // 
            // Contacto2
            // 
            Contacto2.Location = new Point(40, 327);
            Contacto2.Margin = new Padding(3, 4, 3, 4);
            Contacto2.Name = "Contacto2";
            Contacto2.Size = new Size(197, 27);
            Contacto2.TabIndex = 11;
            // 
            // btnIngresoClientes
            // 
            btnIngresoClientes.Location = new Point(518, 432);
            btnIngresoClientes.Margin = new Padding(3, 4, 3, 4);
            btnIngresoClientes.Name = "btnIngresoClientes";
            btnIngresoClientes.Size = new Size(153, 40);
            btnIngresoClientes.TabIndex = 12;
            btnIngresoClientes.Text = "INGRESAR";
            btnIngresoClientes.UseVisualStyleBackColor = true;
            btnIngresoClientes.Click += btnIngresoClientes_Click;
            // 
            // MostrarClientes
            // 
            MostrarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarClientes.Location = new Point(474, 49);
            MostrarClientes.Margin = new Padding(3, 4, 3, 4);
            MostrarClientes.Name = "MostrarClientes";
            MostrarClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            MostrarClientes.Size = new Size(435, 241);
            MostrarClientes.TabIndex = 13;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(688, 432);
            btnEliminarCliente.Margin = new Padding(3, 4, 3, 4);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(153, 40);
            btnEliminarCliente.TabIndex = 14;
            btnEliminarCliente.Text = "ELIMINAR";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnBuscarClientes
            // 
            btnBuscarClientes.Location = new Point(518, 480);
            btnBuscarClientes.Margin = new Padding(3, 4, 3, 4);
            btnBuscarClientes.Name = "btnBuscarClientes";
            btnBuscarClientes.Size = new Size(153, 40);
            btnBuscarClientes.TabIndex = 15;
            btnBuscarClientes.Text = "BUSCAR";
            btnBuscarClientes.UseVisualStyleBackColor = true;
            btnBuscarClientes.Click += btnBuscarClientes_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(688, 480);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(153, 40);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "ACTUALIZAR DATOS";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(605, 314);
            btnMostrar.Margin = new Padding(3, 4, 3, 4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(153, 40);
            btnMostrar.TabIndex = 17;
            btnMostrar.Text = "MOSTRAR TODOS";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // IngresoCLientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnMostrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscarClientes);
            Controls.Add(btnEliminarCliente);
            Controls.Add(MostrarClientes);
            Controls.Add(btnIngresoClientes);
            Controls.Add(Contacto2);
            Controls.Add(DireccionBox);
            Controls.Add(CorreoBox);
            Controls.Add(TelefonoBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Nombre_Cliente);
            Controls.Add(label2);
            Controls.Add(Id_Cliente);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "IngresoCLientes";
            Text = "Form1";
            Load += IngresoCLientes_Load;
            ((System.ComponentModel.ISupportInitialize)MostrarClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Id_Cliente;
        private Label label2;
        private TextBox Nombre_Cliente;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TelefonoBox;
        private TextBox CorreoBox;
        private TextBox DireccionBox;
        private TextBox Contacto2;
        private Button btnIngresoClientes;
        private DataGridView MostrarClientes;
        private Button btnEliminarCliente;
        private Button btnBuscar;
        private Button btnBuscarClientes;
        private Button btnActualizar;
        private Button btnMostrar;
    }
}
