using EntidadesAbstractas;
using Clases_Instanciables;
using Excepciones;
using System;
using Archivo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_unitario
{
    [TestClass]
    public class TestTP3
    {
        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestSinProfesorException()
        {
            Universidad uni = new Universidad();
            Alumno a1 = new Alumno(1, "Juan", "Lopez", "12234456",
            EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion,
            Alumno.EEstadoCuenta.Becado);
            uni += Universidad.EClases.SPD;
        }


        [TestMethod] //va con cada metodo de test
        [ExpectedException(typeof(DniInvalidoException))] //espera una excepcion del tipo que creamos

        public void PersonaSinDni()
        {

            Alumno a1 = new Alumno(1, "pancho", "cesare", "0", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            Assert.IsNotNull(a1);
        }

        [TestMethod]

        public void ValidarNumero()
        {
            //Arrange
            Alumno alumno1 = new Alumno(1, "Juan", "Lopez", "12234456", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion, Alumno.EEstadoCuenta.Becado);

            //Assert
            Assert.IsInstanceOfType(alumno1.DNI, typeof(int));
            Assert.IsNotInstanceOfType(alumno1.DNI, typeof(string));
        }

    }
}
