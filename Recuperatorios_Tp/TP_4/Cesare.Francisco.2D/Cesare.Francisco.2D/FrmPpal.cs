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


namespace Cesare.Francisco._2D
{
    public partial class FrmPpal : Form
    {
        Correo correo;
        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        private void ActualizarEstado()
        {
            listBoxEntregado.Items.Clear();
            listBoxEnViaje.Items.Clear();
            listBoxIngresado.Items.Clear();
            foreach (Paquete paquete in this.correo.Paquetes)
            {
                switch (paquete.Estado)
                {
                    case Paquete.EEstado.Entregado:
                        listBoxEntregado.Items.Add(paquete);
                        break;

                    case Paquete.EEstado.EnViaje:
                        listBoxEnViaje.Items.Add(paquete);
                        break;

                    case Paquete.EEstado.Ingresado:
                        listBoxIngresado.Items.Add(paquete);
                        txtBoxDireccion.Text = string.Empty;
                        MtxtBxTrackinId.Text = string.Empty;
                        break;
                }
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxDireccion.Text) && !string.IsNullOrEmpty(MtxtBxTrackinId.Text))
            {
                Paquete paquete = new Paquete(txtBoxDireccion.Text, MtxtBxTrackinId.Text);
                paquete.InformarEstado += paq_InformarEstado;
                try
                {
                    this.correo += paquete;
                }

                catch (TrakingIdRepetidoException)
                {
                    MessageBox.Show($"el Id: {MtxtBxTrackinId.Text}, ya fue utilizado, en un envio a: {txtBoxDireccion.Text}");///agregar datos del trakin

                }
            }
            this.ActualizarEstado();

        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (!(elemento is null))
            {
                richtxtMostrar.Text = elemento.MostrarDatos(elemento);
                GuardarString.Guardar(elemento.MostrarDatos(elemento), "salida.txt");

            }
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }


        private void paq_InformarEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformarEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstado();
            }
        }

        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion((IMostrar<Paquete>)listBoxEntregado.SelectedItem);

        }
    }

}
