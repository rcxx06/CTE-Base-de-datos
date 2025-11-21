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
            helpProvider1 = new HelpProvider();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            panelMenu = new Panel();
            controladorForms = new Panel();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // panelMenu
            // 
            panelMenu.Location = new Point(12, 3);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(183, 592);
            panelMenu.TabIndex = 8;
            // 
            // controladorForms
            // 
            controladorForms.Location = new Point(213, 3);
            controladorForms.Margin = new Padding(3, 4, 3, 4);
            controladorForms.Name = "controladorForms";
            controladorForms.Size = new Size(1015, 600);
            controladorForms.TabIndex = 9;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 608);
            Controls.Add(controladorForms);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            Text = "Proyecto Bases de datos";
            Load += Main_Load;
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private HelpProvider helpProvider1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripTextBox toolStripTextBox1;
        private Panel panelMenu;
        private Panel controladorForms;
    }
}