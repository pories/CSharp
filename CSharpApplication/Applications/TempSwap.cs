﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class TempSwap
    {
        public static void Execute()
        {
            Console.Clear();
            int a = 20;
            int b = 30;
            Console.WriteLine("In swap method");
            Console.Write("Inital values: ");
            Console.WriteLine("A = {0}, B = {1}", a, b);
            int tempswap = a;
            Console.WriteLine("Tempswap = a");
            Console.WriteLine("Tempswap = {0}, A = {1}", tempswap, a);
            a = b;
            Console.WriteLine("A = B");
            Console.WriteLine("A = {0}, B = {1} tempswap = {2}", a, b, tempswap);
            b = tempswap;
            Console.WriteLine("b = tempswap");
            Console.WriteLine("A = {0}, B = {1} tempswap = {2}", a, b, tempswap);
            Console.WriteLine("End of swap, things are rearranged.");
            //Console.WriteLine("A = {0}, B = {1} Tempswap is disregar", a, b);
            Console.WriteLine("Hit enter to go back to main menu.");
            Console.ReadLine();
        }

    }
}
