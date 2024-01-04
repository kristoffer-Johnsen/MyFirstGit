using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssytem.Products
{
    internal class electronic :IProduct
    {
        double warranty;
        public string Name { get; set; }
        public int Price { get; set; }

        public electronic(double warranty, string name, int price)
        {
            this.warranty = warranty;
            Name = name;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}  :   {Price}$\n" +
                              $"Warranty:   {warranty} year(s)");
        }
    }
}
