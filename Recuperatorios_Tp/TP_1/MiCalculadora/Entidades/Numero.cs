using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{


    public class Numero
    {
        private double numero; //atibuto privado y estatico

        /// <summary>
        /// //setea el numero obtenido de Form
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> devuelve el double cargado con el numero
        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }


        /// <summary>
        //Ctor por Defecto, sin param. asigna 0.
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }


        /// <summary>
        /// //Ctor con double
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }


        /// <summary>
        /// //ctor con string seteado
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {

            this.SetNumero = numero;
        }


        /// <summary>
        /// //recibe un String, y valida que lo pueda convertir a Double.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> el string validado a double
        private double ValidarNumero(string numero)
        {
            double numeroValidado = 0;

            if (!(numero is null))
            {
                double.TryParse(numero, out numeroValidado);
            }
            return numeroValidado;
        }

        #region Operaciones



        /// <summary>
        /// //Sobrecarga de operadores para las operaciones Calculadoras
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <returns></returns> el resultado de la operacion elegida
        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;

        }

        /// <summary>
        /// operacion de resta de dos numeros
        /// </summary>
        /// <param name="numero1"></param> numero 1 para la operacion
        /// <param name="numero2"></param> numero 2 para la operacion
        /// <returns></returns> resultado de la resta de los dos numeros recibidos
        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;

        }

        /// <summary>
        /// operacion de division de dos numeros
        /// </summary>
        /// <param name="numero1"></param>numero 1 para la operacion
        /// <param name="numero2"></param>numero 2 para la operacion
        /// <returns></returns>resultado de la division de los dos numeros recibidos
        public static double operator /(Numero numero1, Numero numero2)
        {
            if (numero2.numero == 0)
            {  
                return double.MinValue;
            }

            else
            { 
                return numero1.numero / numero2.numero;
            }
        }

        /// <summary>
        /// operacion de multiplicacion de dos numeros
        /// </summary>
        /// <param name="numero1"></param>numero 1 para la operacion
        /// <param name="numero2"></param>numero 2 para la operacion
        /// <returns></returns>resultado de la multiplicacion de los dos numeros recibidos
        public static double operator *(Numero numero1, Numero numero2)
        {

            return numero1.numero * numero2.numero;
        }

        
        /// <summary>
        /// /si en el aux no hay ningun 0 o 1, retorna Valor invalido
        /// </summary>
        /// <param name="binario"></param>string de binario recibido
        /// <returns></returns>Convierte el string a decimal y lo retorna, en string
        public string BinarioDecimal(string binario)
        {
            foreach (int binarioAux in binario)
            {
                if (binarioAux != '0' && binarioAux != '1')
                { 
                    return "Valor Invalido";
            
                }
            }

            return Convert.ToInt32(binario, 2).ToString();
        }

        
        /// <summary>
        /// castea a int el num recibido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>retorna el binario del decimal recibido,o valor invalido
        public string DecimalBinario(double numero)
        {
            int auxNum = (int)numero;

            string resultado = "";

            if (auxNum < 0)
            { 
                resultado = "Valor invalido";
            }
            while (auxNum > 0)
            {
                resultado = auxNum % 2 + resultado;
                auxNum = auxNum / 2;
            }

            return resultado;
        }

       
        /// <summary>
        /// si pudo castear a double el string recibido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns> en double, el casteo. de binario a decimal del otro metodo
        public string DecimalBinario(string numero)
        {
            string aux = "";
            double auxNum;

            if (double.TryParse(numero, out auxNum))
            { 
                aux = DecimalBinario(auxNum); //reutilizacion de codigo

            }
            else
            {
                aux = "Valor Invalido";
            }
            return aux;
        }

        #endregion

    }
}
