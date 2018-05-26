using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;


namespace Applications
{
    public class MD5HashCrack
    {
       public static void Execute()
        {
            string Hash = "";
            Console.Write("Enter your MD5 Hash: ");
            Hash = Console.ReadLine().ToUpper();
            string Pass = "";
            int Count = 0;
            bool closeLoop = true;

            StreamReader file = new StreamReader(@"Passwords10m.txt");
            while (closeLoop == true && (Pass = file.ReadLine()) != null)
            {
                if (MD5Hash(Pass) == Hash)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(Pass);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cracked hash = " + Pass + "\n\r" + MD5Hash(Pass));
                    Console.ResetColor();
                    Console.ReadKey();

                    closeLoop = false;
                    file.Close(); // Close the file stream.
                }

                else
                {
                    Console.WriteLine(Pass);

                }
                Count++;
                Console.Title = "Current password count: " + Count.ToString();
                //Thread.Sleep(10); //This is commented out, but if your CPU has issues, you can add it back. Lower is smaller sleep number. 

            }
            file.Close(); // Close the file stream.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static string MD5Hash(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            MD5CryptoServiceProvider MD5Provider = new MD5CryptoServiceProvider();
            byte[] bytes = MD5Provider.ComputeHash(new UTF8Encoding().GetBytes(inputString));

            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("X2"));

            }
            return sb.ToString();
        }
    }
}
