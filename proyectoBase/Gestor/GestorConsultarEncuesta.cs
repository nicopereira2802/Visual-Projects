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
		/*********************************************************/

		
 
		/*********************************************************/
		// seria la relacion con la pantalla ? 
		private ConsultarEncuestasForm PantallaConsultarEncuesta;

		public GestorConsultarEncuesta()
		{
			/**********************************************************DATA MOCK************************************************************************/
			//List<Estado> personas = new List<Estado>();
			Estado estado1 = new Estado("Finalizada");
			Estado estado2 = new Estado("Iniciada");

			CambioEstado cambioEstado1 = new CambioEstado(DateTime.Parse("2015-01-12"), estado1);
			CambioEstado cambioEstado2 = new CambioEstado(DateTime.Parse("2015-03-23"), estado2);

			CambioEstado cambioEstado3 = new CambioEstado(DateTime.Parse("2015-03-01"), estado1);
			CambioEstado cambioEstado4 = new CambioEstado(DateTime.Parse("2015-03-21"), estado2);

			CambioEstado cambioEstado5 = new CambioEstado(DateTime.Parse("2015-04-12"), estado1);
			CambioEstado cambioEstado6 = new CambioEstado(DateTime.Parse("2015-02-13"), estado2);

			Cliente cliente1 = new Cliente(44399816, "Nicolas Pereira", 3513221);
			Cliente cliente2 = new Cliente(44399812, "Daiana Suarez", 4422334);
			Cliente cliente3 = new Cliente(44332323, "Facundo Messi", 4429212);
			Cliente cliente4 = new Cliente(44321212, "Carlos Gutierrez", 44232912);
			Cliente cliente5 = new Cliente(44342424, "Ulises Sanchez", 4429912);
			Cliente cliente6 = new Cliente(44332232, "Matias Delgado", 4429312);

			List<RespuestaPosible> respuestaPregunta1 = new List<RespuestaPosible>();
			respuestaPregunta1.Add(new RespuestaPosible("La respuesta cero", 442));
			respuestaPregunta1.Add(new RespuestaPosible("La respuesta uno", 123));
			respuestaPregunta1.Add(new RespuestaPosible("La respuesta dos", 456));

			List<RespuestaPosible> respuestaPregunta2 = new List<RespuestaPosible>();
			respuestaPregunta2.Add(new RespuestaPosible("La respuesta tres", 000));
			respuestaPregunta2.Add(new RespuestaPosible("La respuesta cuatro", 234));
			respuestaPregunta2.Add(new RespuestaPosible("La respuesta cinco", 567));

			List<RespuestaPosible> respuestaPregunta3 = new List<RespuestaPosible>();
			respuestaPregunta3.Add(new RespuestaPosible("La respuesta seis", 890));
			respuestaPregunta3.Add(new RespuestaPosible("La respuesta siete", 820));


			List<RespuestaPosible> respuestaPregunta4 = new List<RespuestaPosible>();
			respuestaPregunta4.Add(new RespuestaPosible("La respuesta nueve", 120));
			respuestaPregunta4.Add(new RespuestaPosible("La respuesta diex", 122));
			respuestaPregunta4.Add(new RespuestaPosible("La respuesta once", 678));

			List<RespuestaPosible> respuestaPregunta5 = new List<RespuestaPosible>();
			respuestaPregunta5.Add(new RespuestaPosible("La respuesta doce", 098));
			respuestaPregunta5.Add(new RespuestaPosible("La respuesta trece", 321));
			respuestaPregunta5.Add(new RespuestaPosible("La respuesta catorce", 654));

			List<RespuestaPosible> respuestaPregunta6 = new List<RespuestaPosible>();
			respuestaPregunta6.Add(new RespuestaPosible("La respuesta quince", 987));
			respuestaPregunta6.Add(new RespuestaPosible("La respuesta dieciséis", 210));
			respuestaPregunta6.Add(new RespuestaPosible("La respuesta diecisiete", 543));

			List<RespuestaPosible> respuestaPregunta7 = new List<RespuestaPosible>();
			respuestaPregunta7.Add(new RespuestaPosible("La respuesta dieciocho", 876));
			respuestaPregunta7.Add(new RespuestaPosible("La respuesta diecinueve", 109));
			respuestaPregunta7.Add(new RespuestaPosible("La respuesta veinte", 432));

			//ATENCION  !!! Carlos cambia los string de las que estan arriba por las oraciones que estan aca abajo



			/*"Por ejemplo, un puntaje de 1 a 10 para evaluar la calidad de la llamada telefónica.", 123
"1: SI, 2: NO, ¿Te gustaría recibir llamadas telefónicas para participar en encuestas?", 456
"Por ejemplo, una escala de satisfacción de 1 a 10 para evaluar tu experiencia durante la llamada telefónica.", 789
"1: Verdadero, 0: Falso, ¿Has recibido llamadas telefónicas previas relacionadas con encuestas?", 234
"Por ejemplo, una opción de horarios: 1 para la mañana, 2 para la tarde, para preferir recibir llamadas de encuestas.", 567
"Por ejemplo, un puntaje de 1 a 10 para evaluar la claridad de las preguntas durante la llamada telefónica.", 890
"Por ejemplo, una escala de 1 a 5 para evaluar la satisfacción con la duración de la llamada telefónica.", 345
"Por ejemplo, una opción de países para registrar la ubicación durante la llamada telefónica.", 678
"1: Masculino, 2: Femenino, ¿Cuál es tu género según el registro telefónico?", 901
"Por ejemplo, una opción de símbolos: +, -, *, / para indicar tu nivel de satisfacción durante la llamada telefónica.", 432
"Por ejemplo, una pregunta abierta para compartir cualquier comentario adicional sobre la llamada telefónica.", 765
"Por ejemplo, una escala de satisfacción de 1 a 5 para evaluar la amabilidad del operador durante la llamada telefónica.", 098
"1: Aceptar, 2: Rechazar, ¿Estás dispuesto a participar en futuras llamadas telefónicas para encuestas?", 321
"Por ejemplo, una opción de sabores: Vainilla, Chocolate, Fresa para registrar tus preferencias durante la llamada telefónica.", 654
"Por ejemplo, un nivel de acuerdo de 1 a 5 para evaluar la efectividad de la llamada telefónica para recopilar información.", 987
"Por ejemplo, una lista de tareas pendientes que te gustaría completar durante la llamada telefónica.", 210
"Por ejemplo, una opción de tamaños: Pequeño, Mediano, Grande para registrar tu preferencia durante la llamada telefónica.", 543
"1: Inglés, 2: Español, ¿En qué idioma prefieres comunicarte durante la llamada telefónica?", 876
"Por ejemplo, una valoración de calidad de 1 a 10 para evaluar tu satisfacción general con la llamada telefónica.", 109
"Por ejemplo, un tipo de animal: Perro, Gato, Pájaro que prefieres escuchar durante la llamada telef
			 */
			Pregunta preguntas1 = new Pregunta("¿Se puede ser feliz?", respuestaPregunta1);
			Pregunta preguntas2 = new Pregunta("¿Se puede ser feliz?", respuestaPregunta2);
			Pregunta preguntas3 = new Pregunta("¿Se puede ser feliz?", respuestaPregunta3);
			Pregunta preguntas4 = new Pregunta("¿Se puede ser feliz?", respuestaPregunta4);
			Pregunta preguntas5 = new Pregunta("¿Se puede ser feliz?", respuestaPregunta5);
			Pregunta preguntas6 = new Pregunta("¿Se puede ser feliz?", respuestaPregunta6);
			Pregunta preguntas7 = new Pregunta("¿Se puede ser feliz?", respuestaPregunta7);

			//ATENCION  !!!!! Carlos cambia los string de las que estan arriba por las oraciones que estan aca abajo

			/*¿Podrías proporcionar más detalles sobre los aspectos que influyeron en tu nivel de satisfacción con la calidad de la llamada telefónica?
¿Qué razones te llevan a preferir o no recibir llamadas telefónicas para encuestas?
¿Hay algún aspecto específico durante la llamada telefónica que te gustaría destacar como positivo o negativo en tu experiencia?
¿En qué horario del día te resulta más conveniente recibir llamadas para participar en encuestas?
¿Puedes mencionar algún ejemplo o situación en la que hayas encontrado claridad o falta de claridad en las preguntas durante la llamada telefónica?
¿Hay alguna sugerencia que tengas para mejorar la duración de las llamadas telefónicas relacionadas con encuestas?
¿Qué factores consideras más importantes al evaluar la efectividad de la llamada telefónica para recopilar información?*/

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

			// Carlos faltaria realizar 


			
			// RESPUESTA DE CLIENTE



			// LLAMADAS











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
