using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car_class car1 = new Car_class(1992);

            car1.Brand = "BMW";
            
            car1.show_brand();
            Console.WriteLine("Marka samochodu: "+car1.Brand);
            Console.WriteLine("Rok produkcji: "+car1.year);

            
            car1.check_fuel(200);
            car1.check_oil(77);

            Console.ReadKey();

        }
    }
}
