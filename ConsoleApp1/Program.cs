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
            //настроить консольный интерфейс
            ConfigureCUI();
            //ожидать нажатия Enter
            Console.ReadLine();
        }

        private static void ConfigureCUI()
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****************************");
            Console.WriteLine("***Welcome mu rockingApp*****");
            Console.WriteLine("*****************************");
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
