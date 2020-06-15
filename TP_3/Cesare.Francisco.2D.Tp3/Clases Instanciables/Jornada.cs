using Archivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Jornada
    {

        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;



        /// <summary>
        /// Constructor privado que inicializa la lista de alumnos.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor que toma 3 parametros e inicializa la lista de alumnos.
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            Clase = clase;
            Instructor = instructor;
        }


        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }



        /// <summary>
        /// Jornada y alumno seran iguales si el alumno participa de ella.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            return a == j.Clase;
        }

        /// <summary>
        /// si el alumno no participa de la jornada, Jornada y alumno seran distintos .
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// si alum no participa de la jornada lo añade.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {

            foreach (Alumno alumno in j.Alumnos)
            {
                if (alumno.Equals(a))
                {
                    return j;
                }
            }
            j.Alumnos.Add(a);
            return j;
        }



        /// <summary>
        /// mostrar datos de la Jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLASE DE {Clase.ToString()} POR NOMBRE COMPLETO: {Instructor}");
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno alumno in Alumnos)
            {
                sb.AppendLine(alumno.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// guarda datos de la Jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto txt = new Texto();
            return txt.Guardar("jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// retorna datos de la Jornada  texto.
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            Texto txt = new Texto();
            txt.Leer("jornada.txt", out string aux);
            return aux;
        }

    }
}
