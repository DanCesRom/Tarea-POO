using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPoo
{
    public class Garaje
    {

        private Coches coche { get; set; }
        private string AveriaAsociada { get; set; }
        private int NumCochesAten { get; set; } 

        public Garaje()
        {
            coche = null;

            NumCochesAten = 0;
        }


    }
}
