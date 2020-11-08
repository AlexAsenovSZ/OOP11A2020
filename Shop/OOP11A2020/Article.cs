using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11A2020
{
    class Article
    {
        public string[] brands = {"brand1", "brand2", "brand3", "brand4"};
        public string[] models = { "model1", "model2", "model3", "model4" };
        public string[] sizes = { "size1", "size2", "size3", "size4" };
        public string[] colors = { "color1", "color2", "color3", "color4" };

        public void Prints(string[] arr)
        {
            int i = 0;
            foreach (string str in arr)
            {
                Console.WriteLine("\t{0}) {1}", i, str);
                i++;
            }
        }
    }
}
