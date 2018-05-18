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
            Car_class car1 = new Car_class();

            car1.Brand = "BMW";

            Console.WriteLine(car1.Brand);
            Console.WriteLine(car1.fuel);
            car1.show_brand();
            

            Console.ReadKey();

        }
    }
}
