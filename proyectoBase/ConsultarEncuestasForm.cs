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
        //public List<Llamada> ListaDelGestor;
        GestorConsultarEncuesta gestorConsultarEncuesta = new GestorConsultarEncuesta();
       
        public ConsultarEncuestasForm()
        {
            InitializeComponent();
          
        }


        public void ConsultarEncuestasForm_Load(object sender, EventArgs e)
        {
            // Inicializar la lista de clases con datos de ejemplo
            // Asignar la lista de clases al control DataGridView
            /*
            foreach (var objeto in ListaDelGestor)
            {
                // Agregar una nueva fila al DataGridView
                int rowIndex = dataGridView2.Rows.Add();

                // Obtener la fila recién agregada
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                // Asignar los valores de los atributos del objeto a las celdas de la fila
                row.Cells["DescripcionO"].Value = objeto.DescripcionOperador;
                row.Cells["DetalleAccion"].Value = objeto.DetalleEncuesta;
                // Continuar para asignar los valores de los demás atributos
            }*/

        }

        public void btnBuscarLlamadasPeriodo_Click(object sender, EventArgs e)
        {

            DateTime fechaInicio = dtmFechaInicio.Value;
            DateTime fechaFin = dtmFechaFin.Value;

            List<Llamada> llamadasEPantalla = gestorConsultarEncuesta.validarPeriodo(fechaInicio, fechaFin);
            if (llamadasEPantalla.Count == 0)
            {
                MessageBox.Show("NO HAY LLAMADAS EN EL PERIODO");
            }
            else
            {
                mostrarLlamadas(llamadasEPantalla);
            }
            
        }

        public void mostrarLlamadas(List<Llamada> llamadasCEncuesta)
        {
            dataGridView2.DataSource = llamadasCEncuesta;
            foreach (Llamada x in llamadasCEncuesta)
            {
                
                MessageBox.Show("llamada con encuesta goooool");
                DataGridViewTextBoxColumn DescripcionOperador = new DataGridViewTextBoxColumn();
                //DescripcionOperador.DataPropertyName = "DescripcionO";
                //DescripcionOperador.HeaderText = "DescripcionO";
                dataGridView2.Columns.Add(DescripcionOperador);
                /*
                // Agregar una nueva fila al DataGridView
                int rowIndex = dataGridView2.Rows.Add();

                // Obtener la fila recién agregada
                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                // Asignar los valores de los atributos del objeto a las celdas de la fila
                row.Cells["DescripcionO"].Value = x.DescripcionOperador;
                row.Cells["DetalleAccion"].Value = x.DetalleEncuesta;
                row.Cells["EncuestaE"].Value = x.EncuestaEnviada;
                row.Cells["Duracion"].Value = x.Duracion;
                row.Cells["Cliente"].Value = x.Llcliente.NombreDeCliente;

                // Continuar para asignar los valores de los demás atributos*/
            }
           
            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;
        }
        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // Obtener la fila seleccionada
            DataGridViewRow selectedRow = dataGridView2.CurrentRow;

            // Verificar si se ha seleccionado una fila
            if (selectedRow != null)
            {
                // Obtener los valores de las celdas de la fila seleccionada
                Llamada llamadaSeleccionado = (Llamada)selectedRow.DataBoundItem;

                // Realizar cualquier otra acción que necesites con el objeto seleccionado
                // ...
                // Ejemplo de mostrar una propiedad del objeto en un MessageBox
                MessageBox.Show($"Se ha seleccionado el objeto: Propiedad1={llamadaSeleccionado.DescripcionOperador}");
                gestorConsultarEncuesta.tomarSeleccionLlamada(llamadaSeleccionado);
            }
        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }



    }
}
