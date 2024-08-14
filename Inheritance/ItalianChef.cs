using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ItalianChef : Chef
    {
        //can do everthing a normal shef can do and make italian chef
        //ie can make chicken, salad, and special dish

        //inherit the functionality of the chef class


        //new method
        public void MakePasta()
        {
            Console.WriteLine("The chef can make pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes Ugali");
        }

    }
}
