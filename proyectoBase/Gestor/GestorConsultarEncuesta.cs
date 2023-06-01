using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoBase.Entidades;
using proyectoBase;



namespace proyectoBase.Gestor
{
	public class GestorConsultarEncuesta
	{
		/*******************/
		public List<Llamada> llamadas;
		public List<Llamada> llamadasConEncuesta;
		public Llamada llamadaSeleccionada;

		public List<Llamada> LlamadasDelGestor
		{
			get => llamadas;
			set => llamadas = value;
		}
		public List<Llamada> LlamadasConEncuestaDelGestor
		{
			get => llamadasConEncuesta;
			set => llamadasConEncuesta = value;
		}
		public Llamada LlamadaSeleccionadaGestor
		{
			get => llamadaSeleccionada;
			set => llamadaSeleccionada = value;
		}

		// private List<CambioEstado> cambioEstado;


		/*******************/
		// seria la relacion con la pantalla ? 
		//private ConsultarEncuestasForm PantallaConsultarEncuesta;

		public GestorConsultarEncuesta()
		{
			/*******************DATA MOCK*************************/
			//List<Estado> personas = new List<Estado>();
			
			//----------------------------------------- ESTADO -------------------------------------------------------
			Estado estado1 = new Estado("Finalizada");
			Estado estado2 = new Estado("Iniciada");

			// -------------------------------------- CAMBIO ESTADO --------------------------------------------------
			
			//cambios de  estados para la llamada1 
			CambioEstado cambioEstado11 = new CambioEstado(DateTime.Parse("2023-05-12"), estado1);
			CambioEstado cambioEstado12 = new CambioEstado(DateTime.Parse("2023-05-23"), estado2);
			List<CambioEstado> cambioEstado1 = new List <CambioEstado>();
			cambioEstado1.Add(cambioEstado11);
			cambioEstado1.Add(cambioEstado12);

			//cambios de estados para la llamada2
			CambioEstado cambioEstado21 = new CambioEstado(DateTime.Parse("2023-05-01"), estado1);
			CambioEstado cambioEstado22 = new CambioEstado(DateTime.Parse("2023-05-21"), estado2);
			List<CambioEstado> cambioEstado2 = new List <CambioEstado>();
			cambioEstado2.Add(cambioEstado21);
			cambioEstado2.Add(cambioEstado22);

			//cambios de estados para la llamada 3
			CambioEstado cambioEstado31 = new CambioEstado(DateTime.Parse("2023-05-12"), estado1);
			CambioEstado cambioEstado32 = new CambioEstado(DateTime.Parse("2023-06-13"), estado2);
			List<CambioEstado> cambioEstado3 = new List <CambioEstado>();
			cambioEstado3.Add(cambioEstado31);
			cambioEstado3.Add(cambioEstado32);

			// Cambios de estados para la llamada 4
			CambioEstado cambioEstado41 = new CambioEstado(DateTime.Parse("2023-05-05"), estado1);
			CambioEstado cambioEstado42 = new CambioEstado(DateTime.Parse("2023-05-10"), estado2);
			List<CambioEstado> cambioEstado4 = new List<CambioEstado>();
			cambioEstado4.Add(cambioEstado41);
			cambioEstado4.Add(cambioEstado42);

			// Cambios de estados para la llamada 5
			CambioEstado cambioEstado51 = new CambioEstado(DateTime.Parse("2023-06-20"), estado1);
			CambioEstado cambioEstado52 = new CambioEstado(DateTime.Parse("2023-07-01"), estado2);
			List<CambioEstado> cambioEstado5 = new List<CambioEstado>();
			cambioEstado5.Add(cambioEstado51);
			cambioEstado5.Add(cambioEstado52);

			// Cambios de estados para la llamada 6
			CambioEstado cambioEstado61 = new CambioEstado(DateTime.Parse("2023-08-15"), estado1);
			CambioEstado cambioEstado62 = new CambioEstado(DateTime.Parse("2023-09-05"), estado2);
			List<CambioEstado> cambioEstado6 = new List<CambioEstado>();
			cambioEstado6.Add(cambioEstado61);
			cambioEstado6.Add(cambioEstado62);
			//faltarian 7 cambios de estados para otras 7 llamadas

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
			
			//CORREGIR TODAS LAS RESPUESTAS POSBILES GENERAR PRIMERO LOS OBJETOS INDIVUALES
			//LUEGO RECIEN AGREGARLOS A LAS LISTAS
			//UNIR LOS OBJETOS INDIVIDUALES CON RESP CLIENTE

			RespuestaPosible respuestaPosible11 = new RespuestaPosible("Por ejemplo, un puntaje de 1 a 10 para evaluar la calidad de la llamada telefónica.", 123);
			RespuestaPosible respuestaPosible12 = new RespuestaPosible("1: SI, 2: NO, ¿Te gustaría recibir llamadas telefónicas para participar en encuestas?", 456);
			RespuestaPosible respuestaPosible13 = new RespuestaPosible("Por ejemplo, una escala de satisfacción de 1 a 10 para evaluar tu experiencia durante la llamada telefónica.", 789);
			List<RespuestaPosible> respuestaPregunta1 = new List<RespuestaPosible>();
			respuestaPregunta1.Add(respuestaPosible11);
			respuestaPregunta1.Add(respuestaPosible12);
			respuestaPregunta1.Add(respuestaPosible13);

			
			RespuestaPosible respuestaPosible21 = new RespuestaPosible("1: Verdadero, 0: Falso, ¿Has recibido llamadas telefónicas previas relacionadas con encuestas?", 234);
			RespuestaPosible respuestaPosible22 = new RespuestaPosible("Por ejemplo, una opción de horarios: 1 para la mañana, 2 para la tarde, para preferir recibir llamadas de encuestas.", 567);
			RespuestaPosible respuestaPosible23 = new RespuestaPosible("Por ejemplo, un puntaje de 1 a 10 para evaluar la claridad de las preguntas durante la llamada telefónica.", 890);
			List<RespuestaPosible> respuestaPregunta2 = new List<RespuestaPosible>();
			respuestaPregunta2.Add(respuestaPosible21);
			respuestaPregunta2.Add(respuestaPosible22);
			respuestaPregunta2.Add(respuestaPosible23);


			RespuestaPosible respuestaPosible31 = new RespuestaPosible("Por ejemplo, una escala de 1 a 5 para evaluar la satisfacción con la duración de la llamada telefónica.", 345);
			RespuestaPosible respuestaPosible32 = new RespuestaPosible("Por ejemplo, una opción de países para registrar la ubicación durante la llamada telefónica.", 678);
			List<RespuestaPosible> respuestaPregunta3 = new List<RespuestaPosible>();
			respuestaPregunta3.Add(respuestaPosible31);
			respuestaPregunta3.Add(respuestaPosible32);

			
			RespuestaPosible respuestaPosible41 = new RespuestaPosible("1: Masculino, 2: Femenino, ¿Cuál es tu género según el registro telefónico?", 901);
			RespuestaPosible respuestaPosible42 = new RespuestaPosible("Por ejemplo, una opción de símbolos: +, -, *, / para indicar tu nivel de satisfacción durante la llamada telefónica.", 432);
			RespuestaPosible respuestaPosible43 = new RespuestaPosible("Por ejemplo, una pregunta abierta para compartir cualquier comentario adicional sobre la llamada telefónica.", 765);
			List<RespuestaPosible> respuestaPregunta4 = new List<RespuestaPosible>();
			respuestaPregunta4.Add(respuestaPosible41);
			respuestaPregunta4.Add(respuestaPosible42);
			respuestaPregunta4.Add(respuestaPosible43);
		

			RespuestaPosible respuestaPosible51 = new RespuestaPosible("Por ejemplo, una escala de satisfacción de 1 a 5 para evaluar la amabilidad del operador durante la llamada telefónica.", 098);
			RespuestaPosible respuestaPosible52 = new RespuestaPosible("1: Aceptar, 2: Rechazar, ¿Estás dispuesto a participar en futuras llamadas telefónicas para encuestas?", 321);
			RespuestaPosible respuestaPosible53 = new RespuestaPosible("Por ejemplo, una opción de sabores: Vainilla, Chocolate, Fresa para registrar tus preferencias durante la llamada telefónica.", 654);
			List<RespuestaPosible> respuestaPregunta5 = new List<RespuestaPosible>();
			respuestaPregunta5.Add(respuestaPosible51);
			respuestaPregunta5.Add(respuestaPosible52);
			respuestaPregunta5.Add(respuestaPosible53);


			RespuestaPosible respuestaPosible61 = new RespuestaPosible("Por ejemplo, un nivel de acuerdo de 1 a 5 para evaluar la efectividad de la llamada telefónica para recopilar información.", 987);
			RespuestaPosible respuestaPosible62 = new RespuestaPosible("Por ejemplo, una lista de tareas pendientes que te gustaría completar durante la llamada telefónica.", 210);
			RespuestaPosible respuestaPosible63 = new RespuestaPosible("Por ejemplo, una opción de tamaños: Pequeño, Mediano, Grande para registrar tu preferencia durante la llamada telefónica.", 543);
			List<RespuestaPosible> respuestaPregunta6 = new List<RespuestaPosible>();
			respuestaPregunta6.Add(respuestaPosible61);
			respuestaPregunta6.Add(respuestaPosible62);
			respuestaPregunta6.Add(respuestaPosible63);


			RespuestaPosible respuestaPosible71 = new RespuestaPosible("1: Inglés, 2: Español, ¿En qué idioma prefieres comunicarte durante la llamada telefónica?", 876);
			RespuestaPosible respuestaPosible72 = new RespuestaPosible("Por ejemplo, una valoración de calidad de 1 a 10 para evaluar tu satisfacción general con la llamada telefónica.", 109);
			RespuestaPosible respuestaPosible73 = new RespuestaPosible("Por ejemplo, un tipo de animal: Perro, Gato, Pájaro que prefieres escuchar durante la llamada telefonica", 541);
			List<RespuestaPosible> respuestaPregunta7 = new List<RespuestaPosible>();
			respuestaPregunta7.Add(respuestaPosible71);
			respuestaPregunta7.Add(respuestaPosible72);
			respuestaPregunta7.Add(respuestaPosible73);


			RespuestaPosible respuestaPosible81 = new RespuestaPosible("En una escala del 1 al 10, ¿qué tan satisfecho estás con la calidad de la llamada que recibiste? 1 siendo muy insatisfecho y 10 siendo muy satisfecho", 432);
			RespuestaPosible respuestaPosible82 = new RespuestaPosible("¿Recibiste la información que necesitabas durante la llamada? 1: Sí 2: No",321);
			List<RespuestaPosible> respuestaPregunta8 = new List<RespuestaPosible>();
			respuestaPregunta8.Add(respuestaPosible81);
			respuestaPregunta8.Add(respuestaPosible82);


			RespuestaPosible respuestaPosible91 = new RespuestaPosible("¿El representante con el que hablaste fue amable y cortés ? (1: Sí o 2: No)", 321);
			RespuestaPosible respuestaPosible92 = new RespuestaPosible("¿La duración de la llamada fue adecuada para resolver tu consulta? (1: Sí o 2: No)",663);
			List<RespuestaPosible> respuestaPregunta9 = new List<RespuestaPosible>();
			respuestaPregunta9.Add(respuestaPosible91);
			respuestaPregunta9.Add(respuestaPosible92);


			RespuestaPosible respuestaPosible101 = new RespuestaPosible("¿Recomendarías a otros contactar a la empresa por teléfono para resolver problemas similares? (1: Sí o 2: No)",563);
			RespuestaPosible respuestaPosible102 = new RespuestaPosible("¿La llamada se desconectó o interrumpió inesperadamente durante la conversación? (1: Sí o 2: No)",421);
			List<RespuestaPosible> respuestaPregunta10 = new List<RespuestaPosible>();
			respuestaPregunta10.Add(respuestaPosible101);
			respuestaPregunta10.Add(respuestaPosible102);

			// ---------------------------------- PREGUNTAS -------------------------------------------------------



			Pregunta preguntas1 = new Pregunta("¿Podrías proporcionar más detalles sobre los aspectos que influyeron en tu nivel de satisfacción con la calidad de la llamada telefónica?", respuestaPregunta1);
			Pregunta preguntas2 = new Pregunta("¿Qué razones te llevan a preferir o no recibir llamadas telefónicas para encuestas?", respuestaPregunta2);
			Pregunta preguntas3 = new Pregunta("¿Hay algún aspecto específico durante la llamada telefónica que te gustaría destacar como positivo o negativo en tu experiencia?", respuestaPregunta3);
			Pregunta preguntas4 = new Pregunta("¿En qué horario del día te resulta más conveniente recibir llamadas para participar en encuestas?", respuestaPregunta4);
			Pregunta preguntas5 = new Pregunta("¿Puedes mencionar algún ejemplo o situación en la que hayas encontrado claridad o falta de claridad en las preguntas durante la llamada telefónica?", respuestaPregunta5);
			Pregunta preguntas6 = new Pregunta("¿Hay alguna sugerencia que tengas para mejorar la duración de las llamadas telefónicas relacionadas con encuestas?", respuestaPregunta6);
			Pregunta preguntas7 = new Pregunta("¿Qué factores consideras más importantes al evaluar la efectividad de la llamada telefónica para recopilar información?", respuestaPregunta7);
			Pregunta preguntas8 = new Pregunta("¿Recibiste una respuesta o solución satisfactoria a tu consulta durante la llamada?", respuestaPregunta8);
			Pregunta preguntas9 = new Pregunta("¿Experimentaste algún problema de conexión o calidad de sonido durante la llamada?", respuestaPregunta9);
			Pregunta preguntas10 = new Pregunta("¿El tiempo de espera para ser atendido por un representante fue razonable?", respuestaPregunta10);
			// -------------------------------------- ENCUESTAS -----------------------------------------------------


			List <Pregunta> preguntasEncuesta1 = new List<Pregunta>();
			preguntasEncuesta1.Add(preguntas1);
			preguntasEncuesta1.Add(preguntas2);
			preguntasEncuesta1.Add(preguntas3);
			preguntasEncuesta1.Add(preguntas4);
			preguntasEncuesta1.Add(preguntas5);

			List<Pregunta> preguntasEncuesta2 = new List<Pregunta>();
			preguntasEncuesta2.Add(preguntas6);
			preguntasEncuesta2.Add(preguntas7);
			preguntasEncuesta2.Add(preguntas8);
			preguntasEncuesta2.Add(preguntas9);
			preguntasEncuesta2.Add(preguntas10);

			// creo que faltarian como min una encuesta mas 
			Encuesta encuesta1 = new Encuesta("Encuesta 1", preguntasEncuesta1);
			Encuesta encuesta2 = new Encuesta("Encuesta 2", preguntasEncuesta2);


			// ATENCION!!!!!!!!

			// Carlos faltaria realizar RdC y Llamada

			// PARA MI EL SISTEMA EN TOTAL DEBERIA TENER MINIMO 10 LLAMADAS (faltan clientes)
			// ALGUNAS SIN RESPUESTA DE CLIENTE Y OTRAS CON MAX 3 
			// ALGUNAS CON ESTADO FINALIZA OTRAS CANCELADAS
			// --------------------------------------RESPUESTA DE CLIENTE -----------------------------------------------------

			// tengo dudas sobre la coherencia entre el atributo fechaEncuesta de este objeto y las otras fechas del sistema

			// Rdc para la llamada nro 1 
			RespuestaCliente respuestaDeEncuesta11 = new RespuestaCliente(DateTime.Parse("2015-02-13"),respuestaPosible11);
			RespuestaCliente respuestaDeEncuesta12 = new RespuestaCliente(DateTime.Parse("2015-02-13"),respuestaPosible12);
			RespuestaCliente respuestaDeEncuesta13 = new RespuestaCliente(DateTime.Parse("2015-02-13"),respuestaPosible13);
			
			List<RespuestaCliente> respuestaDeEncuesta1 = new List<RespuestaCliente>();
			respuestaDeEncuesta1.Add(respuestaDeEncuesta11);
			respuestaDeEncuesta1.Add(respuestaDeEncuesta12);
			respuestaDeEncuesta1.Add(respuestaDeEncuesta13);
			
			// Rdc para la llamada nro 2
			RespuestaCliente respuestaDeEncuesta21 = new RespuestaCliente(DateTime.Parse("2015-02-13"),respuestaPosible21);
			RespuestaCliente respuestaDeEncuesta22 = new RespuestaCliente(DateTime.Parse("2015-02-13"),respuestaPosible22);
			
			List<RespuestaCliente> respuestaDeEncuesta2 = new List<RespuestaCliente>();
			respuestaDeEncuesta2.Add(respuestaDeEncuesta21);
			respuestaDeEncuesta2.Add(respuestaDeEncuesta22);
						
			// Rdc para la llamada nro 3
			RespuestaCliente respuestaDeEncuesta31 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible31);
			RespuestaCliente respuestaDeEncuesta32 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible32);
			List<RespuestaCliente> respuestaDeEncuesta3 = new List<RespuestaCliente>();
			respuestaDeEncuesta3.Add(respuestaDeEncuesta31);
			respuestaDeEncuesta3.Add(respuestaDeEncuesta32);


			// Rdc para la llamada nro 4 
			RespuestaCliente respuestaDeEncuesta41 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible41);
			RespuestaCliente respuestaDeEncuesta42 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible42);
			List<RespuestaCliente> respuestaDeEncuesta4 = new List<RespuestaCliente>();
			respuestaDeEncuesta4.Add(respuestaDeEncuesta41);
			respuestaDeEncuesta4.Add(respuestaDeEncuesta42);


			// Rdc para la llamada nro 5
			RespuestaCliente respuestaDeEncuesta51 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible51);
			List<RespuestaCliente> respuestaDeEncuesta5 = new List<RespuestaCliente>();
			respuestaDeEncuesta5.Add(respuestaDeEncuesta51);
			
			// Rdc para la llamada nro 6
			RespuestaCliente respuestaDeEncuesta61 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible61);
			RespuestaCliente respuestaDeEncuesta62 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible62);
			RespuestaCliente respuestaDeEncuesta63 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible63);
			List<RespuestaCliente> respuestaDeEncuesta6 = new List<RespuestaCliente>();
			respuestaDeEncuesta6.Add(respuestaDeEncuesta61);
			respuestaDeEncuesta6.Add(respuestaDeEncuesta62);
			respuestaDeEncuesta6.Add(respuestaDeEncuesta63);
			
			// Rdc para la llamada nro 7
			RespuestaCliente respuestaDeEncuesta71 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible71);
			RespuestaCliente respuestaDeEncuesta72 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible72);
			RespuestaCliente respuestaDeEncuesta73 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible73);
			List<RespuestaCliente> respuestaDeEncuesta7 = new List<RespuestaCliente>();
			respuestaDeEncuesta7.Add(respuestaDeEncuesta71);
			respuestaDeEncuesta7.Add(respuestaDeEncuesta72);
			respuestaDeEncuesta7.Add(respuestaDeEncuesta73);
			
			// Rdc para la llamada nro 8
			// no tiene rdc pq fue cancelada, ojo con la coherencia !!
			// la llamada 8 no deberia pasar los filtros

			// Rdc para la llamada nro 9
			RespuestaCliente respuestaDeEncuesta91 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible91);
			List<RespuestaCliente> respuestaDeEncuesta9 = new List<RespuestaCliente>();
			respuestaDeEncuesta9.Add(respuestaDeEncuesta91);
		

			
			// Rdc para la llamada nro 10
			RespuestaCliente respuestaDeEncuesta101 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible101);
			RespuestaCliente respuestaDeEncuesta102 = new RespuestaCliente(DateTime.Parse("2015-02-13"), respuestaPosible102);
			List<RespuestaCliente> respuestaDeEncuesta10 = new List<RespuestaCliente>();
			respuestaDeEncuesta10.Add(respuestaDeEncuesta101);
			respuestaDeEncuesta10.Add(respuestaDeEncuesta102);

			// LLAMADAS -10 MINIMO-. DIFERENTES ENTRE SI PARA VER SI EL CDU FILTRA CORRECTAMENTE
			Llamada llamada1 = new Llamada("descLlamada1", "detalleEncuestaLLamada1",5,true,cliente1,respuestaDeEncuesta1, cambioEstado1);
			Llamada llamada2 = new Llamada("descLlamada2", "detalleEncuestaLLamada2",5,false,cliente2,respuestaDeEncuesta2, cambioEstado2);
			Llamada llamada3 = new Llamada("descLlamada3", "detalleEncuestaLLamada3",1,true,cliente3,respuestaDeEncuesta3, cambioEstado3);
			Llamada llamada4 = new Llamada("descLlamada4", "detalleEncuestaLLamada4", 12, true, cliente4, respuestaDeEncuesta4, cambioEstado4);
			Llamada llamada5 = new Llamada("descLlamada5", "detalleEncuestaLLamada5", 12, false, cliente5, respuestaDeEncuesta5, cambioEstado5);
			Llamada llamada6 = new Llamada("descLlamada6", "detalleEncuestaLLamada6", 6, true, cliente6, respuestaDeEncuesta6, cambioEstado6);

			List<Llamada> llamadas = new List<Llamada>();
			llamadas.Add(llamada1);
			llamadas.Add(llamada2);
			llamadas.Add(llamada3);
			llamadas.Add(llamada4);
			llamadas.Add(llamada5);
			llamadas.Add(llamada6);

			this.LlamadasDelGestor = llamadas;
		}

		
		public List<Llamada> buscarLlamadasEncuestasRespondidas(DateTime fechainicio, DateTime fechafin) {
			List<Llamada> llamadasConEncuesta = new List<Llamada>();
			foreach (Llamada llamada in this.LlamadasDelGestor)
			{
				bool var5 = llamada.esDePeriodo(fechainicio,fechafin);
				if(var5 == true)
                {
					llamadasConEncuesta.Add(llamada);
					MessageBox.Show("Se agrego un objeto");
				}       
                
			}
			MessageBox.Show("Llamadas con encuesta exito!");
			//ConsultarEncuestasForm.mostrarLlamadas(LlamadasConEncuestaDelGestor);
			//LlamadasCEncuesta formulario = new LlamadasCEncuesta(LlamadasConEncuestaDelGestor);
			//formulario.Show();
			return llamadasConEncuesta;
		}

		public void opcionConsultaEncuesta() {
		}
		public List<Llamada> validarPeriodo(DateTime fechainicio, DateTime fechafin)
		{
			List<Llamada> llamadaCEncuesta = new List<Llamada>();
			if (fechainicio <= fechafin)
			{
				MessageBox.Show("Es fecha valida");
				llamadaCEncuesta = this.buscarLlamadasEncuestasRespondidas(fechainicio,fechafin);
				return llamadaCEncuesta;
			}
			else
			{
				MessageBox.Show("No  Es fecha valida");
				return llamadaCEncuesta;
			}
		}

		public void tomarSeleccionArchivo() { }
		public void tomarSeleccionLlamada(Llamada llamadaSeleccionada) {
			MessageBox.Show("TOMAR LLAMADA");
			buscarDatosLlamada(llamadaSeleccionada);
			

		}
		public void buscarDatosLlamada(Llamada llamadaSeleccionada) {
			MessageBox.Show("BUSCAR DE LLAMADA");
			llamadaSeleccionada.getDatos(llamadaSeleccionada);
		}
		public void validarPeriodo() { }
		public void finCU() { }
		
	}

}
