﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();
            Console.WriteLine();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
