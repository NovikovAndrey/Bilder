using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilder bilder = new ConcreteBilder();
            Foreman foreman = new Foreman(bilder);
            foreman.Construcn();
            House house = bilder.GetResult();
            Console.ReadKey();
        }
    }
}
