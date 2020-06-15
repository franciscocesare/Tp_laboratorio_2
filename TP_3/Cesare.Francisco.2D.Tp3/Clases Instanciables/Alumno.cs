﻿using EntidadesAbstractas;
using System.Text;


namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
       
       
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        
        public Alumno() : base() { }

        /// <summary>
        /// Constructor que toma 6 parametros y llama al contructor base de clase Universitario.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor que toma 7 parametros y llama al contructor base de clase Universitario.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma
            , EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        

       
        /// <summary>
        /// Un alumno es igual a una clase cuando el mismo participa de ella y su estado no es deudor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
                return true;
            else
                return false;
        }

        /// <summary>
        /// El alumno es distinto a la clase solo si el no participa de ella.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma != clase)
                return true;
            else
                return false;
        }
       

       
        /// <summary>
        /// Muestra los datos del alumno base y ademas su estado de cuenta y la clase que toma.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string alDia = string.Empty;

            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                alDia = "Cuota al día";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"ESTADO DE CUENTA: {alDia}");
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }
    

        
        /// <summary>
        /// Muestra la clase que
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return $"TOMA CLASES DE {claseQueToma}";
        }

        /// <summary>
        /// Muestra todos los datos del alumno
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            return this.ToString();
        }
    
    }
}
