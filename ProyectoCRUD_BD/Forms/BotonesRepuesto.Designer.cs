namespace ProyectoCRUD_BD.Forms
{
    partial class BotonesRepuesto
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
            btnAtrasRepuesto = new Button();
            BtnTipoRepuesto = new Button();
            btnObtencionRepuesto = new Button();
            btnRepuesto = new Button();
            BtnProveedores = new Button();
            SuspendLayout();
            // 
            // btnAtrasRepuesto
            // 
            btnAtrasRepuesto.Location = new Point(27, 394);
            btnAtrasRepuesto.Name = "btnAtrasRepuesto";
            btnAtrasRepuesto.Size = new Size(85, 32);
            btnAtrasRepuesto.TabIndex = 25;
            btnAtrasRepuesto.Text = "Atras";
            btnAtrasRepuesto.UseVisualStyleBackColor = true;
            btnAtrasRepuesto.Click += btnAtrasRepuesto_Click;
            // 
            // BtnTipoRepuesto
            // 
            BtnTipoRepuesto.Location = new Point(10, 146);
            BtnTipoRepuesto.Name = "BtnTipoRepuesto";
            BtnTipoRepuesto.Size = new Size(131, 31);
            BtnTipoRepuesto.TabIndex = 22;
            BtnTipoRepuesto.Text = "Tipo Repuesto";
            BtnTipoRepuesto.UseVisualStyleBackColor = true;
            BtnTipoRepuesto.Click += BtnTipoRepuesto_Click;
            // 
            // btnObtencionRepuesto
            // 
            btnObtencionRepuesto.Location = new Point(10, 217);
            btnObtencionRepuesto.Name = "btnObtencionRepuesto";
            btnObtencionRepuesto.Size = new Size(131, 40);
            btnObtencionRepuesto.TabIndex = 23;
            btnObtencionRepuesto.Text = "Obtencion Repuesto";
            btnObtencionRepuesto.UseVisualStyleBackColor = true;
            btnObtencionRepuesto.Click += btnObtencionRepuesto_Click;
            // 
            // btnRepuesto
            // 
            btnRepuesto.Location = new Point(10, 72);
            btnRepuesto.Name = "btnRepuesto";
            btnRepuesto.Size = new Size(131, 31);
            btnRepuesto.TabIndex = 21;
            btnRepuesto.Text = "Repuesto";
            btnRepuesto.UseVisualStyleBackColor = true;
            btnRepuesto.Click += btnRepuesto_Click;
            // 
            // BtnProveedores
            // 
            BtnProveedores.Location = new Point(10, 294);
            BtnProveedores.Name = "BtnProveedores";
            BtnProveedores.Size = new Size(131, 31);
            BtnProveedores.TabIndex = 24;
            BtnProveedores.Text = "Proveedores";
            BtnProveedores.UseVisualStyleBackColor = true;
            BtnProveedores.Click += BtnProveedores_Click;
            // 
            // BotonesRepuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 456);
            Controls.Add(btnAtrasRepuesto);
            Controls.Add(BtnTipoRepuesto);
            Controls.Add(btnObtencionRepuesto);
            Controls.Add(btnRepuesto);
            Controls.Add(BtnProveedores);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BotonesRepuesto";
            Text = "BotonesRepuesto";
            Load += BotonesRepuesto_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtrasRepuesto;
        private Button BtnTipoRepuesto;
        private Button btnObtencionRepuesto;
        private Button btnRepuesto;
        private Button BtnProveedores;
    }
}