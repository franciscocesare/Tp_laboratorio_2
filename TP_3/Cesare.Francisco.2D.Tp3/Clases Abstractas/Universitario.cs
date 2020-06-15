﻿using System.Text;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
       
        private int legajo;
       

        
        public Universitario() : base() { }

        /// <summary>
        /// Constructor de 5 parametros. Reutiliza constructor base clase Persona.
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
      

       
        /// <summary>
        /// Dos univerisitarios seran iguales cuando el DNI y el Legajo sean iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.Equals(pg2) && (pg1.legajo == pg2.legajo || pg1.DNI == pg2.DNI))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Dos universitarios seran distintos cuando sus lejos y DNI no sean iguales
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
       

      
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
      

       
        /// <summary>
        /// Muestra los datos contenidos en la clase base y el numero de legajo.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"LEGAJO NUMERO: {this.legajo}");
            return sb.ToString();
        }

        protected abstract string ParticiparEnClase();
     
    }
}
