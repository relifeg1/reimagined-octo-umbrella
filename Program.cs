using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoingPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, password, userName1, password1 = string.Empty;

            Console.Write("Enter a UserName :");
            userName = Console.ReadLine();
            Console.Write("Enter a Password :");
            password = Console.ReadLine();

            
            using (StreamReader sr = new StreamReader(File.Open("C:\\Users\\MSI\\Desktop\\Developer Program\\Fil\\Pro\\Login\\1.txt", FileMode.Open)))
            {
                userName1 = sr.ReadLine();
                password1 = sr.ReadLine();
                sr.Close();
            }

            if (userName == userName1 && password == password1)
            {
                Console.WriteLine("-Login succeful");
            }
          
            else if (userName != userName1 && password == password1)
            {
                Console.WriteLine("-Login Failed \n UserName wrong");
            }

            else if (userName == userName1 && password != password1)
            {
                Console.WriteLine("-Login Failed \n Password wrong");
            }

             else if (userName != userName1 && password != password1)
            {
                Console.WriteLine("-Login Failed \n Password and UserName wrong ");
            }

            else
            {
                Console.WriteLine("-Login Failed");
            }

            Console.WriteLine("-Done.........");
            Console.Read();


        }
    }
}
