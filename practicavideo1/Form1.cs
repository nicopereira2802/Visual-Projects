namespace practicavideo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtNombre.Text = "Ingrese usuario...";
            //txtContrasena.Text = "Ingrese contraseña...";
            LimpiarCampos();
        }

        private void btnMostraDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNombre.Text + " " + txtApellido.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text.Equals("") || txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Complete Nombre y Apellido por favor");
            }
            else
            {
                string nombreCompleto = "";
                nombreCompleto = txtNombre.Text + " " + txtApellido.Text;

                lstPersonas.Items.Add(nombreCompleto);

                MessageBox.Show("Persona agregada con exito");
                LimpiarCampos();

            }
            

        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btnAgregarPersona2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals(""))
            {
                MessageBox.Show("Complete Nombre y Apellido por favor");
            }
            else
            {
                string nombreCompleto = "";
                nombreCompleto = txtNombre.Text + " " + txtApellido.Text;
                DialogResult resultado = MessageBox.Show(nombreCompleto, "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(resultado == DialogResult.OK)
                {
                    lstPersonas.Items.Add(nombreCompleto);
                    MessageBox.Show("Persona agregada con exito");
                    LimpiarCampos();

                }
                else
                {
                    MessageBox.Show("No se agrega la persona");
                }
            }
        }
    }
}