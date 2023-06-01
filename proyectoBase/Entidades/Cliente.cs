using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class Cliente
    {
        public int dni;
        public string nombreCompleto;
        public int nroCelular;

        public Cliente(int dni, string nombreCompleto, int nroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
        }

        public int Dni
        {
            get => dni;
            set => dni = value;
        }
        public string NombreDeCliente
        {
            get => nombreCompleto;
            set => nombreCompleto = value;
        }
        public int NroDeCelular
        {
            get => nroCelular;
            set => nroCelular = value;
        }
        public string getNombreCliente()
        {
            return this.nombreCompleto;
        }
    }
}
