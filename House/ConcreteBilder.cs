using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class ConcreteBilder : Bilder
    {
        House house = new House();
        public override void BildBasement()
        {
            house.Add(new Basement());
        }

        public override void BildRoof()
        {
            house.Add(new Roof());
        }

        public override void BildStorey()
        {
            house.Add(new Storey());
        }

        public override House GetResult()
        {
            return house;
        }
    }
}
