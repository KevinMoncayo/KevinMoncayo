namespace FormulariosContenedores
{
    public partial class IngresoUsuario : Form
    {
        public IngresoUsuario()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblMonitor.Text = txtNombre.Text + " " + txtApellido.Text;
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}
