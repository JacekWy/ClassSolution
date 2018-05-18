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
            pole_prostokotu pole1 = new pole_prostokotu();

            pole1.a = 20;
            pole1.b = 40;

            pole1.oblicz(pole1.a,pole1.b);

        }
    }
}
