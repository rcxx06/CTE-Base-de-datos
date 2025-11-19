namespace ProyectoCRUD_BD
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            btnIngresarClientes = new Button();
            button2 = new Button();
            btnDiagnosticos = new Button();
            helpProvider1 = new HelpProvider();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            button1 = new Button();
            panelMenu = new Panel();
            btnSalir = new Button();
            controladorForms = new Panel();
            contextMenuStrip2.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btnIngresarClientes
            // 
            btnIngresarClientes.Location = new Point(8, 206);
            btnIngresarClientes.Name = "btnIngresarClientes";
            btnIngresarClientes.Size = new Size(126, 33);
            btnIngresarClientes.TabIndex = 0;
            btnIngresarClientes.Text = "Clientes";
            btnIngresarClientes.UseVisualStyleBackColor = true;
            btnIngresarClientes.Click += btnIngresarClientes_Click;
            // 
            // button2
            // 
            button2.Location = new Point(8, 27);
            button2.Name = "button2";
            button2.Size = new Size(139, 35);
            button2.TabIndex = 1;
            button2.Text = "Equipos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDiagnosticos
            // 
            btnDiagnosticos.Location = new Point(8, 118);
            btnDiagnosticos.Name = "btnDiagnosticos";
            btnDiagnosticos.Size = new Size(131, 31);
            btnDiagnosticos.TabIndex = 2;
            btnDiagnosticos.Text = "Diagnosticos";
            btnDiagnosticos.UseVisualStyleBackColor = true;
            btnDiagnosticos.Click += btnDiagnosticos_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            // 
            // button1
            // 
            button1.Location = new Point(8, 299);
            button1.Name = "button1";
            button1.Size = new Size(126, 32);
            button1.TabIndex = 7;
            button1.Text = "Tecnicos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnDiagnosticos);
            panelMenu.Controls.Add(btnIngresarClientes);
            panelMenu.Location = new Point(12, 12);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(150, 405);
            panelMenu.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(62, 370);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(85, 32);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // controladorForms
            // 
            controladorForms.Location = new Point(185, 12);
            controladorForms.Name = "controladorForms";
            controladorForms.Size = new Size(880, 444);
            controladorForms.TabIndex = 9;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 456);
            Controls.Add(controladorForms);
            Controls.Add(panelMenu);
            Name = "Main";
            Text = "Form3";
            Load += Main_Load;
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip2.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresarClientes;
        private Button button2;
        private Button btnDiagnosticos;
        private HelpProvider helpProvider1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripTextBox toolStripTextBox1;
        private Button button1;
        private Panel panelMenu;
        private Button btnSalir;
        private Panel controladorForms;
    }
}