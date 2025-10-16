namespace FormulariosContenedores
{
    public partial class IngresoUsuario : Form
    {
        public IngresoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblMonitor.Text = "El cliente " + txtNombre.Text + " " + txtApellido.Text + " con dirección " + txtDireccion.Text + " ha siddo creado exitosamente.";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
        }
    }
}
