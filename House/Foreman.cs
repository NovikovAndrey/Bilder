using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Foreman
    {
        Bilder bilder;
        public Foreman(Bilder bilder)
        {
            this.bilder = bilder;
        }
        public void Construcn()
        {
            bilder.BildBasement();
            bilder.BildStorey();
            bilder.BildRoof();
        }
    }
}
