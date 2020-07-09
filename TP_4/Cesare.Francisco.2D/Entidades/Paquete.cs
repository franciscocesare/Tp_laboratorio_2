using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);

        private string trackingID;
        private EEstado estado;
        private string direccionDeEntrega;
        public event DelegadoEstado InformarEstado;

     
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public string DireccionDeEntrega
        {
            get
            {
                return this.direccionDeEntrega;
            }
            set
            {
                this.direccionDeEntrega = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

  
        public void MockCicloDeVida()
        {
            while (this.estado != Paquete.EEstado.Entregado)
            {
                System.Threading.Thread.Sleep(4000);
                this.estado += 1;
                this.InformarEstado.Invoke(this, null);
            }
            PaqueteDAO.Insertar(this);
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1} ", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionDeEntrega);
        }
  
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return p1.TrackingID == p2.TrackingID;
        }
      
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.direccionDeEntrega = direccionEntrega;
            this.trackingID = trackingID;
            this.estado = 0;
        }
 
        public override string ToString()
        {
            return this.MostrarDatos(this);  //+ $"estado: {this.estado}";
        }




    }


}
