namespace ProyectoCRUD_BD.Forms
{
    partial class BotonesFacturas
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
            BtnAtrasFacturas = new Button();
            btnGarantias = new Button();
            BtnRepuestoUsado = new Button();
            btnFacturas = new Button();
            SuspendLayout();
            // 
            // BtnAtrasFacturas
            // 
            BtnAtrasFacturas.Location = new Point(32, 423);
            BtnAtrasFacturas.Margin = new Padding(3, 4, 3, 4);
            BtnAtrasFacturas.Name = "BtnAtrasFacturas";
            BtnAtrasFacturas.Size = new Size(97, 43);
            BtnAtrasFacturas.TabIndex = 29;
            BtnAtrasFacturas.Text = "Atras";
            BtnAtrasFacturas.UseVisualStyleBackColor = true;
            BtnAtrasFacturas.Click += BtnAtrasFacturas_Click;
            // 
            // btnGarantias
            // 
            btnGarantias.Location = new Point(12, 220);
            btnGarantias.Margin = new Padding(3, 4, 3, 4);
            btnGarantias.Name = "btnGarantias";
            btnGarantias.Size = new Size(150, 41);
            btnGarantias.TabIndex = 27;
            btnGarantias.Text = "Garantias";
            btnGarantias.UseVisualStyleBackColor = true;
            btnGarantias.Click += btnGarantias_Click;
            // 
            // BtnRepuestoUsado
            // 
            BtnRepuestoUsado.Location = new Point(12, 321);
            BtnRepuestoUsado.Margin = new Padding(3, 4, 3, 4);
            BtnRepuestoUsado.Name = "BtnRepuestoUsado";
            BtnRepuestoUsado.Size = new Size(150, 41);
            BtnRepuestoUsado.TabIndex = 28;
            BtnRepuestoUsado.Text = "Repuestos Usados";
            BtnRepuestoUsado.UseVisualStyleBackColor = true;
            BtnRepuestoUsado.Click += BtnRepuestoUsado_Click;
            // 
            // btnFacturas
            // 
            btnFacturas.Location = new Point(12, 124);
            btnFacturas.Margin = new Padding(3, 4, 3, 4);
            btnFacturas.Name = "btnFacturas";
            btnFacturas.Size = new Size(150, 41);
            btnFacturas.TabIndex = 26;
            btnFacturas.Text = "Facturas";
            btnFacturas.UseVisualStyleBackColor = true;
            btnFacturas.Click += btnFacturas_Click_1;
            // 
            // BotonesFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 608);
            Controls.Add(BtnAtrasFacturas);
            Controls.Add(btnGarantias);
            Controls.Add(BtnRepuestoUsado);
            Controls.Add(btnFacturas);
            Name = "BotonesFacturas";
            Text = "BotonesFacturas";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAtrasFacturas;
        private Button btnGarantias;
        private Button BtnRepuestoUsado;
        private Button btnFacturas;
    }
}