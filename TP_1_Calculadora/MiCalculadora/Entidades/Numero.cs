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
        private double numero; //sytibuto privado y estatico


        //setea el numero obtenido de Form
        //valida que sea un numero
        //devuelve el string cargado con el numero
        //public string SetNumero(string numeroAux)
        //{
            
        //    this.numero = ValidarNumero(numeroAux);

        //    return this.numero.ToString();
        //}

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }


        //Ctor por Defecto, sin param. asigna 0.
        public Numero()
        {
            this.numero = 0;
        }

        //Ctor con double
        public Numero(double numero)
        {
            this.numero = numero;
        }



        //ctro con string seteado
        public Numero(string numero)
        {
            
            this.SetNumero=numero;
        }


        //recibe un String, y valida que lo pueda convertir a Double.
        private double ValidarNumero(string numero)
        {
            double numeroValidado = 0;

            if (!(numero is null))

                double.TryParse(numero, out numeroValidado);

            return numeroValidado;
        }

        #region Operaciones



        //Sobrecarga de operadores para las operaciones Calculadoras
        public static double operator +(Numero numero1, Numero numero2)
        {
            return numero1.numero + numero2.numero;

        }

        public static double operator -(Numero numero1, Numero numero2)
        {
            return numero1.numero - numero2.numero;

        }

        public static double operator /(Numero numero1, Numero numero2)
        {
            if (numero2.numero == 0)

                return double.MinValue;

            else

                return numero1.numero / numero2.numero;

        }

        public static double operator *(Numero numero1, Numero numero2)
        {

            return numero1.numero * numero2.numero;
        }

        //itera con foreach el string recibido
        //si en el aux no hay ningun 0 o 1, retorna Valor invalido
        //si hay 1 y 0, realiza la operacion de convertir a decimal y la retorna
        public string BinarioDecimal(string binario)
        {
            foreach (int binarioAux in binario)
            {
                if (binarioAux != '0' && binarioAux != '1')
                    return "Valor Invalido";
            }

            return Convert.ToInt32(binario, 2).ToString();
        }

        //castea a int el num recibido
        //si el int es menor a 0, retorna Valor invalido
        //mientras sea mayor a 0, divide con resto 2, y suma el resultado
        //retorna luego de iterar hasta que el numero disminuye a 0 el resultado
        //de la division y suma
        public string DecimalBinario(double numero)
        {
            int auxNum = (int)numero;

            string resultado = "";

            if (auxNum < 0)
                resultado = "Valor invalido";

            while (auxNum > 0)
            {
                resultado = auxNum % 2 + resultado;
                auxNum = auxNum / 2;
            }

            return resultado;
        }

        //si pudo castear a double el string recibido,
        //lo convierte con la operacion anterior reutilizando codigo
        //retorna el resultado de la operacion en string
        public string DecimalBinario(string numero)
        {
            string aux = "";
            double auxNum;

            if (double.TryParse(numero, out auxNum))

                aux = DecimalBinario(auxNum); //reutilizacion de codigo
            else
            { 
                aux = "Valor Invalido";
            }
            return  aux;
        }
      
        #endregion

    }
}
