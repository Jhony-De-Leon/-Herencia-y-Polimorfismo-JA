using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseOOP1.misclases
{
    class Motocicleta : Vehiculo
    {
        private string arrenque = "Patada";
        private bool intermitentes = false; 
        private string motor = "4 tiempos";
        public Motocicleta(int anio, string model, string elColor) : base(anio, model, elColor)
        { }

        public void verMotor()
        {
            Console.WriteLine("Motor: {0}", motor);
        }

        public string verArranque()
        {
            return arrenque;
        }

        public void lucesIntermitentes()
        {
            intermitentes = !intermitentes; 
        }

        public override void Acelerar(int cuanto)
        {
            base.Acelerar(cuanto * 2); // La aceleración de la motocicleta es el doble que la de un carro
        }

        public override void Frenar(int cuanto)
        {
            base.Frenar(cuanto);
            if (!intermitentes)
            {
                Console.WriteLine("Haz frenado, las luces intermitentes están encendidas");
                lucesIntermitentes(); // Enciende las intermitentes apagadas
            }
        }
    }
}
