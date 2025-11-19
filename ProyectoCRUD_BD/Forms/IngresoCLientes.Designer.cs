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
            label1.Location = new Point(106, 73);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de cliente";
            // 
            // Id_Cliente
            // 
            Id_Cliente.Location = new Point(106, 103);
            Id_Cliente.Name = "Id_Cliente";
            Id_Cliente.Size = new Size(124, 23);
            Id_Cliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 154);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre(Completo)";
            // 
            // Nombre_Cliente
            // 
            Nombre_Cliente.Location = new Point(106, 185);
            Nombre_Cliente.Name = "Nombre_Cliente";
            Nombre_Cliente.Size = new Size(286, 23);
            Nombre_Cliente.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 85);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 224);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(338, 215);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 6;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 286);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 7;
            label6.Text = "Contacto Secundario";
            // 
            // TelefonoBox
            // 
            TelefonoBox.Location = new Point(292, 103);
            TelefonoBox.Name = "TelefonoBox";
            TelefonoBox.Size = new Size(100, 23);
            TelefonoBox.TabIndex = 8;
            // 
            // CorreoBox
            // 
            CorreoBox.Location = new Point(324, 242);
            CorreoBox.Name = "CorreoBox";
            CorreoBox.Size = new Size(233, 23);
            CorreoBox.TabIndex = 9;
            // 
            // DireccionBox
            // 
            DireccionBox.Location = new Point(107, 242);
            DireccionBox.Name = "DireccionBox";
            DireccionBox.Size = new Size(162, 23);
            DireccionBox.TabIndex = 10;
            // 
            // Contacto2
            // 
            Contacto2.Location = new Point(107, 304);
            Contacto2.Name = "Contacto2";
            Contacto2.Size = new Size(173, 23);
            Contacto2.TabIndex = 11;
            // 
            // btnIngresoClientes
            // 
            btnIngresoClientes.Location = new Point(339, 297);
            btnIngresoClientes.Name = "btnIngresoClientes";
            btnIngresoClientes.Size = new Size(134, 30);
            btnIngresoClientes.TabIndex = 12;
            btnIngresoClientes.Text = "INGRESAR";
            btnIngresoClientes.UseVisualStyleBackColor = true;
            btnIngresoClientes.Click += btnIngresoClientes_Click;
            // 
            // MostrarClientes
            // 
            MostrarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarClientes.Location = new Point(415, 37);
            MostrarClientes.Name = "MostrarClientes";
            MostrarClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            MostrarClientes.Size = new Size(381, 181);
            MostrarClientes.TabIndex = 13;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.Location = new Point(534, 297);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(134, 30);
            btnEliminarCliente.TabIndex = 14;
            btnEliminarCliente.Text = "ELIMINAR";
            btnEliminarCliente.UseVisualStyleBackColor = true;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnBuscarClientes
            // 
            btnBuscarClientes.Location = new Point(338, 385);
            btnBuscarClientes.Name = "btnBuscarClientes";
            btnBuscarClientes.Size = new Size(134, 30);
            btnBuscarClientes.TabIndex = 15;
            btnBuscarClientes.Text = "BUSCAR";
            btnBuscarClientes.UseVisualStyleBackColor = true;
            btnBuscarClientes.Click += btnBuscarClientes_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(534, 385);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 30);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "ACTUALIZAR DATOS";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(636, 235);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(134, 30);
            btnMostrar.TabIndex = 17;
            btnMostrar.Text = "MOSTRAR TODOS";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // IngresoCLientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
