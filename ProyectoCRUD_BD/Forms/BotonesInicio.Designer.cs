namespace ProyectoCRUD_BD.Forms
{
    partial class BotonesInicio
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
            btnAtrasInicio = new Button();
            BtnirRepuesto = new Button();
            BtnIrPresentacion = new Button();
            btnIrFacturas = new Button();
            BtnIrClientes = new Button();
            SuspendLayout();
            // 
            // btnAtrasInicio
            // 
            btnAtrasInicio.Location = new Point(39, 410);
            btnAtrasInicio.Margin = new Padding(3, 4, 3, 4);
            btnAtrasInicio.Name = "btnAtrasInicio";
            btnAtrasInicio.Size = new Size(97, 43);
            btnAtrasInicio.TabIndex = 29;
            btnAtrasInicio.Text = "Atras";
            btnAtrasInicio.UseVisualStyleBackColor = true;
            btnAtrasInicio.Click += btnAtrasInicio_Click;
            // 
            // BtnirRepuesto
            // 
            BtnirRepuesto.Location = new Point(12, 327);
            BtnirRepuesto.Margin = new Padding(3, 4, 3, 4);
            BtnirRepuesto.Name = "BtnirRepuesto";
            BtnirRepuesto.Size = new Size(150, 41);
            BtnirRepuesto.TabIndex = 27;
            BtnirRepuesto.Text = "Repuesto";
            BtnirRepuesto.UseVisualStyleBackColor = true;
            BtnirRepuesto.Click += BtnirRepuesto_Click;
            // 
            // BtnIrPresentacion
            // 
            BtnIrPresentacion.Location = new Point(12, 97);
            BtnIrPresentacion.Margin = new Padding(3, 4, 3, 4);
            BtnIrPresentacion.Name = "BtnIrPresentacion";
            BtnIrPresentacion.Size = new Size(150, 41);
            BtnIrPresentacion.TabIndex = 28;
            BtnIrPresentacion.Text = "Inicio";
            BtnIrPresentacion.UseVisualStyleBackColor = true;
            BtnIrPresentacion.Click += BtnIrPresentacion_Click;
            // 
            // btnIrFacturas
            // 
            btnIrFacturas.Location = new Point(12, 248);
            btnIrFacturas.Margin = new Padding(3, 4, 3, 4);
            btnIrFacturas.Name = "btnIrFacturas";
            btnIrFacturas.Size = new Size(150, 41);
            btnIrFacturas.TabIndex = 26;
            btnIrFacturas.Text = "Facturas";
            btnIrFacturas.UseVisualStyleBackColor = true;
            btnIrFacturas.Click += btnIrFacturas_Click;
            // 
            // BtnIrClientes
            // 
            BtnIrClientes.Location = new Point(12, 175);
            BtnIrClientes.Margin = new Padding(3, 4, 3, 4);
            BtnIrClientes.Name = "BtnIrClientes";
            BtnIrClientes.Size = new Size(150, 41);
            BtnIrClientes.TabIndex = 30;
            BtnIrClientes.Text = "Clientes";
            BtnIrClientes.UseVisualStyleBackColor = true;
            BtnIrClientes.Click += BtnIrClientes_Click;
            // 
            // BotonesInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 608);
            Controls.Add(BtnIrClientes);
            Controls.Add(btnAtrasInicio);
            Controls.Add(BtnirRepuesto);
            Controls.Add(BtnIrPresentacion);
            Controls.Add(btnIrFacturas);
            Name = "BotonesInicio";
            Text = "BotonesInicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtrasInicio;
        private Button BtnirRepuesto;
        private Button BtnIrPresentacion;
        private Button btnIrFacturas;
        private Button BtnIrClientes;
    }
}