using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCRUD_BD.Forms
{
    public partial class BotonesRepuesto : Form
    {
        public BotonesRepuesto()
        {
            InitializeComponent();
        }

        private void btnAtrasRepuesto_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelMenu(new BotonesInicio());
            FormManager.CargarEnPanelContenido(new Presentacion());
            
        }

        private void btnRepuesto_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new Repuestos());
        }

        private void BtnTipoRepuesto_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new TipoRepuestos());
        }

        private void btnObtencionRepuesto_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new ObtencionRepuestos());
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new Proovedores());
        }
    }
}
