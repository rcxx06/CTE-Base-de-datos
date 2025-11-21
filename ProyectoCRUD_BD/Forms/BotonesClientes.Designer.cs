namespace ProyectoCRUD_BD.Forms
{
    partial class BotonesClientes
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
            btnOrdenes = new Button();
            btnAtrasCliente = new Button();
            BtnEquipos = new Button();
            btnDiagnosticos = new Button();
            btnIngresarClientes = new Button();
            BtnTecnicos = new Button();
            SuspendLayout();
            // 
            // btnOrdenes
            // 
            btnOrdenes.Location = new Point(12, 434);
            btnOrdenes.Margin = new Padding(3, 4, 3, 4);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(150, 41);
            btnOrdenes.TabIndex = 20;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.UseVisualStyleBackColor = true;
            btnOrdenes.Click += btnOrdenes_Click;
            // 
            // btnAtrasCliente
            // 
            btnAtrasCliente.Location = new Point(31, 533);
            btnAtrasCliente.Margin = new Padding(3, 4, 3, 4);
            btnAtrasCliente.Name = "btnAtrasCliente";
            btnAtrasCliente.Size = new Size(97, 43);
            btnAtrasCliente.TabIndex = 19;
            btnAtrasCliente.Text = "Atras";
            btnAtrasCliente.UseVisualStyleBackColor = true;
            btnAtrasCliente.Click += btnAtrasCliente_Click;
            // 
            // BtnEquipos
            // 
            BtnEquipos.Location = new Point(12, 138);
            BtnEquipos.Margin = new Padding(3, 4, 3, 4);
            BtnEquipos.Name = "BtnEquipos";
            BtnEquipos.Size = new Size(150, 41);
            BtnEquipos.TabIndex = 16;
            BtnEquipos.Text = "Equipos";
            BtnEquipos.UseVisualStyleBackColor = true;
            BtnEquipos.Click += BtnEquipos_Click;
            // 
            // btnDiagnosticos
            // 
            btnDiagnosticos.Location = new Point(12, 239);
            btnDiagnosticos.Margin = new Padding(3, 4, 3, 4);
            btnDiagnosticos.Name = "btnDiagnosticos";
            btnDiagnosticos.Size = new Size(150, 41);
            btnDiagnosticos.TabIndex = 17;
            btnDiagnosticos.Text = "Diagnosticos";
            btnDiagnosticos.UseVisualStyleBackColor = true;
            btnDiagnosticos.Click += btnDiagnosticos_Click;
            // 
            // btnIngresarClientes
            // 
            btnIngresarClientes.Location = new Point(12, 40);
            btnIngresarClientes.Margin = new Padding(3, 4, 3, 4);
            btnIngresarClientes.Name = "btnIngresarClientes";
            btnIngresarClientes.Size = new Size(150, 41);
            btnIngresarClientes.TabIndex = 15;
            btnIngresarClientes.Text = "Clientes";
            btnIngresarClientes.UseVisualStyleBackColor = true;
            btnIngresarClientes.Click += btnIngresarClientes_Click;
            // 
            // BtnTecnicos
            // 
            BtnTecnicos.Location = new Point(12, 336);
            BtnTecnicos.Margin = new Padding(3, 4, 3, 4);
            BtnTecnicos.Name = "BtnTecnicos";
            BtnTecnicos.Size = new Size(150, 41);
            BtnTecnicos.TabIndex = 18;
            BtnTecnicos.Text = "Tecnicos";
            BtnTecnicos.UseVisualStyleBackColor = true;
            BtnTecnicos.Click += BtnTecnicos_Click;
            // 
            // BotonesClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 608);
            Controls.Add(btnOrdenes);
            Controls.Add(btnAtrasCliente);
            Controls.Add(BtnEquipos);
            Controls.Add(btnDiagnosticos);
            Controls.Add(btnIngresarClientes);
            Controls.Add(BtnTecnicos);
            Name = "BotonesClientes";
            Text = "BotonesClientes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOrdenes;
        private Button btnAtrasCliente;
        private Button BtnEquipos;
        private Button btnDiagnosticos;
        private Button btnIngresarClientes;
        private Button BtnTecnicos;
    }
}