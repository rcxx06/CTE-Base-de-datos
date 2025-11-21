using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCRUD_BD.Forms
{
    public partial class BotonesFacturas : Form
    {
        public BotonesFacturas()
        {
            InitializeComponent();
            UIStyles.ApplyAllStyles(this);
        }

        private void BtnAtrasFacturas_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelMenu(new BotonesInicio());
            FormManager.CargarEnPanelContenido(new Presentacion());
        }

        private void btnFacturas_Click_1(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new Facturas());
        }

        private void btnGarantias_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new Garantias());
        }

        private void BtnRepuestoUsado_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new RepuestosUsados());

        }
    }
}
