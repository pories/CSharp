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
            Console.Clear();
            string Hash = "";
            Console.Write("Enter your MD5 Hash: ");
            Hash = Console.ReadLine().ToUpper();
            string Pass = "";
            int Count = 0;
            bool closeLoop = true;
            //Below is the small password file. It goes in csharp/csharpapplication/csharpapplication/bin/debug 
            //The @ symbol is the escape symbol lets you deal with / in file paths. 
            StreamReader file = new StreamReader(@"Passwords10m.txt");
            //Below is the large password file. 
            //StreamReader file = new StreamReader(@"Passwords200MB.txt");
            while (closeLoop == true && (Pass = file.ReadLine()) != null)
            {
                if (MD5Hash(Pass) == Hash)
                {
                    Console.WriteLine(Pass);
                    //Console.WriteLine("Cracked hash = " + Pass + "\n\r" + MD5Hash(Pass));
                    Console.WriteLine("Cracked hash = " + Pass);
                    //Console.ReadKey();
                    closeLoop = false;
                    file.Close(); // Close the file stream.
                    break;
                }
                else
                {
                    Console.WriteLine(Pass);
                    //put counter in here.
                    Count++;
                }
                //Count++;
                //Console.Title = "Current password count: " + Count.ToString();
                //Thread.Sleep(10); //This is commented out, but if your CPU has issues, you can add it back. Lower is smaller sleep number. 
            }
            file.Close(); // Close the file stream.
            Console.WriteLine("Hit any key to exit back to main menu.");
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