using Archivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Excepciones;


namespace Clases_Instanciables
{
    public class Universidad
    {
        
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
    

        
        private List<Alumno> alumnos;
        private List<Profesor> profesores;
        private List<Jornada> jornadas;
      

   
        /// <summary>
        /// Constructor  lista de profesores, alumnos y jornadas por def
        /// </summary>
        public Universidad()
        {
            Alumnos = new List<Alumno>();
            Profesores = new List<Profesor>();
            Jornadas = new List<Jornada>();
        }
   
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Profesor> Profesores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return this.jornadas; }
            set { this.jornadas = value; }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornadas[i];
            }
            set
            {
                this.jornadas[i] = value;
            }
        }
    

  
        /// <summary>
        /// Metedodo estatico que guarda los datos de una universidad en un archivo XML.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();

            if (xml.Guardar("Universidad.xml", uni))  
            {

                return true;

            }
            return false;
        }

        /// <summary>
        /// Metodo estatico que lee los datos de una universidad desde un archivo XML.
        /// </summary>
        /// <returns></returns>
        public static bool Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            if (xml.Leer("Universidad.xml", out Universidad universidad))
            {
                Console.WriteLine(universidad.ToString());
                return true;
            }
            return false;
        }

        /// <summary>
        /// Muestra los datos de las Jornadas
        /// </summary>
        /// <returns></returns>
        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA: ");
            foreach (Jornada jornada in Jornadas)
            {
                sb.AppendLine(jornada.ToString());
                sb.AppendLine("<---------------------------->:");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra los datos de la universidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos();
        }



        /// <summary>
        /// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno item in g.Alumnos)
            {
                if (item.DNI == a.DNI)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Alumno no estaen  la universidad.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        ///Un Universidad será igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator == (Universidad g, Profesor p)
        {
            foreach (Jornada jornada in g.Jornadas)
            {
                if (p == jornada.Instructor)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor p)
        {
            return !(g == p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Profesores)
            {
                if (profesor == clase)
                    return profesor;
            }

            throw new SinProfesorException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            Profesor profesor = null;

            foreach (Profesor p in u.Profesores)
            {
                if (p != clase)
                    return p;
            }

            return profesor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada jornada = new Jornada(clase, (g == clase));

            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == clase)
                    jornada.Alumnos.Add(alumno);
            }

            g.Jornadas.Add(jornada);
            return g;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }

            throw new AlumnoRepetidoException();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="u"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            foreach (Profesor profesor in u.Profesores)
            {
                if (profesor == i)
                    return u;
            }
            u.Profesores.Add(i);
            return u;
        }
     

    }

}
