using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //object methods are methods that are defined inside a class
            //create the students

            Student student1 = new Student("Sheila", "Communication", 4.0);
            Student student2 = new Student("Peter", "Finance", 3.2);


            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();
        }
    }
}
