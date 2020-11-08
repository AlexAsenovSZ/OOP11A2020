using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11A2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Setting.products = new Dictionary<int, Goods>();
            Controll Controll = new Controll();
            View View = new View();
            int i = 0;
            while (true)
            {
                Controll.MenuController(View.Menu());
                i++;
            }
            Setting.products = null;
        }
    }
}
