using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    abstract class Bilder
    {
        public abstract void BildBasement();
        public abstract void BildStorey();
        public abstract void BildRoof();
        public abstract House GetResult();
    }
}
