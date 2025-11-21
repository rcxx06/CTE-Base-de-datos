namespace ProyectoCRUD_BD.Forms
{
    partial class Diagnosticos
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
            gbFechaHora = new GroupBox();
            txtFecha = new TextBox();
            txtHora = new TextBox();
            label8 = new Label();
            label7 = new Label();
            MostrarDiagnosticos = new DataGridView();
            txtIdDiagnostico = new TextBox();
            txtIDequipo = new TextBox();
            txtIdTecnico = new TextBox();
            txtDiagnosticoFinal = new TextBox();
            txtFallaReportada = new TextBox();
            btnIngresarD = new Button();
            btnEliminarD = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnMostrarD = new Button();
            gbFechaHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarDiagnosticos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 5);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero De Diagnostico";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 80);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "ID Equipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 15);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Tecnico ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 74);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Falla reportada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 231);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 158);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 5;
            label6.Text = "Diagnostico final";
            // 
            // gbFechaHora
            // 
            gbFechaHora.Controls.Add(txtFecha);
            gbFechaHora.Controls.Add(txtHora);
            gbFechaHora.Controls.Add(label8);
            gbFechaHora.Controls.Add(label7);
            gbFechaHora.Location = new Point(508, 5);
            gbFechaHora.Name = "gbFechaHora";
            gbFechaHora.Size = new Size(237, 177);
            gbFechaHora.TabIndex = 6;
            gbFechaHora.TabStop = false;
            gbFechaHora.Text = "Seleccione";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(25, 41);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 4;
            // 
            // txtHora
            // 
            txtHora.Location = new Point(25, 108);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(100, 23);
            txtHora.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 81);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 2;
            label8.Text = "Hora ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 23);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "Fecha";
            // 
            // MostrarDiagnosticos
            // 
            MostrarDiagnosticos.Location = new Point(203, 256);
            MostrarDiagnosticos.Name = "MostrarDiagnosticos";
            MostrarDiagnosticos.Size = new Size(517, 174);
            MostrarDiagnosticos.TabIndex = 7;
            // 
            // txtIdDiagnostico
            // 
            txtIdDiagnostico.Location = new Point(112, 33);
            txtIdDiagnostico.Name = "txtIdDiagnostico";
            txtIdDiagnostico.Size = new Size(134, 23);
            txtIdDiagnostico.TabIndex = 8;
            // 
            // txtIDequipo
            // 
            txtIDequipo.Location = new Point(112, 98);
            txtIDequipo.Name = "txtIDequipo";
            txtIDequipo.Size = new Size(119, 23);
            txtIDequipo.TabIndex = 9;
            // 
            // txtIdTecnico
            // 
            txtIdTecnico.Location = new Point(281, 33);
            txtIdTecnico.Name = "txtIdTecnico";
            txtIdTecnico.Size = new Size(119, 23);
            txtIdTecnico.TabIndex = 10;
            // 
            // txtDiagnosticoFinal
            // 
            txtDiagnosticoFinal.Location = new Point(101, 187);
            txtDiagnosticoFinal.Multiline = true;
            txtDiagnosticoFinal.Name = "txtDiagnosticoFinal";
            txtDiagnosticoFinal.Size = new Size(350, 51);
            txtDiagnosticoFinal.TabIndex = 11;
            txtDiagnosticoFinal.TextChanged += txtDiagnosticoFinal_TextChanged;
            // 
            // txtFallaReportada
            // 
            txtFallaReportada.Location = new Point(281, 98);
            txtFallaReportada.Multiline = true;
            txtFallaReportada.Name = "txtFallaReportada";
            txtFallaReportada.Size = new Size(197, 66);
            txtFallaReportada.TabIndex = 12;
            // 
            // btnIngresarD
            // 
            btnIngresarD.Location = new Point(466, 204);
            btnIngresarD.Name = "btnIngresarD";
            btnIngresarD.Size = new Size(75, 23);
            btnIngresarD.TabIndex = 13;
            btnIngresarD.Text = "INGRESAR";
            btnIngresarD.UseVisualStyleBackColor = true;
            btnIngresarD.Click += btnIngresarD_Click;
            // 
            // btnEliminarD
            // 
            btnEliminarD.Location = new Point(582, 204);
            btnEliminarD.Name = "btnEliminarD";
            btnEliminarD.Size = new Size(75, 23);
            btnEliminarD.TabIndex = 14;
            btnEliminarD.Text = "ELIMINAR";
            btnEliminarD.UseVisualStyleBackColor = true;
            btnEliminarD.Click += btnEliminarD_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(107, 336);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(699, 204);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(113, 23);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrarD
            // 
            btnMostrarD.Location = new Point(107, 271);
            btnMostrarD.Name = "btnMostrarD";
            btnMostrarD.Size = new Size(75, 23);
            btnMostrarD.TabIndex = 17;
            btnMostrarD.Text = "MOSTRAR";
            btnMostrarD.UseVisualStyleBackColor = true;
            btnMostrarD.Click += btnMostrarD_Click;
            // 
            // Diagnosticos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 446);
            Controls.Add(btnMostrarD);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminarD);
            Controls.Add(btnIngresarD);
            Controls.Add(txtFallaReportada);
            Controls.Add(txtDiagnosticoFinal);
            Controls.Add(txtIdTecnico);
            Controls.Add(txtIDequipo);
            Controls.Add(txtIdDiagnostico);
            Controls.Add(MostrarDiagnosticos);
            Controls.Add(gbFechaHora);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Diagnosticos";
            Text = "Diagnosticos";
            Load += Diagnosticos_Load;
            gbFechaHora.ResumeLayout(false);
            gbFechaHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MostrarDiagnosticos).EndInit();
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
        private GroupBox gbFechaHora;
        private Label label7;
        private TextBox txtHora;
        private Label label8;
        private DataGridView MostrarDiagnosticos;
        private TextBox txtIdDiagnostico;
        private TextBox txtIDequipo;
        private TextBox txtIdTecnico;
        private TextBox txtDiagnosticoFinal;
        private TextBox txtFallaReportada;
        private Button btnIngresarD;
        private Button btnEliminarD;
        private Button btnBuscar;
        private TextBox txtFecha;
        private Button btnActualizar;
        private Button btnMostrarD;
    }
}