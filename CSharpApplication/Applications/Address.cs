using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications
{
    public class Address
    {
        public static void check()
        {
            bool repeat = true;

            while (repeat)
            {
                Console.Clear();
                Console.Write("Please input the websites name in the format: websitename.extension: ");
                try
                {
                    string Michael = Console.ReadLine();
                    var ips = System.Net.Dns.GetHostEntry(Michael).AddressList;
                    foreach (var ip in ips)
                        Console.WriteLine("The DNS address for {0} is {1}", Michael, ip);
                    Console.WriteLine("Done reading? Hit any key!");
                    Console.ReadKey(true);
                }
                catch (System.Net.Sockets.SocketException)
                {
                    Console.Write("Input was not in the format requested.");
                    Console.Write("Please correct input.");
                }
                catch (FormatException)
                {
                    Console.Write("Input was not in the format requested.");
                    Console.Write("Please correct input.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Well that didn't go well. Here is what went wrong.");
                    Console.WriteLine(ex);
                    Console.WriteLine("Hit any key to continue.");
                    Console.ReadKey(true);
                }


                Console.Write("Go again? Y/N: ");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }

            }
        }
    }
}
