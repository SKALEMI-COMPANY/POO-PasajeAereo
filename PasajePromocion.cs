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
    class PasajePromocion : PasajeAereo, IPago
    {
        // Propiedades de la clase

            // Heredo las propiedades "Precio" y "Porcentaje" de la clase PasajeAereo

        // Constructor de la clase
        public PasajePromocion()
        {
            this.Porcentaje = 50; // 50% de Descuento
            this.Total = this.Precio * this.Porcentaje/100;            
        }

        // Metodos de la clase

            // Aplicar polimorfismo para usar un metodo que calcule el pago del pasaje en todas las clases hijas
        public string MostrarPago()
        {
            return "\n\t-------------------------------------------------------------------------------------------------" +
                "\n\t\t\t\t\t\tPasaje Promoción" +
                "\n\t-------------------------------------------------------------------------------------------------" +
                "\n\n\t\t\t\t\t\tDescuento 50% "+
                "\n\t\t\t\t\t\t    $" + this.Total ;
        }
    }
}
