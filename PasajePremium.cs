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
    class PasajePremium : PasajeAereo, IPago
    {
        // Propiedades de la clase

            // Heredo las propiedades "Precio" y "Porcentaje" de la clase PasajeAereo

        // Constructor de la clase
        public PasajePremium()
        {
            this.Precio = 100;
            this.Porcentaje = 15;
            this.Total = this.Precio + (this.Precio*this.Porcentaje/100);
        }

        // Metodos de la clase

            // Aplicar polimorfismo para usar un metodo que calcule el pago del pasaje en todas las clases hijas
        public string MostrarPago()
        {
            return "\n\t-------------------------------------------------------------------------------------------------" +
                "\n\t\t\t\t\t\t Pasaje Premium" +
                "\n\t-------------------------------------------------------------------------------------------------" +
                "\n\n\t\t\t\t     Recargo del 15% por servicios Premium " +
                "\n\t\t\t\t\t\t    $" + this.Total+
                "\n\n\t-------------------------------------------------------------------------------------------------";
        }
    }
}
