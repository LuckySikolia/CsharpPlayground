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


            //initializations
            int currentAssignments = 5;   //Initialize the variables for the graded assinments         
            int sum = 0;   //initialize sum to 0
            string currentStudentGrade = ""; // initialize the grade letter

            //Arrays for student names and their individual assignment scores
            string[] studentNames = { "Sophia", "Nicholas", "Zahira", "Jeong" };

            //creating nested arrays that store each students assingment scores
            int[][] studentScores =
            {
                new int[]{ 90, 86, 87, 98, 100 },
                new int[]{ 92, 89, 81, 96, 90 },
                new int[]{ 90, 85, 87, 98, 68 },
                new int[]{ 90, 95, 87, 88, 96 }

            };

            Console.WriteLine();
            //The expected output
            Console.WriteLine($"Student\t\t Grade");

            Console.WriteLine();

            for (int i = 0; i < studentNames.Length; i++)
            {
                sum = 0; //reset sum for each student

                //calculate total grades for each student
                foreach (int score in studentScores[i])
                {
                    sum += score;
                }

                //calculate the average grade
                decimal averageGrade = sum / (decimal)currentAssignments;

                //code to detemine the student's grade letter
                if (averageGrade >= 97)
                {
                    currentStudentGrade = "A+";

                }
                else if (averageGrade >= 93)
                {
                    currentStudentGrade = "A";

                }
                else if (averageGrade >= 90)
                {
                    currentStudentGrade = "A-";

                }
                else if (averageGrade >= 87)
                {
                    currentStudentGrade = "B+";

                }
                else if (averageGrade >= 83)
                {
                    currentStudentGrade = "B";

                }
                else if (averageGrade >= 80)
                {
                    currentStudentGrade = "B-";

                }
                else if (averageGrade >= 77)
                {
                    currentStudentGrade = "C+";

                }
                else if (averageGrade >= 73)
                {
                    currentStudentGrade = "C";

                }
                else if (averageGrade >= 70)
                {
                    currentStudentGrade = "C-";

                }
                else if (averageGrade >= 67)
                {
                    currentStudentGrade = "D+";

                }
                else if (averageGrade >= 63)
                {
                    currentStudentGrade = "D";

                }
                else if (averageGrade >= 60)
                {
                    currentStudentGrade = "D-";

                }
                else if (averageGrade >= 0)
                {
                    currentStudentGrade = "F";

                }
                Console.WriteLine($"{studentNames[i]}\t\t\t\t {averageGrade:F1} \t\t {currentStudentGrade} ");
            }
           
          
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //The expected output
            Console.WriteLine($"Student\t\t Grade");

            Console.WriteLine();

            //Console.WriteLine($"{studentNames[i]}\t\t {averageGrade:F1} \t\t {currentStudentGrade} ");
            //Console.WriteLine($"{studentNames[i]}\t\t{averageGrade:F1}\t {currentStudentGrade}");

            Console.WriteLine("Press the Enter key to continue");


            /* Console.WriteLine($"Sophia\t\t{sophiaAverage}\t'A'");
             Console.WriteLine($"Nicholas\t{nicholasAverage}\t'B'");
             Console.WriteLine($"Zahirah\t\t{zahirahAverage}\t'B'");
             Console.WriteLine($"Jeong\t\t{jeongAverage}\t'A'");*/

            Console.ReadLine();


        }
    }
}
