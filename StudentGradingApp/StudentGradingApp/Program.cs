using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Suppose you are a teacher's assistant at a school. You're tasked with developing an application 
             * that automates student grading. The application uses all of the scored assignments for each 
             * student to calculate their current overall grade/score for the class. The teacher has also 
             * provided a required format for reporting the student grades.
             
                The parameters for your application are:
                1. You're given a short list of four students and their five assignment grades.
                2. Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
                3. Final scores are calculated as an average of the five assignment scores.
                4. Your application needs to perform basic math operations to calculate the final grades for each student.
                5. Your application needs to output/display each student’s name and final score.*/


            //Initialize the variables for the graded assinments
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicholas1 = 80;
            int nicholas2 = 83;
            int nicholas3 = 82;
            int nicholas4 = 88;
            int nicholas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;


            //calculate the average grade for each student's assignment scores
            decimal sophiaTotal = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5);
            decimal sophiaAverage = sophiaTotal / currentAssignments;

            decimal nicholasTotal = (nicholas1 + nicholas2 + nicholas3 + nicholas4 + nicholas5);
            decimal nicholasAverage = nicholasTotal / currentAssignments;

            decimal zahirahTotal = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5);
            decimal zahirahAverage = zahirahTotal / currentAssignments;

            decimal jeongTotal = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5);
            decimal jeongAverage = jeongTotal / currentAssignments;

            //The expected output
            Console.WriteLine($"Student\t\tGrade");

            Console.WriteLine($"Sophia\t\t{sophiaAverage}\t'A'");
            Console.WriteLine($"Nicholas\t{nicholasAverage}\t'B'");
            Console.WriteLine($"Zahirah\t\t{zahirahAverage}\t'B'");
            Console.WriteLine($"Jeong\t\t{jeongAverage}\t'A'");

            Console.ReadLine();


        }
    }
}
