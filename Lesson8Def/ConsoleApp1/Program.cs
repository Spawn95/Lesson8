using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Properties.Settings.Default.userName != "")
            {

                string name = Properties.Settings.Default.userName;
                int age = Properties.Settings.Default.userAge;
                string profession = Properties.Settings.Default.userProfession;
                Console.Write($"Hello ! {name} {age} {profession}");
            }
            else
            {
                string greeting = Properties.Settings.Default.Greeting;
                Console.WriteLine(greeting);
                Console.Write($"Enter your name: ");
                Properties.Settings.Default.userName = Console.ReadLine();
                Properties.Settings.Default.Save();
                Console.Write($"Enter your age: ");
                Properties.Settings.Default.userAge = Convert.ToInt32(Console.ReadLine());
                Properties.Settings.Default.Save();
                Console.Write($"Enter your profession: ");
                Properties.Settings.Default.userProfession = Console.ReadLine();
                Properties.Settings.Default.Save();
            }            
           
        }
    }
}
