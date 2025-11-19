using ProyectoCRUD_BD.Forms;
using System.Windows.Forms.Design;

namespace ProyectoCRUD_BD
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UIStyles.ApplyDashboardStyles(this);

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        // ===== FUNCIÓN PARA CARGAR FORM HIJO EN PANEL =====
        private void AbrirEnPanel(Form frm)
        {
            // Limpiar solo el panel de contenido
            foreach (Control c in controladorForms.Controls)
                c.Dispose();

            controladorForms.Controls.Clear();
            controladorForms.Refresh();

            // Configurar formulario hijo
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Agregarlo al panelContenido
            controladorForms.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }


        // ===== BOTONES DEL MENU =====

        private void btnIngresarClientes_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new IngresoCLientes());
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Diagnosticos());
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new IngresoEquipos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirEnPanel(new Tecnicos());
        }
    }
}
