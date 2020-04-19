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
        public FormCalculadora()
        {
            InitializeComponent();
        }


        //instancio dos objetos Numero, y realizo operaciones validadas
        //retorno el valor resultante de la operacion

        private static double Operar(string num1, string num2, string operacion)
        {
            

            Numero numero1 = new Numero(num1);
            Numero numero2 = new Numero(num2);

            return Calculadora.Operar(numero1, numero2, operacion);

            
  
        }

        //Limpiar vacia los campos como al comienzo
        //deja en flase los botones binario y decimal, porque no habria 
        //valor a convertir
        //no recibe parametros, con el this, el objeto que lo llama trabaja
        private void Limpiar()
        {
            this.txtPrimerNum.Text =string.Empty ;
            this.txtSegundoNum.Text = string.Empty;
            this.cmbOperacion.Text = "+";
            this.lblResultado.Text = string.Empty;
            this.btnConvertirBinario.Enabled = false;
            this.btnConvertirDecimal.Enabled = false;

        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }

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
            string resultado = "";

            string operador = Convert.ToString(cmbOperacion.SelectedIndex);

            resultado=FormCalculadora.Operar(txtPrimerNum.Text,txtSegundoNum.Text, cmbOperacion.Text).ToString();

            lblResultado.Text = resultado;

            btnConvertirBinario.Enabled = true;
            btnConvertirDecimal.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        //evento, realiza la operacion convertir a decimal
        //crea una nueva instancia para guardar el numero resultante
        //deja activo el boton convertir a binario
        private void btnConvertirDecimal_Click(object sender, EventArgs e)
        {
            string auxNumero = lblResultado.Text;

            Numero numero = new Numero();

            lblResultado.Text = numero.BinarioDecimal(auxNumero);
            btnConvertirBinario.Enabled = true;


        }

        //evento, realiza la operacion convertir a binario
        //crea una nueva instancia para guardar el numero resultante
        //deja activo el boton convertir a decimal
        private void btnConvertirBinario_Click(object sender, EventArgs e)
        {
            string auxNumero = lblResultado.Text;

            Numero numero = new Numero();
            
            lblResultado.Text = numero.DecimalBinario(auxNumero);
            btnConvertirDecimal.Enabled = true;
        }
    }
}
