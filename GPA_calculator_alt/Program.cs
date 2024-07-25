using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_calculator_alt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*This is the guided solution to the previous GPA calculator 
             task only difference is this one does not take data from user input
            */

            //declarations
            //-student name
            string studentName = "Sophia Johnson";

            //-course name
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            //-course credit hours
            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            //-course grade
            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            //variables to calculate gpa
            int totalCreditHours = 0;
            totalCreditHours += course1Credit;
            totalCreditHours += course2Credit;
            totalCreditHours += course3Credit;
            totalCreditHours += course4Credit;
            totalCreditHours += course5Credit;

            //variable to store the total number of grade points
            int totalGradePoints = 0;
            totalGradePoints += course1Grade * course1Credit;
            totalGradePoints += course2Grade * course2Credit;
            totalGradePoints += course3Grade * course3Credit;
            totalGradePoints += course4Grade * course4Credit;
            totalGradePoints += course5Grade * course5Credit;

            //          Console.WriteLine($"{totalGradePoints} {totalCreditHours}");

            //varables to store the final gpa
            decimal gradePointAverage = (decimal)totalGradePoints / (decimal)totalCreditHours;
            //code for 2 decimal places
            //- initialize a variable that will store the leading digit of the GPA
            int leadingDigit = (int)gradePointAverage;
            //- initialize a variable that will store the first two digits after the decimal
            int firstDigit = (int)(gradePointAverage * 10) % 10;
            int secondDigit = (int)(gradePointAverage * 100) % 10;
            




            Console.WriteLine();
            Console.WriteLine($"Student: {studentName}");
            Console.WriteLine();

            Console.WriteLine("Course\t\t\t\tGrade\tCreditHours");
            Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");
            Console.WriteLine();
            Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

            Console.ReadLine();

        }
    }
}
