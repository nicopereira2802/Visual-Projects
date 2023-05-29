using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado estado;
        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.Estado = estado;
        }

        public DateTime FechaHoraInicio 
        { 
            get => fechaHoraInicio;
            set => fechaHoraInicio = value;
        }
        public Estado Estado 
        {
            get => estado;
            set => estado = value;
        }

        public string GetNombreEstado()
        {
            //
            return (this.Estado.getNombre());
        }

        public bool esEstadoInicial()
        {
            return (this.Estado.esIniciada());
        }

        public bool esUltimoEstado()
        {
            return (this.Estado.esFinalizada());
        }

    }
}
