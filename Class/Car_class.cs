using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Car_class
    {
        private string _brand;
        public int year;
        public int fuel = 100;
        public float oil_temp = 64.6f;

        public Car_class(int year)
        {
            this.year = year;
        }

        public string Brand { get; set; }

        public void show_brand()
        {
            Console.WriteLine("Pokazywanie statystyk samochodu");
        }

        public void check_fuel(int fuell)
        {
            Console.WriteLine("Sprawdzanie paliwa...");
            if(fuel < fuell)
            {
                Console.WriteLine("Starczy paliwa");
            }
            else
            {
                Console.WriteLine("Nie starrczy paliwa");
            }

        }
        public void check_oil(float oil_temp)
        {
            Console.WriteLine("Sprawdzanie temperatury oleju......");
            this.oil_temp = oil_temp;
            if(oil_temp > 70)
            {
                Console.WriteLine("Wysoka Temperatura oleju");
            }
            else
            {
                Console.WriteLine("Odpowiednia Temperatura oleju");
            }

        }
    }
}
