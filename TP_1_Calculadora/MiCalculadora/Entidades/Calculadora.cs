using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {

        /// <summary>
        /// Recibe un valor en operador, valida cual es, sino devuelve "+"
        /// </summary>
        /// <param name="operador"></param>string, operador seleccionado
        /// <returns></returns>operador Validado, o por defecto
        private static string ValidadOperador(string operador)
        {
            string validado = "+";

            if (operador == "-")
            {
                validado = "-";
            }
            if (operador == "/")
            {
                validado = "/";
            }
            if (operador == "*")
            {
                validado = "*";
            }
            return validado;
        }



        /// <summary>
        /// recibe dos numeros y un operador seleccionado por usuario
        //realiza la operacion mediante un switch segun la opcion elegida
        /// </summary>
        /// <param name="primerNumero"></param>
        /// <param name="segundoNumero"></param>
        /// <param name="operacion"></param>
        /// <returns></returns>devuelve el resultado de la operacion
        public static double Operar(Numero primerNumero, Numero segundoNumero, string operacion)
        {
            double resultado = 0;

            if (primerNumero != null && segundoNumero != null)
            {
                switch (ValidadOperador(operacion))
                {
                    case "+":
                        {
                            resultado = primerNumero + segundoNumero;
                            break;
                        }

                    case "-":
                        {
                            resultado = primerNumero - segundoNumero;
                            break;
                        }
                    case "*":
                        {
                            resultado = primerNumero * segundoNumero;
                            break;
                        }
                    case "/":
                        {


                            resultado = primerNumero / segundoNumero;
                            break;
                        }

                }
            }
            return resultado;

        }
    }
}
