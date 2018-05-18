using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole_Prostokot
{
    class Program
    {
        static void Main(string[] args)
        {
            pole_prostokotu pole1 = new pole_prostokotu(20,12);

            Console.WriteLine(pole1.oblicz(pole1.A,pole1.B));
            Console.ReadKey();


        }
    }
}
