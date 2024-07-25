using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Suppose you're a teacher's assistant at a university. You're tasked with developing an application that helps 
             * calculate students' grade point average. The application uses the students' grades and credit hours taken to 
             * calculate their overall GPA. You're also provided a required format for reporting the students' GPA.
             * 
             * Your code will declare and assign values to variables based on course information, perform various numeric 
             * calculations, and format and display the results. Calculations include determining the sum of the grade points 
             * earned and total credit hours. To display the results in the required format, you'll need to manipulate a decimal 
             * value to display a total of three digits. You'll also use Console.WriteLine() methods as well character escape 
             * sequences that help to format your results.
             * 
             * The parameters for your application are:
             * 1. You're given the student's name and class information.
             * 2. Each class has a name, the student's grade, and the number of credit hours for that class.
             * 3. Your application needs to perform basic math operations to calculate the GPA for the given student.
             * 4. Your application needs to output/display the student’s name, class information, and GPA.
             * 
             * To calculate the GPA:
             *  1.Multiply the grade value for a course by the number of credit hours for that course.
             *  2.Do this for each course, then add these results together.
             *  3.Divide the resulting sum by the total number of credit hours.
             */

            //Declare student name
            string studentName = "Sophia Johnson";

            //Declare the courses done
            string course1 = "English 101";
            string course2 = "Algebra 101";
            string course3 = "Biology 101";
            string course4 = "Computer Science I";
            string course5 = "Psychology 101";


            //Get grade from user input and calculate the (individual) class total
            //English 101 Grades input
            Console.Write($"Enter {course1} grade: ");
            string englishGrade = Console.ReadLine();
            int engGrade;
            bool isGrade = int.TryParse(englishGrade, out engGrade);
            if (!isGrade)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            //Get credit hours from user input
            Console.Write($"Enter the {course1} credit hours: ");
            string creditHours = Console.ReadLine();
            int creditHrs;
            bool isCredit = int.TryParse(creditHours, out creditHrs);
            if (!isCredit)
            { 
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            //calculate the(individual) class total
            int engTotal = engGrade * creditHrs;
            Console.WriteLine($"{course1} class total: {engTotal}");

            //Add a blank line
            Console.WriteLine();



            //Algerba 101 Grades input
            Console.Write($"Enter the {course2} grade: ");
            string algebraGrade = Console.ReadLine();
            int algGrade;
            bool isalgGrade = int.TryParse(algebraGrade, out algGrade);
            if (!isalgGrade)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            Console.Write($"Enter the {course2} credit hours: ");
            string algCreditHours = Console.ReadLine();
            int algCreditHrs;
            bool isalgCredit = int.TryParse(algCreditHours, out algCreditHrs);
            if (!isalgCredit)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            //calculate the(individual) class total
            int algTotal = algGrade * algCreditHrs;
            Console.WriteLine($"{course2} class total: {algTotal}");
            //Add a blank line
            Console.WriteLine();


            //Biology 101 Grades input
            Console.Write($"Enter the {course3} grade: ");
            string biologyGrade = Console.ReadLine();
            int bioGrade;
            bool isbioGrade = int.TryParse(biologyGrade, out bioGrade);
            if (!isbioGrade)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            Console.Write($"Enter the {course3} credit hours: ");
            string bioCreditHours = Console.ReadLine();
            int bioCreditHrs;
            bool isbioCredit = int.TryParse(bioCreditHours, out bioCreditHrs);
            if (!isbioCredit)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            //calculate the(individual) class total
            int bioTotal = bioGrade * bioCreditHrs;
            Console.WriteLine($"{course3} class total: {bioTotal}");
            //Add a blank line
            Console.WriteLine();


            //Computer Science I Grades input
            Console.Write($"Enter the {course4} I grade: ");
            string compSci1Grade = Console.ReadLine();
            int csGrade;
            bool iscsGrade = int.TryParse(compSci1Grade, out csGrade);
            if (!iscsGrade)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            Console.Write($"Enter the {course4} I credit hours: ");
            string csCreditHours = Console.ReadLine();
            int csCreditHrs;
            bool iscsCredit = int.TryParse(csCreditHours, out csCreditHrs);
            if (!iscsCredit)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }
            //calculate the(individual) class total
            int csTotal = csGrade * csCreditHrs;
            Console.WriteLine($"{course4} I class total: {csTotal}");
            //Add a blank line
            Console.WriteLine();

            //Psychology 101 Grades input
            Console.Write($"Enter the {course5} grade: ");
            string PsychologyGrade = Console.ReadLine();
            int psyGrade;
            bool ispsyGrade = int.TryParse(PsychologyGrade, out psyGrade);
            if (!ispsyGrade)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }

            Console.Write($"Enter the {course5} credit hours: ");
            string psyCreditHours = Console.ReadLine();
            int psyCreditHrs;
            bool ispsyCredit = int.TryParse(psyCreditHours, out psyCreditHrs);
            if (!ispsyCredit)
            {
                Console.WriteLine("Invaid input. Please enter a valid number value for the grade");
                return;
            }
            //calculate the(individual) class total
            int psyTotal = psyGrade * psyCreditHrs;
            Console.WriteLine($"{course5} class total: {psyTotal}");
            //Add a blank line
            Console.WriteLine();


            //Calculate the gpa
            int totalGrades = engTotal + algTotal + bioTotal + csTotal + psyTotal;
            int totalCreditHrs = creditHrs + algCreditHrs + bioCreditHrs + csCreditHrs + psyCreditHrs;
            decimal studentGPA = ((decimal)totalGrades / (decimal)totalCreditHrs);
            studentGPA = Math.Round(studentGPA, 2);

            //Add a blank line
            Console.WriteLine();
            Console.WriteLine();

            //The desired(expected)output
            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\tGrade\tCredit Hours\t Grade Points");
            Console.WriteLine($"{course1}\t    {engGrade}\t    {creditHrs}\t\t      {engTotal}");
            Console.WriteLine($"{course2}\t    {algGrade}\t    {algCreditHrs}\t\t      {algTotal}");
            Console.WriteLine($"{course3}\t    {bioGrade}\t    {bioCreditHrs}\t\t      {bioTotal}");
            Console.WriteLine($"{course4}  {csGrade}\t    {csCreditHrs}\t\t      {csTotal}");
            Console.WriteLine($"{course5}\t    {psyGrade}\t    {psyCreditHrs}\t\t      {psyTotal}");
            Console.WriteLine();
            Console.WriteLine($"Final GPA:\t    {studentGPA}");
            Console.ReadLine();

        }
    }
}

