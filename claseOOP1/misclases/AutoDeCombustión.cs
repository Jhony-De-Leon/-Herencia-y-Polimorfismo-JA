using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseOOP1.misclases
{
    class AutoDeCombustión : Vehiculo

    {
        private int nivelGasolina = 80;
        private string ascientos = "4";
        public int nivelAceite = 95;
        public AutoDeCombustión(int anio, string model, string elColor) : base(anio, model, elColor)
        {

        }

        public void cargarGasolina()
        {
            nivelGasolina++;
        }
        
        public int verNivelGasolina()
        {
            return nivelGasolina;
        }

        public override void Frenar (int cuanto)
        {
            base.Frenar(cuanto);
            nivelGasolina--; 
        }

        public void verAscientos()
        {
            Console.WriteLine("Número de ascientos: {0}", ascientos);
        }

        public void vernivelAceite()
        {
            Console.WriteLine("Nivel de aceite: {0}", nivelAceite);
        }

    }
}