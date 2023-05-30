using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoBase.Entidades;

namespace proyectoBase.Gestor
{
	public class GestorConsultarEncuesta
	{
		/*******************/

		
 
		/*******************/
		// seria la relacion con la pantalla ? 
		private ConsultarEncuestasForm PantallaConsultarEncuesta;

		public GestorConsultarEncuesta()
		{
			/*******************DATA MOCK*************************/
			//List<Estado> personas = new List<Estado>();
			
			//----------------------------------------- ESTADO -------------------------------------------------------
			Estado estado1 = new Estado("Finalizada");
			Estado estado2 = new Estado("Iniciada");

			// -------------------------------------- CAMBIO ESTADO --------------------------------------------------
			CambioEstado cambioEstado11 = new CambioEstado(DateTime.Parse("2015-01-12"), estado1);
			CambioEstado cambioEstado12 = new CambioEstado(DateTime.Parse("2015-03-23"), estado2);
			List<CambioEstado> cambioEstado1 = new List <CambioEstado>();
			cambioEstado1.Add(cambioEstado11);
			cambioEstado1.Add(cambioEstado12);


			CambioEstado cambioEstado3 = new CambioEstado(DateTime.Parse("2015-03-01"), estado1);
			CambioEstado cambioEstado4 = new CambioEstado(DateTime.Parse("2015-03-21"), estado2);

			CambioEstado cambioEstado5 = new CambioEstado(DateTime.Parse("2015-04-12"), estado1);
			CambioEstado cambioEstado6 = new CambioEstado(DateTime.Parse("2015-02-13"), estado2);


			// ----------------------------------- CLIENTES ----------------------------------------------------------
			Cliente cliente1 = new Cliente(44399816, "Nicolas Pereira", 3513221);
			
			Cliente cliente2 = new Cliente(44399812, "Daiana Suarez", 4422334);
			
			Cliente cliente3 = new Cliente(44332323, "Facundo Messi", 4429212);
			
			Cliente cliente4 = new Cliente(44321212, "Carlos Gutierrez", 44232912);
			
			Cliente cliente5 = new Cliente(44342424, "Ulises Sanchez", 4429912);
			
			Cliente cliente6 = new Cliente(44332232, "Matias Delgado", 4429312);


			// ---------------------------------- RESPUESTAS POSIBLES -------------------------------------------------
			
			// ATENCION!!!!!!!!
			// error en no crear los objetos de la clase respuestas posibles sin un nombre como si se hizo para los cliente
			// por ej cliente4,cliente5,cliente6 ... se necesita asi a las rtas posibles para la asociacion con Respuesta Cliente
			
			List<RespuestaPosible> respuestaPregunta1 = new List<RespuestaPosible>();
			respuestaPregunta1.Add(new RespuestaPosible("Por ejemplo, un puntaje de 1 a 10 para evaluar la calidad de la llamada telefónica.", 123));
			respuestaPregunta1.Add(new RespuestaPosible("1: SI, 2: NO, ¿Te gustaría recibir llamadas telefónicas para participar en encuestas?", 456));
			respuestaPregunta1.Add(new RespuestaPosible("Por ejemplo, una escala de satisfacción de 1 a 10 para evaluar tu experiencia durante la llamada telefónica.", 789));

			
			List<RespuestaPosible> respuestaPregunta2 = new List<RespuestaPosible>();
			respuestaPregunta2.Add(new RespuestaPosible("1: Verdadero, 0: Falso, ¿Has recibido llamadas telefónicas previas relacionadas con encuestas?", 234));
			respuestaPregunta2.Add(new RespuestaPosible("Por ejemplo, una opción de horarios: 1 para la mañana, 2 para la tarde, para preferir recibir llamadas de encuestas.", 567));
			respuestaPregunta2.Add(new RespuestaPosible("Por ejemplo, un puntaje de 1 a 10 para evaluar la claridad de las preguntas durante la llamada telefónica.", 890));


			List<RespuestaPosible> respuestaPregunta3 = new List<RespuestaPosible>();
			respuestaPregunta3.Add(new RespuestaPosible("Por ejemplo, una escala de 1 a 5 para evaluar la satisfacción con la duración de la llamada telefónica.", 345));
			respuestaPregunta3.Add(new RespuestaPosible("Por ejemplo, una opción de países para registrar la ubicación durante la llamada telefónica.", 678));


			List<RespuestaPosible> respuestaPregunta4 = new List<RespuestaPosible>();
			respuestaPregunta4.Add(new RespuestaPosible("1: Masculino, 2: Femenino, ¿Cuál es tu género según el registro telefónico?", 901));
			respuestaPregunta4.Add(new RespuestaPosible("Por ejemplo, una opción de símbolos: +, -, *, / para indicar tu nivel de satisfacción durante la llamada telefónica.", 432));
			respuestaPregunta4.Add(new RespuestaPosible("Por ejemplo, una pregunta abierta para compartir cualquier comentario adicional sobre la llamada telefónica.", 765));

			
			List<RespuestaPosible> respuestaPregunta5 = new List<RespuestaPosible>();
			respuestaPregunta5.Add(new RespuestaPosible("Por ejemplo, una escala de satisfacción de 1 a 5 para evaluar la amabilidad del operador durante la llamada telefónica.", 098));
			respuestaPregunta5.Add(new RespuestaPosible("1: Aceptar, 2: Rechazar, ¿Estás dispuesto a participar en futuras llamadas telefónicas para encuestas?", 321));
			respuestaPregunta5.Add(new RespuestaPosible("Por ejemplo, una opción de sabores: Vainilla, Chocolate, Fresa para registrar tus preferencias durante la llamada telefónica.", 654));

			
			List<RespuestaPosible> respuestaPregunta6 = new List<RespuestaPosible>();
			respuestaPregunta6.Add(new RespuestaPosible("Por ejemplo, un nivel de acuerdo de 1 a 5 para evaluar la efectividad de la llamada telefónica para recopilar información.", 987));
			respuestaPregunta6.Add(new RespuestaPosible("Por ejemplo, una lista de tareas pendientes que te gustaría completar durante la llamada telefónica.", 210));
			respuestaPregunta6.Add(new RespuestaPosible("Por ejemplo, una opción de tamaños: Pequeño, Mediano, Grande para registrar tu preferencia durante la llamada telefónica.", 543));

			List<RespuestaPosible> respuestaPregunta7 = new List<RespuestaPosible>();
			respuestaPregunta7.Add(new RespuestaPosible("1: Inglés, 2: Español, ¿En qué idioma prefieres comunicarte durante la llamada telefónica?", 876));
			respuestaPregunta7.Add(new RespuestaPosible("Por ejemplo, una valoración de calidad de 1 a 10 para evaluar tu satisfacción general con la llamada telefónica.", 109));
			respuestaPregunta7.Add(new RespuestaPosible("Por ejemplo, un tipo de animal: Perro, Gato, Pájaro que prefieres escuchar durante la llamada telefonica", 541));


			
			
			
			// ---------------------------------- PREGUNTAS -------------------------------------------------------
			
			
			
      		Pregunta preguntas1 = new Pregunta("¿Podrías proporcionar más detalles sobre los aspectos que influyeron en tu nivel de satisfacción con la calidad de la llamada telefónica?", respuestaPregunta1);
			Pregunta preguntas2 = new Pregunta("¿Qué razones te llevan a preferir o no recibir llamadas telefónicas para encuestas?", respuestaPregunta2);
			Pregunta preguntas3 = new Pregunta("¿Hay algún aspecto específico durante la llamada telefónica que te gustaría destacar como positivo o negativo en tu experiencia?", respuestaPregunta3);
			Pregunta preguntas4 = new Pregunta("¿En qué horario del día te resulta más conveniente recibir llamadas para participar en encuestas?", respuestaPregunta4);
			Pregunta preguntas5 = new Pregunta("¿Puedes mencionar algún ejemplo o situación en la que hayas encontrado claridad o falta de claridad en las preguntas durante la llamada telefónica?", respuestaPregunta5);
			Pregunta preguntas6 = new Pregunta("¿Hay alguna sugerencia que tengas para mejorar la duración de las llamadas telefónicas relacionadas con encuestas?", respuestaPregunta6);
			Pregunta preguntas7 = new Pregunta("¿Qué factores consideras más importantes al evaluar la efectividad de la llamada telefónica para recopilar información?", respuestaPregunta7);

			// -------------------------------------- ENCUESTAS -----------------------------------------------------

			
			List<Pregunta> preguntasEncuesta1 = new List<Pregunta>();
			preguntasEncuesta1.Add(preguntas1);
			preguntasEncuesta1.Add(preguntas2);
			preguntasEncuesta1.Add(preguntas3);
			preguntasEncuesta1.Add(preguntas4);
			preguntasEncuesta1.Add(preguntas5);
			preguntasEncuesta1.Add(preguntas6);
			preguntasEncuesta1.Add(preguntas7);

			Encuesta encuesta = new Encuesta("Encuesta 1", preguntasEncuesta1);
			
			// ATENCION!!!!!!!!

			// Carlos faltaria realizar RdC y Llamada
			
			// PARA MI EL SISTEMA EN TOTAL DEBERIA TENER MINIMO 10 LLAMADAS (faltan clientes)
			// ALGUNAS SIN RESPUESTA DE CLIENTE Y OTRAS CON MAX 3 
			// ALGUNAS CON ESTADO FINALIZA OTRAS CANCELADAS
			// --------------------------------------RESPUESTA DE CLIENTE -----------------------------------------------------
			
			// tengo dudas sobre la coherencia entre el atributo fechaEncuesta de este objeto y las otras fechas del sistema

			// Rdc para la llamada nro 1 
			RespuestaCliente respuestaCliente11 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente12 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente13 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta1 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente11);
			respuestaCliente1.Add(respuestaCliente12);
			respuestaCliente1.Add(respuestaCliente13);
			// Rdc para la llamada nro 2
			RespuestaCliente respuestaCliente21 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente22 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta2 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente21);
			respuestaCliente1.Add(respuestaCliente22);			
			// Rdc para la llamada nro 3
			RespuestaCliente respuestaCliente31 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente32 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta3 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente31);
			respuestaCliente1.Add(respuestaCliente32);
			// Rdc para la llamada nro 4 
			RespuestaCliente respuestaCliente41 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente42 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta4 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente41);
			respuestaCliente1.Add(respuestaCliente42);
			// Rdc para la llamada nro 5
			RespuestaCliente respuestaCliente5 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta5 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente5);
			
			// Rdc para la llamada nro 6
			RespuestaCliente respuestaCliente61 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente62 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente63 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta6 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente61);
			respuestaCliente1.Add(respuestaCliente62);
			respuestaCliente1.Add(respuestaCliente63);
			
			// Rdc para la llamada nro 7
			RespuestaCliente respuestaCliente71 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente72 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente73 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta7 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente71);
			respuestaCliente1.Add(respuestaCliente72);
			respuestaCliente1.Add(respuestaCliente73);
			
			// Rdc para la llamada nro 8
			// no tiene rdc pq fue cancelada, ojo con la coherencia !!
			// la llamada 8 no deberia pasar los filtros

			// Rdc para la llamada nro 9
			RespuestaCliente respuestaCliente91 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente92 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente93 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta9 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente91);
			respuestaCliente1.Add(respuestaCliente92);
			respuestaCliente1.Add(respuestaCliente93);
			
			// Rdc para la llamada nro 10
			RespuestaCliente respuestaCliente101 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			RespuestaCliente respuestaCliente102 = new RespuestaCliente(DateTime.Parse("2015-02-13"),);
			List<RespuestaCliente> respuestaDeEncuesta10 = new List<RespuestaCliente>();
			respuestaCliente1.Add(respuestaCliente101);
			respuestaCliente1.Add(respuestaCliente102);
			// LLAMADAS -10 MINIMO-. DIFERENTES ENTRE SI PARA VER SI EL CDU FILTRA CORRECTAMENTE
			LLamada llamada1 = new Llamada("descLlamada1", "detalleEncuestaLLamada1",1,true,cliente1,respuestaCliente1, cambioEstado1);
			LLamada llamada2 = new Llamada("descLlamada1", "detalleEncuestaLLamada1",1,true,cliente1,respuestaCliente1, cambioEstado1);
			LLamada llamada3 = new Llamada("descLlamada1", "detalleEncuestaLLamada1",1,true,cliente1,respuestaCliente1, cambioEstado1);
			LLamada llamada4 = new Llamada("descLlamada1", "detalleEncuestaLLamada1",1,true,cliente1,respuestaCliente1, cambioEstado1);

		}


		public void buscarLlamadas() { }
		public void finCU() { }
		public void getDatosLlamada() { }
		public void nuevaConsultaEncuesta() { }
		public void pedirPeriodo() { }
		public void tomarSeleccionArchivo() { }
		public void tomarSeleccionLlamada() { }
		public void validarPeriodo() { }
	}
}