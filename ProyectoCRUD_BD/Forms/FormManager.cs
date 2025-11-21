using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Windows.Forms;

namespace ProyectoCRUD_BD
{
    public static class FormManager
    {
        // Panel donde se cargan los formularios
        public static Panel PanelMenu { get; set; }
        public static Panel PanelContenido { get; set; }

        // ----- Cargar en panel del menú -----
        public static void CargarEnPanelMenu(Form formHijo)
        {
            if (PanelMenu == null)
            {
                MessageBox.Show("FormManager.PanelMenu no ha sido asignado.");
                return;
            }

            PanelMenu.Controls.Clear();

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            PanelMenu.Controls.Add(formHijo);
            formHijo.Show();
        }

        // ----- Cargar en panel de contenido -----
        public static void CargarEnPanelContenido(Form frm)
        {
            if (PanelContenido == null)
            {
                MessageBox.Show("FormManager.PanelContenido no ha sido asignado.");
                return;
            }

            foreach (Control c in PanelContenido.Controls)
                c.Dispose();

            PanelContenido.Controls.Clear();
            PanelContenido.Refresh();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            PanelContenido.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
    }
}

