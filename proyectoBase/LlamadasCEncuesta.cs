using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoBase.Entidades;
using proyectoBase.Gestor;

namespace proyectoBase
{
    public partial class LlamadasCEncuesta : Form
    {
        public List<Llamada> ListaDelGestor;

        public LlamadasCEncuesta(List<Llamada> ListaEncuestas)
        {
            InitializeComponent();
            ListaDelGestor = ListaEncuestas;
            foreach (Llamada llamada in ListaDelGestor)
            {
                MessageBox.Show("LLAMADA AGREGADA");
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            foreach (var objeto in ListaDelGestor)
            {
                // Agregar una nueva fila al DataGridView
                int rowIndex = dataGridView1.Rows.Add();

                // Obtener la fila recién agregada
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                // Asignar los valores de los atributos del objeto a las celdas de la fila
                row.Cells["DescripcionO"].Value = objeto.DescripcionOperador;
                row.Cells["DetalleAccion"].Value = objeto.DetalleEncuesta;
                row.Cells["EncuestaE"].Value = objeto.EncuestaEnviada;
                row.Cells["Duracion"].Value = objeto.Duracion;
                row.Cells["Observacion"].Value = objeto.Llcliente.NombreDeCliente;

                // Continuar para asignar los valores de los demás atributos
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = ListaDelGestor;
        }
    }
}
