using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseOOP1.misclases
{
    class Camión : Vehiculo
    {
        private int cargaActual;
        private string tipo = "Carga";
        private int asientos = 2;
       


        public Camión(int anio, string model, string elColor) : base(anio, model, elColor)
        {
           
        }
        
        public void tipoVehiculo()
        {
            Console.WriteLine("Tipo de vehículo: {0}", tipo);
        }

        public void verAsientos()
        {
            Console.WriteLine("Número de asientos: {0}", asientos);
        }

        public void cargar(int cuanto)
        {
            cargaActual = cargaActual + cuanto;
            Console.WriteLine("Cargando {0} toneladas", cuanto);
        }

        public void capacidadCargaCamión()
        {
            Console.WriteLine("Capacidad de carga: 10 toneladas");
        }

        public int verCapacidadCarga()
        {
            return 10;
        }

        public void descargar()
        {
            cargaActual = 0;
            Console.WriteLine("El camión ha sido descargado.");
        }
    }
}
