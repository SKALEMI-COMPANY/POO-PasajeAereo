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
    class Program
    {
        internal PasajeAereo PasajeAereo
        {
            get => default;
            set
            {
            }
        }

        static void Main(string[] args)
        {

            // Instancia de la clase PasajeAereo
            PasajeAereo pasajeAereo = new PasajeAereo();

            // Instancia de la clase PasajePromocion
            PasajePromocion pasajePromocion = new PasajePromocion();

            // Instancia de la clase PasajeTurismo
            PasajeTurismo pasajeTurismo = new PasajeTurismo();

            //Instancia de la clase PasaPremium
            PasajePremium pasajePremium = new PasajePremium();

            Console.WriteLine(pasajeAereo.DetallesVuelo()); // Imprime los detalles del vuelo

            List<IPago> ListaPagos = new List<IPago>(); // Lista de la clase Padre
            ListaPagos.Add(pasajeTurismo);
            ListaPagos.Add(pasajePromocion);           
            ListaPagos.Add(pasajePremium);

            foreach(var item in ListaPagos) // Este ciclo llama a los métodos polimórficos para imprimirlos
            {
                Console.WriteLine(item.MostrarPago());
                //Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
