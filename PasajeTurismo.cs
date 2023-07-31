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
    class PasajeTurismo : PasajeAereo, IPago
    {
        // Propiedades de la clase

            // Heredo las propiedades "Precio" y "Porcentaje" de la clase PasajeAereo

        // Constructor de la clase
        public PasajeTurismo()
        {
            this.Porcentaje = 30; // 30% extra cuando es Temporada Alta
            this.Total = this.Precio+(this.Precio * this.Porcentaje / 100);
        }

        // Metodos de la clase

            // Aplicar polimorfismo para usar un metodo que calcule el pago del pasaje en todas las clases hijas
        public string MostrarPago()
        {
            return "\n\t-------------------------------------------------------------------------------------------------"+
                "\n\t\t\t\t\t\t Pasaje Turismo"+
                "\n\t-------------------------------------------------------------------------------------------------"+
                "\n\n\t\t\t Temporada Alta \t\t\t\t Temporada Normal"+
                "\n\t\t\t    $"+this.Total+"\t\t\t\t\t\t$"+this.Precio;
        }

    }
}
