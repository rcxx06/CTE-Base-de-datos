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
            btnAtrasRepuesto.Location = new Point(31, 525);
            btnAtrasRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnAtrasRepuesto.Name = "btnAtrasRepuesto";
            btnAtrasRepuesto.Size = new Size(97, 43);
            btnAtrasRepuesto.TabIndex = 25;
            btnAtrasRepuesto.Text = "Atras";
            btnAtrasRepuesto.UseVisualStyleBackColor = true;
            btnAtrasRepuesto.Click += btnAtrasRepuesto_Click;
            // 
            // BtnTipoRepuesto
            // 
            BtnTipoRepuesto.Location = new Point(12, 194);
            BtnTipoRepuesto.Margin = new Padding(3, 4, 3, 4);
            BtnTipoRepuesto.Name = "BtnTipoRepuesto";
            BtnTipoRepuesto.Size = new Size(150, 41);
            BtnTipoRepuesto.TabIndex = 22;
            BtnTipoRepuesto.Text = "Tipo Repuesto";
            BtnTipoRepuesto.UseVisualStyleBackColor = true;
            BtnTipoRepuesto.Click += BtnTipoRepuesto_Click;
            // 
            // btnObtencionRepuesto
            // 
            btnObtencionRepuesto.Location = new Point(12, 289);
            btnObtencionRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnObtencionRepuesto.Name = "btnObtencionRepuesto";
            btnObtencionRepuesto.Size = new Size(150, 54);
            btnObtencionRepuesto.TabIndex = 23;
            btnObtencionRepuesto.Text = "Obtencion Repuesto";
            btnObtencionRepuesto.UseVisualStyleBackColor = true;
            btnObtencionRepuesto.Click += btnObtencionRepuesto_Click;
            // 
            // btnRepuesto
            // 
            btnRepuesto.Location = new Point(12, 96);
            btnRepuesto.Margin = new Padding(3, 4, 3, 4);
            btnRepuesto.Name = "btnRepuesto";
            btnRepuesto.Size = new Size(150, 41);
            btnRepuesto.TabIndex = 21;
            btnRepuesto.Text = "Repuesto";
            btnRepuesto.UseVisualStyleBackColor = true;
            btnRepuesto.Click += btnRepuesto_Click;
            // 
            // BtnProveedores
            // 
            BtnProveedores.Location = new Point(12, 392);
            BtnProveedores.Margin = new Padding(3, 4, 3, 4);
            BtnProveedores.Name = "BtnProveedores";
            BtnProveedores.Size = new Size(150, 41);
            BtnProveedores.TabIndex = 24;
            BtnProveedores.Text = "Proveedores";
            BtnProveedores.UseVisualStyleBackColor = true;
            BtnProveedores.Click += BtnProveedores_Click;
            // 
            // BotonesRepuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 608);
            Controls.Add(btnAtrasRepuesto);
            Controls.Add(BtnTipoRepuesto);
            Controls.Add(btnObtencionRepuesto);
            Controls.Add(btnRepuesto);
            Controls.Add(BtnProveedores);
            Name = "BotonesRepuesto";
            Text = "BotonesRepuesto";
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