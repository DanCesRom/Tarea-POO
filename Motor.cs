using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPoo
{
    public class Motor
    {
        private int litros_de_aceite { get; set; }
        private int potencia { get; set; }

        public Motor(int potencia)
        {
            this.litros_de_aceite = 0;
            this.potencia = potencia;
        }

    }
}
