using ProyectoCRUD_BD.Forms;
using System.Windows.Forms.Design;

namespace ProyectoCRUD_BD
{

    
    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
           
            UIStyles.ApplyAllStyles(this);
            
            // Registras los paneles en el FormManager
            FormManager.PanelMenu = panelMenu;
            FormManager.PanelContenido = controladorForms;

            // Cargar algo por defecto
            FormManager.CargarEnPanelMenu(new BotonesInicio());

            
        }
        
       

        private void Main_Load(object sender, EventArgs e)
        {

        }


        // ===== BOTONES DEL MENU =====

 
    }
}
