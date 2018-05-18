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
        public int fuel = 100;
        
        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }

        }
        public void show_brand()
        {
            

            Console.WriteLine("AHAHAHA");
        }

     
        

    }
}
