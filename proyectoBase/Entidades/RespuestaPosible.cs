using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class RespuestaPosible
    {

        private string descripcion;
        private int valor;

        public RespuestaPosible(string descripcion, int valor)
        {
            this.valor = valor;
            this.descripcion = descripcion;

        }

        public string Descripcion 
        { 
            get => descripcion;
            set => descripcion = value;
        }
        public int Valor 
        { 
            get => valor;
            set => valor = value; 
        }

        public string getDescripcionRta()
        {
            return this.descripcion;
        }
    }
}
