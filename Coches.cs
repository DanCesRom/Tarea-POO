using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TareaPoo
{
    public class Coches
    {
        private Motor motor { get; }
        private string Marca { get; }
        private string Modelo { get; }
        private double PreAcumAverias { get; set; }

        public Coches(string Marca, string Modelo)
        {
            this.motor = new Motor(0);
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.PreAcumAverias = 0;
        }

        public void acumularAveria (double importe)
        {
            PreAcumAverias += importe;
        }

    }
}
