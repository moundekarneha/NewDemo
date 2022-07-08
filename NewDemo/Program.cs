using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo
{
    internal class Program
    {
        //implicit constructor
        int i;
        bool b;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Program p = new Program();
            Console.WriteLine("Hello = "+p.i);
            Console.WriteLine("Hello = "+p.b);
            ExplicitConst obj = new ExplicitConst();
            ExplicitConst obj1 = new ExplicitConst();
            ExplicitConst obj2 = new ExplicitConst();
            ExplicitConst obj3 = new ExplicitConst(2);
            ExplicitConst obj4 = new ExplicitConst(obj3);
            ExplicitConst obj5 = new ExplicitConst(obj3);
            obj4.display();
            obj3.display();


            //diff between variable , instance, reference
            ExplicitConst varobj1; //variable of class
            varobj1 = new ExplicitConst(); //instance of class
            ExplicitConst varobj2 = varobj1; //reference of class - pointer to varobj1
            varobj1.iv = 20;
            Console.WriteLine("--value = "+ varobj1.iv);
            Console.WriteLine("--value = "+ varobj2.iv);
            varobj2.iv = 40;
            Console.WriteLine("--value = " + varobj1.iv);
            Console.WriteLine("--value = " + varobj2.iv);

            Console.ReadLine();

           
        }
    }
}
