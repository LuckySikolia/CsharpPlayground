using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionLogicChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*implement decision logic based on a series of business rules. The business rules specify the 
             * access that will be granted to users based on their role-based permissions and their career 
             * level. Code branches will display a different message to the user depending on their permissions 
             * and level.
             * The business rules are
             *  >If the user is an Admin with a level greater than 55, output the message: Welcome, Super Admin user.
             *  >If the user is an Admin with a level less than or equal to 55, output the message: welcome, Admin user.
             *  >If the user is a Manager with a level 20 or greater, output the message: Contact an Admin for access.
             *  >If the user is a Manager with a level less than 20, output the message: You do not have sufficient privileges.
             *  >If the user is not an Admin or a Manager, output the message:You do not have sufficient privileges.
             */

            //string permission = "Admin|Manager";
            Console.WriteLine("Enter the status");
            string permission = Console.ReadLine();
            Console.WriteLine("Enter the User level");
            int level = Convert.ToInt32(Console.ReadLine());

            if (permission.Contains("Admin") && level > 55)
            {
                Console.WriteLine($"Welcome, Super {permission} user");
            }
            else if(permission.Contains("Admin") && level <= 55)
            {
                Console.WriteLine($"Welcome, {permission} user");
            }

            if (permission.Contains("Manager") && level > 20)
            {
                Console.WriteLine("Contact an Admin for access");
            }
            else if (permission.Contains("Manager") && level <= 20)
            {
                Console.WriteLine("You do not have sufficient priviledges");
            }




                //Console.WriteLine(permission.Contains("Admin"));
            Console.ReadLine();
        }
        

    }
}
