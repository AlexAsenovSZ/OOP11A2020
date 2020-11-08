using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP11A2020
{
    class Controll
    {
       

        public void MenuController(int choise)
        {
            switch(choise)
            {
                case 1:
                    CreateModul CreateModul = new CreateModul();
                    CreateModul.CreateView();
                    break;
                case 2:
                    ListModul ListModul = new ListModul();
                    ListModul.ListView();
                    break;
                default:
                    Exits();
                    break;
            }
        }

        public static void Exits()
        {
            Setting.products = null;
            Environment.Exit(0);
        }
    }
}
