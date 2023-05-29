using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Estado
    {
        //atributos
        private string nombre;

        //constructor
        public Estado(string nombre)
        {
            this.Nombre = nombre;
        }
        //get & set
        public string Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }

        public string getNombre()
        {
            return this.nombre;
        }

        //metodos
        public bool esFinalizada()
        {
            if (this.Nombre == "Finalizada")
            {
                return true;
            }
            return false;
        }
        public bool esIniciada()
        {
            if (this.Nombre == "Iniciada")
            {
                return true;
            }
            return false;
        }
    }
}
