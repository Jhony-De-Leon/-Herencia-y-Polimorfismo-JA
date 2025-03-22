using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseOOP1.misclases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; set; }
        public int Year { get; }

        private int velocidad = 0;
        private bool encendido = false; 

        //constructor 
        public Vehiculo(int anio, string model, string elColor)
        {
            this.Year = anio;
            this.Modelo = model;
            this.Color = elColor;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color: {0}", this.Color);
            Console.WriteLine("Modelo: {0}", this.Modelo);
            Console.WriteLine("Año: {0}", this.Year);
        }

        public virtual void Acelerar(int cuanto)
        {
            if (encendido)
            {
                velocidad += cuanto;
                Console.WriteLine("Vas a: {0} kms por hora", velocidad);
            }
            else
            {
                Console.WriteLine("El vehículo está apagado. No se puede acelerar.");
            }
        }

        public virtual void Frenar(int cuanto)
        {
            if (encendido)
            {
                velocidad -= cuanto;
                Console.WriteLine("Acabas de frenar, vas a: {0} kms por hora", velocidad);
            }
            else
            {
                Console.WriteLine("El vehículo está apagado. No se puede frenar.");
            }
        }

        public void encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("El vehículo ha sido encendido.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está encendido.");
            }
        }

        public void apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("El vehículo ha sido apagado.");
            }
            else
            {
                Console.WriteLine("El vehículo ya está apagado.");
            }
        }
    }
}
