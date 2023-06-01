using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyectoBase.Gestor;
using proyectoBase.Entidades;
using System.Threading;

namespace proyectoBase
{
    public partial class Pantalla_Generar_Csv : Form
    {
        public Pantalla_Generar_Csv(GestorConsultarEncuesta gestorConsultarEncuesta)
        {
            InitializeComponent();
            ReporteCsv nuevoCsv = gestorConsultarEncuesta.generarCsv();
            bool var4 = mostrar_csv(nuevoCsv);
            if (var4)
            {
                gestorConsultarEncuesta.finCU();
            }

            
        }
    

        private void Pantalla_Generar_Csv_Load(object sender, EventArgs e)
        {
          
        }
        private bool mostrar_csv(ReporteCsv nuevoCsv)
        {

            foreach(string var in nuevoCsv.encabezado)
            {
                listBox1.Items.Add(var);
            }
            //listBox1.DataSource = nuevoCsv.encabezado;
            listBox1.Items.Add("--------------");
            //listBox1.DataSource = nuevoCsv.preguntas;
            foreach(string var2 in nuevoCsv.preguntas)
            {
                listBox1.Items.Add(var2);
                listBox1.Items.Add("--------------");
                
            }

            return true;

        }

        
    }
}
