using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class RespuestaCliente
    {
        private DateTime fechaEncuesta;
        private RespuestaPosible respuestaPosible;
        //constructor
        public RespuestaCliente(DateTime fechaEncuesta, RespuestaPosible respuestaPosible)
        {
            this.fechaEncuesta = fechaEncuesta;
            this.respuestaPosible = respuestaPosible;
        }
        // set & get
        public DateTime FechaEncuesta 
        { 
            get => fechaEncuesta;
            set => fechaEncuesta = value;
        }
        public RespuestaPosible RespuestaPosible 
        {
            get => respuestaPosible; 
            set => respuestaPosible = value; 
        }
        public string getDescripcionRta()
        {
             return respuestaPosible.getDescripcionRta();
        }
        //public 
    }
}
