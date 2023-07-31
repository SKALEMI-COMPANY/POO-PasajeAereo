using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Skalemi Company
// Si te surge alguna duda, contáctame.
// michaelvinces.skalemi@gmail.com

namespace ExamenPOO_PasajeAereo
{
    class PasajeAereo
    {
        // Propiedades de la clase
            // Propiedades de informacion del vuelo
        public string OrigenPasaje { get; set; }
        public string Destino { get; set; }
        public string DueñoPasaje { get; set; }

            // Propiedades para el calculo del pasaje
        public double Precio { get; set; }
        public double Porcentaje { get; set; } // Propiedad para el descuento o incremento del pasaje
        public double Total { get; set; }


        // Constructor de la clase
        public PasajeAereo()
        {
            this.OrigenPasaje = "Quito-Ecuador";
            this.Destino = "Madrid-España";
            this.DueñoPasaje = "Michael Leonardo Vinces Andrade";
            this.Precio = 645;
        }

        // Metodos de la clase

                // Metodo para mostrar la informacion del vuelo
        public string DetallesVuelo()
        {
            return "\n\t-------------------------------------------------------------------------------------------------"+
                "\n\n\tOrigen del viaje\t\t\tDueño del Pasaje\t\t\tDestino del viaje\n\t " + 
                this.OrigenPasaje + "\t\t\t" + this.DueñoPasaje + "\t\t\t  " + this.Destino;
        }


    }
}
