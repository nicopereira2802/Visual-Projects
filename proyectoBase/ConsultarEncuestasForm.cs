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
    public partial class ConsultarEncuestasForm : Form

    {
        public ConsultarEncuestasForm()
        {
            InitializeComponent();
            GestorConsultarEncuesta gestorConsultarEncuesta = new GestorConsultarEncuesta();

        }

        private void ConsultarEncuestasForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarLlamadasPeriodo_Click(object sender, EventArgs e)
        {
           Escuela miEscuela = new Escuela("Mi Escuela");

            // Crear instancias de estudiantes
            Estudiante estudiante1 = new Estudiante("Juan", 15);
            Estudiante estudiante2 = new Estudiante("María", 16);

            // Agregar los estudiantes a la escuela
            miEscuela.AgregarEstudiante(estudiante1);
            miEscuela.AgregarEstudiante(estudiante2);

            if (dtmFechaInicio.Value <= dtmFechaFin.Value)
            {
                MessageBox.Show("Es fecha valida");
                foreach (Estudiante estudiante in miEscuela.Estudiantes)
                {
                    MessageBox.Show("Nombre del estudiante: " + estudiante.Nombre);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
