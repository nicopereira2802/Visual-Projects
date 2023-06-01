using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class RespuestaPosible
    {

        public string descripcion;
        public int valor;
        public Pregunta Pregunta { get; set; }
        public RespuestaPosible(string descripcion, int valor)
        {
            this.valor = valor;
            this.descripcion = descripcion;

        }

        public string getDescripcionRta()
        {
            return this.descripcion;
        }
        public string getPregunta()
        {
            return Pregunta.getDescripcion();
        }
        
    }
}
