namespace ProyectoCRUD_BD.Forms
{
    partial class Tecnicos
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
            MostrarTecnicos = new DataGridView();
            txtId_tecnico = new TextBox();
            txtNombre = new TextBox();
            txtEspecialidad = new TextBox();
            txtHorario = new TextBox();
            txtContacto = new TextBox();
            btnIngresar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnActualizar = new Button();
            btnMostrar = new Button();
            Drealizados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MostrarTecnicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Drealizados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Tecnico ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 119);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 175);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Especialidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 221);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Horario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 269);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Contacto";
            // 
            // MostrarTecnicos
            // 
            MostrarTecnicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MostrarTecnicos.Location = new Point(309, 28);
            MostrarTecnicos.Name = "MostrarTecnicos";
            MostrarTecnicos.Size = new Size(209, 133);
            MostrarTecnicos.TabIndex = 5;
            // 
            // txtId_tecnico
            // 
            txtId_tecnico.Location = new Point(107, 85);
            txtId_tecnico.Name = "txtId_tecnico";
            txtId_tecnico.Size = new Size(100, 23);
            txtId_tecnico.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(107, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(107, 193);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(150, 23);
            txtEspecialidad.TabIndex = 8;
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(107, 243);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(116, 23);
            txtHorario.TabIndex = 9;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(107, 302);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(150, 23);
            txtContacto.TabIndex = 10;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(424, 250);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(309, 250);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(556, 316);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(343, 192);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(156, 23);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "ACTUALIZAR DATOS";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(662, 316);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(137, 23);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "MOSTRAR TECNICOS";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Drealizados
            // 
            Drealizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Drealizados.Location = new Point(556, 28);
            Drealizados.Name = "Drealizados";
            Drealizados.Size = new Size(326, 268);
            Drealizados.TabIndex = 16;
            // 
            // Tecnicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 450);
            Controls.Add(Drealizados);
            Controls.Add(btnMostrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContacto);
            Controls.Add(txtHorario);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId_tecnico);
            Controls.Add(MostrarTecnicos);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tecnicos";
            Text = "Tecnicos";
            Load += Tecnicos_Load;
            ((System.ComponentModel.ISupportInitialize)MostrarTecnicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Drealizados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView MostrarTecnicos;
        private TextBox txtId_tecnico;
        private TextBox txtNombre;
        private TextBox txtEspecialidad;
        private TextBox txtHorario;
        private TextBox txtContacto;
        private Button btnIngresar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnActualizar;
        private Button btnMostrar;
        private DataGridView Drealizados;
    }
}