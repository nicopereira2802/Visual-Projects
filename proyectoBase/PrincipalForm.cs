using proyectoBase.Entidades;
using proyectoBase.Gestor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoBase
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm(Usuario usu)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido " + usu.NombreDeUsuario;
            lblBienvenida.Visible = true;

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarEncuesta_Click(object sender, EventArgs e)
        {
            ConsultarEncuestasForm ventana = new ConsultarEncuestasForm();
            GestorConsultarEncuesta gestor = new GestorConsultarEncuesta();

            ventana.Show();
            this.Hide();
    
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
