using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseOOP1.misclases
{
    class carroElectrico: Vehiculo 
    {
        private int nivelBateria = 50; 
        public carroElectrico(int anio, string model, string elColor) : base(anio, model, elColor)
        {
           
        }

        public void cargaBateria()
        {
            nivelBateria++;
        }

        public int verNivelBateria()
        {
            return nivelBateria;
        }

        public override void Acelerar(int cuanto) 
        {
            base.Acelerar(cuanto); 
            nivelBateria-- ;  
        }

    }
}
