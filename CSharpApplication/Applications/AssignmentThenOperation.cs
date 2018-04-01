using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class AssignmentThenOperation
    {
        public static void Execute()
        {
            Console.Clear();
            Console.WriteLine("We have all seen it. A variable that looks like this: a++ or this: ++a.");
            Console.WriteLine("What is the difference? This will give you a simple visual way to see.");
            Console.WriteLine("Variable++:  Assignment then operation.");
            Console.WriteLine("++Variable: Operation then assignment.");
            Console.WriteLine("An example:");

            int a = 10;
            int b;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=null");
            b = a++;
            Console.WriteLine("Ran operation: b = a++;");
            Console.WriteLine("b=" + b);
            Console.WriteLine("a=" + a);
            Console.WriteLine("The returned value is the one before it is incremented.");


            int c = 20;
            int d;
            Console.WriteLine("c=" + c);
            Console.WriteLine("d=null");
            d = ++c;
            Console.WriteLine("Ran operation: d = ++c;");
            Console.WriteLine("d=" + d);
            Console.WriteLine("c=" + c);
            Console.WriteLine("The returned value is the one after it is incremented.");
            Console.WriteLine("Hit any key to exit.");
            Console.ReadLine();


        }



    }
}
