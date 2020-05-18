using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        //inicia el form
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el Form, en 0 o isEmpty y false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.txtPrimerNum.Text = string.Empty;
            this.txtSegundoNum.Text = string.Empty;
            this.cmbOperacion.Text = "+";
            this.lblResultado.Text = string.Empty;
            this.btnConvertirBinario.Enabled = false;
            this.btnConvertirDecimal.Enabled = false;
        }


        /// <summary>
        /// instancio dos objetos Numero, y realizo operaciones validadas
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operacion"></param>
        /// <returns></returns>valor resultante de la operacion
        private static double Operar(string num1, string num2, string operacion)
        {
            

            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);

            return Calculadora.Operar(numero1, numero2, operacion);

            
  
        }

       
        /// <summary>
        /// Limpiar vacia los campos como al comienzo
        /// </summary>
        private void Limpiar()
        {
            this.txtPrimerNum.Text =string.Empty ;
            this.txtSegundoNum.Text = string.Empty;
            this.cmbOperacion.Text = "+";
            this.lblResultado.Text = string.Empty;
            this.btnConvertirBinario.Enabled = false;
            this.btnConvertirDecimal.Enabled = false;

        }
        
        /// <summary>
        /// Evento generado por click en Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;

            resultado=FormCalculadora.Operar(txtPrimerNum.Text,txtSegundoNum.Text, cmbOperacion.Text).ToString();

            lblResultado.Text = resultado;

            btnConvertirBinario.Enabled = true;
            btnConvertirDecimal.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        
        //
        //
        //deja activo el boton convertir a binario
        /// <summary>

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>crea una nueva instancia para guardar el numero resultante
        /// /// evento, realiza la operacion convertir a decimal y lo muestra
        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            string auxNumero = lblResultado.Text;

            Numero numero = new Numero();

            lblResultado.Text = numero.BinarioDecimal(auxNumero);
            btnConvertirBinario.Enabled = true;


        }

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>crea una nueva instancia para guardar el numero resultante
        /// /// evento, realiza la operacion convertir a binariol y lo muestra
        private void btnConvertirBinario_Click(object sender, EventArgs e)
        {
            string auxNumero = lblResultado.Text;

            Numero numero = new Numero();
            
            lblResultado.Text = numero.DecimalBinario(auxNumero);
            btnConvertirDecimal.Enabled = true;
        }
    }
}
