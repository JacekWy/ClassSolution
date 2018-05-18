using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole_Prostokot
{
    class pole_prostokotu
    {
        private int a;
        private int b;

        public int A { get; set; }
        public int B { get; set; }
   
        
        public pole_prostokotu(int aa,int bb)
        {
            A = aa;
            B = bb;
        }


        public int oblicz(int aa,int bb)
        {
            return aa * bb;
        }
    }
}
