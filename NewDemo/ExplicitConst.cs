using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo
{
    internal class ExplicitConst
    {
        public static int sv;
        public int iv;

        //explicit constructor
        public ExplicitConst()
        {
            sv = 12;
            Console.WriteLine("Explicit constructor");
            Console.WriteLine("values---- = " + sv);
        }

        //explicit constructor -parameterized
        public ExplicitConst(int i)
        {
            iv=i;
            
        }


        //constructor - static - executes before main - called only once
        static ExplicitConst()
        {
            sv=10;
            Console.WriteLine("static constructor executed and value = "+sv); 
        }


        //explicit constructor -copy constructor
        public ExplicitConst(ExplicitConst obj)
        {
            iv = obj.iv;
        }

        public void display()
        {
            Console.WriteLine("value = " + iv);
        }

    }
}
