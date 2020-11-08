using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11A2020
{
    class View:Setting
    {
        private int lineCountChar = 10;
        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome, {0}", this.shopName);
            PrintLine('-');
            Console.WriteLine("\t 1) Create ");
            Console.WriteLine("\t 2) List");
            Console.WriteLine("\t 3) Exit");
            PrintLine('-');
            Console.Write("Choise: ");
            int num = int.Parse(Console.ReadLine()); 
            return num;
        }

        private void PrintLine(char ch)
        {
            for (int i = 0; i < this.lineCountChar; i++)
            {
                Console.Write(ch);
            }
            Console.Write("\n");
        }
    }
}
