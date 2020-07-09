using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        //1. Realizar test que verifique que la lista de Paquetes del Correo esté instanciada.
        [TestMethod]
        public void ListIsInstanced()
        {
            Correo correito = new Correo();
            correito.Paquetes.Add(null);

            Assert.IsTrue(correito.Paquetes.Count != 0);
        }
       
        // 2. Realizar test que verifique que no se puedan cargar dos Paquetes con el mismo Tracking ID.

        [TestMethod]
        [ExpectedException(typeof(TrakingIdRepetidoException))]
        public void TestMethodTrackinIdReptidoException()
        {
            Paquete paquetin = new Paquete("pinpon 123", "008899");
            Paquete paquetin2 = new Paquete("don Lole 654", "008899");

            Correo correo = new Correo();
            correo += paquetin;
            correo += paquetin2;

        }





    }
}
