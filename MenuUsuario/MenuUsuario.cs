using FormulariosContenedores;

namespace MenuUsuario
{
    public partial class MenuUsuario : Form
    {
        public MenuUsuario()
        {
            InitializeComponent();
        }

        private void ingresarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoUsuario formuser =  new IngresoUsuario();
            formuser.MdiParent = this;
            formuser.Show();
        }
    }
}
