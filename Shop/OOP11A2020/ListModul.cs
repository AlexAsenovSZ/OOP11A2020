using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11A2020
{
    class ListModul
    {
        public void ListView()
        {
            Console.Clear();
            Console.WriteLine("List Goods");
            Article Article = new Article();
            foreach (var index in Setting.products)
            {
                Console.WriteLine();
                Console.Write($"{index.Key} | {index.Value.title}");
                Console.Write(" Brand: {0} ",Article.brands[index.Value.brand]);
                Console.Write(" Model: {0} ", Article.models[index.Value.model]);
                Console.Write(" Color: {0} ", Article.colors[index.Value.color]);
                Console.Write(" Size: {0} ", Article.sizes[index.Value.size]);
                Console.Write(" Quallity: {0} ", index.Value.quallyti);
                Console.Write(" Price: {0} ", index.Value.price);

            } 
            Console.Write("\n Return Menu: Enter ");
            string str = Console.ReadLine();
        }
    }
}
