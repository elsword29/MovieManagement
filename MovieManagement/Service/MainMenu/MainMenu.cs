using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Service.MainMenu
{
    public class MainMenu
    {
        public static void Menu()
        {
            Console.WriteLine("===========MAIN=MENU===========");
            Console.WriteLine("| 1. Director management      |");
            Console.WriteLine("| 2. Movie management         |");
            Console.WriteLine("| 3. Exit                     |");
            Console.WriteLine("===============================");
            Console.Write("User choice: ");
        }
    }
}
