using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Applications
{
    public class Collections
    {
        public static void Execute()
        {
            Console.WriteLine("The first collection is an ArrayList. The array list is a resizeable array that can hold multiple data types. When the predetermined count of an arraylist is exceeded, it will go up by an increment of 2x.The arraylist will start with a count of 4, then go to 8, 16, 32...");
            ArrayList alist = new ArrayList();
            alist.Add("Mike");
            alist.Add("40");
            Console.WriteLine("Goes up by incriments starting at 4 and when that count is reached, it will double it. 4, 8, 16...");
            Console.WriteLine("Count: {0}", alist.Count);  
            Console.WriteLine("Capicity: {0}", alist.Capacity);
            Console.ReadLine();

        }
    }
}
