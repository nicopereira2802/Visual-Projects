using proyectoBase.Entidades;

namespace proyectoBase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario(txtUsuario.Text, txtPassword.Text);
            //MessageBox.Show("Hola " + usu.NombreDeUsuario + " " + usu.Password);
            string usuCorrecto = "nicolas";
            string passwordCorrecto = "12345";
            if (txtUsuario.Text.Equals(usuCorrecto) && txtPassword.Text.Equals(passwordCorrecto))
            {
                //se ingresa correcatmente
                //MessageBox.Show("datos correctos");
                PrincipalForm ventana = new PrincipalForm(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                //se ingresa incorrectamente
                MessageBox.Show("Ingrese valores correctos"); 
            }

        }
    }
}