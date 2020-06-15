using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }

        private string nombre;
        private string apellido;
        private ENacionalidad nacionalidad;
        private int dni;


        
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Constructor que inicializa 3 parametros.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Constructor 4 param.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor que toma 4 parametros. Inicializando 'dni' como string.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDni = dni;
        }
     

        

        /// <summary>
        /// Propiedad Nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// Propiedad Apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = ValidarNombreApellido(value); ; }
        }

        /// <summary>
        /// Propiedad Nacionalidad
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// Propiedad DNI valida int
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }

        /// <summary>
        /// Propiedad Dni. Valida string
        /// </summary>
        public string StringToDni
        {
            set
            {
                this.dni = ValidarDni(this.Nacionalidad, value);
            }
        }

        /// <summary>
        /// Muestra Nombre y apellido, Nacionalidad y DNI.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE COMPLETO: " + Apellido + ", " + Nombre);
            sb.AppendLine("NACIONALIDAD: " + Nacionalidad.ToString());
            //sb.AppendLine("DNI: " + DNI.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Metodo privado que valida DNI como int.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dni)
        {
            if (nacionalidad == ENacionalidad.Argentino && dni >= 1 && dni <= 89999999 || nacionalidad == ENacionalidad.Extranjero && dni > 89999999 && dni <= 99999999)
            {
                return dni;
            }
            throw new NacionalidadInvalidaException();
           
        }

        /// <summary>
        /// Metodo privado que valida DNI como string
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            if (!string.IsNullOrEmpty(dato) && int.TryParse(dato, out int datoInt))
            {
                return ValidarDni(nacionalidad, datoInt);
            }
            else
            {
                throw new DniInvalidoException();
            }
        }

        /// <summary>
        /// Metodo privado que valida nombre-Apellido
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if (!string.IsNullOrEmpty(dato) && !string.IsNullOrWhiteSpace(dato))
                return dato;
            else
                return "unknown";
        }
          

    }
}
