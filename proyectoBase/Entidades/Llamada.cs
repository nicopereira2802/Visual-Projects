
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoBase.Entidades
{

    public class Llamada
    {

        // atributos
        private string descripcionOperador;
        private string detalleEncuesta;
        // es int o datetime 
        private int duracion;
        private bool encuestaEnviada;
        private Cliente cliente;
        private List<RespuestaCliente> respuestaDeEncuesta;
        private List<CambioEstado> cambioEstado;
        //constructor
        public Llamada(string descripcionOperador, string detalleEncuesta, int duracion, bool encuestaEnviada, Cliente cliente, List<RespuestaCliente> respuestaDeEncuesta, List<CambioEstado> cambioEstado)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleEncuesta = detalleEncuesta;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.cliente = cliente;
            this.respuestaDeEncuesta = respuestaDeEncuesta;
            this.cambioEstado = cambioEstado;
        }

        // set & get
        public string DescripcionOperador
        {
            get => descripcionOperador;
            set => descripcionOperador = value;
        }
        public string DetalleEncuesta
        {
            get => detalleEncuesta;
            set => detalleEncuesta = value;
        }
        public int Duracion
        {
            get => duracion;
            set => duracion = value;
        }
        public bool EncuestaEnviada
        {
            get => encuestaEnviada;
            set => encuestaEnviada = value;
        }
        public Cliente Llcliente
        {
            get => cliente;
            set => cliente = value;
        }
        public List<RespuestaCliente> RespuestaDeEncuesta
        {
            get => respuestaDeEncuesta;
            set => respuestaDeEncuesta = value;
        }
        //metodos
       
        public List<CambioEstado> CambioEstado
        {
            get => cambioEstado;
            set => cambioEstado = value;
        }

        public bool esDePeriodo(DateTime fechainicio, DateTime fechafin)
        {
            bool var4 = this.determinarEstadoInicial(fechainicio, fechafin);
            if (var4 == true)
            {
                return true;
            }
            return false;
        }
        public void getEstadoActual()
        {
            //
        }
        public void getRespuestas()
        {
            //
        }
        public bool tieneEncuestaEnviada()
        {
            if (this.encuestaEnviada == true)
            {
                return true;
            }
            return false;
        }

        public bool determinarEstadoInicial(DateTime fechainicio, DateTime fechafin)
        {
            foreach (CambioEstado cambioEstado in this.cambioEstado)
            {
                bool var1 = cambioEstado.GetNombreEstado();
                if (var1 == true)
                {
                    DateTime var2 = cambioEstado.getFechaHoraInicio();
                    if (var2 >= fechainicio && var2 <= fechafin)
                    {
                        bool var3 = tieneEncuestaEnviada();
                        if (var3 == true)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}