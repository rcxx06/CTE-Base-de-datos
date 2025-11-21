using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCRUD_BD.Forms
{
    public partial class BotonesInicio : Form
    {
        public BotonesInicio()
        {
            InitializeComponent();
        }

        private void BtnIrClientes_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelMenu(new BotonesClientes());
        }

        private void btnIrFacturas_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelMenu(new BotonesFacturas());
        }

        private void BtnirRepuesto_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelMenu(new BotonesRepuesto());
        }

        private void BtnIrPresentacion_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new Presentacion());
        }

        private void btnAtrasInicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
