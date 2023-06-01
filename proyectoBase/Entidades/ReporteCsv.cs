using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class ReporteCsv
    {
        // Propiedades del estudiante
        public List<string> encabezado { get; set; }
        public List<string> preguntas{ get; set; }
  

        // Constructor
        public ReporteCsv(List<string>  encabezado, List<string> preguntas)
        {
            this.encabezado = encabezado;
            this.preguntas = preguntas;
        }
    }

}
