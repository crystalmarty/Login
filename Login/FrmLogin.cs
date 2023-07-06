namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblUsuario.Clear();
            lblContraseña.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (lblUsuario.Text == "usuario" && lblContraseña.Text == "admin")
            {
                Frminicio FrmInicio = new Frminicio();
                this.Hide();
                Frminicio.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                lblUsuario.Clear();
                lblContraseña.Clear();
            }
        }
    }
}