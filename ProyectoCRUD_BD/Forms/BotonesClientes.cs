using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoCRUD_BD.Forms
{
    public partial class BotonesClientes : Form
    {
        public BotonesClientes()
        {
            InitializeComponent();
        }

        private void btnIngresarClientes_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new IngresoCLientes());
        }

        private void btnAtrasCliente_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelMenu(new BotonesInicio());
            FormManager.CargarEnPanelContenido(new Presentacion());
           
        }

        private void BtnEquipos_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new IngresoEquipos());
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new Diagnosticos());
        }

        private void BtnTecnicos_Click(object sender, EventArgs e)
        {
            FormManager.CargarEnPanelContenido(new Tecnicos());
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
           FormManager.CargarEnPanelContenido(new Ordenes());
        }


    }
}
