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
            Console.Clear();
            Console.WriteLine("The first collection is an ArrayList. The array list is a resizeable array that can hold multiple");
            Console.WriteLine("data types. When the predetermined count of an arraylist is exceeded, it will go up by an increment");
            Console.WriteLine("of 2x. The arraylist will start with a count of 4, then go to 8, 16, 32...");
            ArrayList alist = new ArrayList();
            alist.Add("Mike");
            alist.Add("40");
            Console.WriteLine("Count: {0}", alist.Count);  
            Console.WriteLine("Capacity: {0}", alist.Capacity);

            Console.WriteLine("Then we have a dictionary collection.");
            Console.WriteLine("The dictionary collection is made of key value pairs.");
            Console.WriteLine("To create them you define the data type of the key and the value stored inside of it.");
            Dictionary<string, string> superheros = new Dictionary<string, string>();
            superheros.Add("Clark Kent", "Superman");
            superheros.Add("Bruce Wayne", "Batman");
            superheros.Add("Barry West", "Flash");
            Console.WriteLine("I have created a dictionary collection, and populated it with superheros and their names, now I will search for one.");
            Console.WriteLine("Key Clark Kent is there: {0}", superheros.ContainsKey("Clark Kent"));
            Console.ReadLine();

            Console.WriteLine("Then there is a Queue. This is a first in first out (FIFO) collection.");
            Queue queue = new Queue();
            queue.Enqueue(1); //don't add in queue, you enqueue!
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Then you can find things in the queue. Lets look for 1.");
            Console.WriteLine("Is 1 in a queue: {0}", queue.Contains(1));
            Console.ReadLine();

            Console.WriteLine("Then there is a stack. This is a last in first out collection.");
            Stack stack = new Stack();
            stack.Push(1); //push to add.
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Then you can find things in the stack. Lets look for 1.");
            Console.WriteLine("Contains 1: {0}", stack.Contains(1));
            Console.ReadLine();

            Console.WriteLine("The Hashtable class represents a collection of key-and-value pairs");
            Console.WriteLine("that are organized based on the hash code of the key.");
            Console.WriteLine("It uses the key to access the elements in the collection.");
            Console.WriteLine("A hash table is used when you need to access elements by using key, and you can identify a useful key value.");
            Hashtable myHashTable = new Hashtable(); 
            myHashTable.Add(1, "One"); //key and value. Both are type string (In this example.) 
            myHashTable.Add(2, "Two");
            myHashTable.Add(3, "Three");
            Console.WriteLine("Then you can find things in the hashtable. Lets look for 3!");
            if (myHashTable.Contains(3))
            {
                Console.WriteLine(myHashTable[3].ToString()); //Must give key to get value, other wise will get just type. 
            }
            Console.ReadLine();







        }
    }
}
