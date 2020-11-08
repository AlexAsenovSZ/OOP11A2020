using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11A2020
{
    class CreateModul
    {

        public void CreateView()
        {
            int ikeys = 1;
            int c = Setting.products.Count;
            Console.WriteLine(c);
            if (c > 0)
            {
                ikeys = Setting.products.Keys.Last();
                ikeys++;
            }
            Console.Clear();
            Console.WriteLine("Create Product");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Article Article = new Article();
            Console.WriteLine("Add Brand:");
            Article.Prints(Article.brands);
            Console.Write("Choise brand: ");
            int ibrand = int.Parse(Console.ReadLine());
            Console.WriteLine("Add Model:");
            Article.Prints(Article.models);
            Console.Write("Choise model: ");
            int imodel = int.Parse(Console.ReadLine());
            Console.WriteLine("Add color:");
            Article.Prints(Article.colors);
            Console.Write("Choise color: ");
            int icolor = int.Parse(Console.ReadLine());
            Console.WriteLine("Add Size: ");
            Article.Prints(Article.sizes);
            Console.Write("Choise size: ");
            int isize = int.Parse(Console.ReadLine());
            Console.Write("Quallity: ");
            int quallity = int.Parse(Console.ReadLine());
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            Setting.products.Add(ikeys, new Goods { title = title, brand = ibrand, model = imodel, color=icolor, size = isize, quallyti = quallity, price = price });
        }
    }
}

