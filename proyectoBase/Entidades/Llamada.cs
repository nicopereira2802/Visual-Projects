
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
        public void esDePeriodo()
        {
            //
        }
        public void getEstadoActual()
        {
            //
        }
        public void getRespuestas()
        {
            //
        }
        public void tieneEncuestaRespondida()
        {
            //
        }
    }
}