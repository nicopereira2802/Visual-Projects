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
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public void ConsultarEncuestasForm_Load(object sender, EventArgs e)
        {
     

        }

        public void btnBuscarLlamadasPeriodo_Click(object sender, EventArgs e)
        {
            
            DateTime fechaInicio = dtmFechaInicio.Value;
            DateTime fechaFin = dtmFechaFin.Value;

            List<Llamada> llamadasEPantalla = gestorConsultarEncuesta.validarPeriodo(fechaInicio, fechaFin);
            if (llamadasEPantalla.Count == 0)
            {
                MessageBox.Show("NO HAY LLAMADAS CON ENCUESTAS EN EL PERIODO");
            }
            else
            {
                mostrarLlamadas(llamadasEPantalla);
            }
            
        }

        public void mostrarLlamadas(List<Llamada> llamadasCEncuesta)
        {
            // Columna para la propiedad Nombre de ClasePrincipal
              // Columna para el atributo de OtraClase
            dataGridView2.DataSource = llamadasCEncuesta;
            dataGridView2.Columns["Llcliente"].Visible = true;
            
            //dataGridView2.Columns["LlCliente"].DataPropertyName = llamadasCEncuesta.cliente.NombreDeCliente;
            /*foreach (Llamada x in llamadasCEncuesta)
            
            {
                
                MessageBox.Show("llamada con encuesta goooool");
        
            }*/
            foreach (var objeto in llamadasCEncuesta)
            {
                // Agregar una nueva fila al DataGridView
                int rowIndex = dataGridView3.Rows.Add();

                // Obtener la fila recién agregada
                DataGridViewRow row = dataGridView3.Rows[rowIndex];

                // Asignar los valores de los atributos del objeto a las celdas de la fila
                row.Cells["Cliente"].Value = objeto.Llcliente.NombreDeCliente;

                // Continuar para asignar los valores de los demás atributos
            }
            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;

        }
        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {  
            // Obtener la fila seleccionada
            //dataGridView2.Rows.Insert(0,1);
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
                List<string> listaLlamadaDatos = gestorConsultarEncuesta.tomarSeleccionLlamada(llamadaSeleccionado);
                mostrarDatosLLamada(listaLlamadaDatos);
            }
        }
        public void mostrarDatosLLamada(List<string> listaLlamadaDatos)
        {
            listBox1.DataSource = listaLlamadaDatos;

            // Actualizar la vista del DataGridView
            
        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnGenerarCsv_Click(object sender, EventArgs e)
        {
            Pantalla_Generar_Csv ventana = new Pantalla_Generar_Csv(gestorConsultarEncuesta);
            this.Hide();
            ventana.Show();
            
        }
    }
}
