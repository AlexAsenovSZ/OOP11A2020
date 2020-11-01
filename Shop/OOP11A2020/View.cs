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
        public void Menu()
        {
            Console.WriteLine("Welcome, {0}", this.shopName);
            PrintLine('-');
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
