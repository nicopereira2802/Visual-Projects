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
        GestorConsultarEncuesta gestorConsultarEncuesta = new GestorConsultarEncuesta();
        public ConsultarEncuestasForm()
        {
            InitializeComponent();

        }

        public void ConsultarEncuestasForm_Load(object sender, EventArgs e)
        {

        }

        public void btnBuscarLlamadasPeriodo_Click(object sender, EventArgs e)
        {

            DateTime fechaInicio = dtmFechaInicio.Value;
            DateTime fechaFin = dtmFechaFin.Value;
            gestorConsultarEncuesta.validarPeriodo(fechaInicio, fechaFin);
        }
 
        public void btnCancelar_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
