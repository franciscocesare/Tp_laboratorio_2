using EntidadesAbstractas;
using Clases_Instanciables;
using Excepciones;
using System.Collections.Generic;
using System;
using Archivo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_unitario
{
    [TestClass]
    public class TestTP3
    {
        /// <summary>
        /// Pureba que lance la excepcion SinProfesorExcepcion
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestSinProfesorException()
        {
            Universidad uni = new Universidad();
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456",Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            uni += Universidad.EClases.SPD;
        }

        /// <summary>
        /// Pureba que lance la excepcion  NacionalidadInvalida
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))] 
        public void TestDniException()
        {   
            
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "0",
            Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.Becado);
        }

        
        /// <summary>
        /// Valide se haya instanciado un atributo del tipo colección
        /// </summary>
        [TestMethod]
        public void TestInstanciaAtributoColection()
        {
            //Arrange
            Universidad uni = new Universidad();
            Alumno alumno1 = new Alumno(1, "Juan", "Lopez", "12234456", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);
            uni.Alumnos.Add(alumno1);

            //Assert que sumo un alumno a la lista
            Assert.IsTrue(uni.Alumnos.Count != 0);

        }

    }
}
