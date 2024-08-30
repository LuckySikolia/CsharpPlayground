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

            /* This module challenges you to add new capabilities to your Student Grading application.
            In short, you need to use the teacher's updated grading report specification to:
                update the iteration and selection code to calculate separate final scores for exams, extra credit assignments, and the overall grade.
                update the code that writes the grading report to the console*/ 


            //initializations
            int currentAssignments = 5;   //Initialize the variables for the graded assinments         
            int sum = 0;   //initialize sum to 0
            string currentStudentGrade = ""; // initialize the grade letter

            int updatedScoreReport = 0; //instanctiate variables that are requiredfor the updates score report
            int extraCredit = 0;
            double extraCreditPoints = 0;

            //Arrays for student names and their individual assignment scores
            string[] studentNames = { "Sophia", "Nico", "Zahira", "Jeong" };

            //creating nested arrays that store each students assingment scores
            int[][] studentScores =
            {
                new int[]{ 90, 86, 87, 98, 100, 92 },
                new int[]{ 92, 89, 81, 96, 90 },
                new int[]{ 90, 85, 87, 98, 68 },
                new int[]{ 90, 95, 87, 88, 96 }

            };

            Console.WriteLine();
            //The expected output
            Console.WriteLine($"Student\t\t Exam Score \t Overall Grade \t\t Extra Credit");

            Console.WriteLine();

            for (int i = 0; i < studentNames.Length; i++)
            {
                sum = 0; //reset sum for each student
                extraCredit = 0; //reset extra credit for each student
                extraCreditPoints = 0; //reset extra credirt points for all students


                /*Detects extra credit assignments based on the number of elements in the student's scores array.
                    Applies a 10 % weighting factor to extra credit assignments before adding extra credit scores to the sum of exam scores.*/

                //check for extra credits
                if (studentScores[i].Length > currentAssignments)
                {
                    extraCredit = studentScores[i][studentScores[i].Length - 1];
                    Console.WriteLine("This student has extra credits");
                    extraCreditPoints = extraCredit * 0.1; //apply 10% weighting
                }

                //calculate the total grade of the students minus the extra credit points before calculating the average grade
                for (int j = 0; j < studentScores[i].Length - (extraCreditPoints > 0 ? 1 : 0 ); j++)
                {
                    sum += studentScores[i][j];
                }

                //add the extra credit points to the total sum
                sum += (int)extraCreditPoints;

                //calculate total grades for each student including 
                /* foreach (int score in studentScores[i])
                 {
                     sum += score;
                 }*/

                //calculate the average grade
                decimal averageGrade = sum / (decimal)currentAssignments;
                //decimal averageGrade = sum / (decimal)studentScores[i].Length;

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

                
                Console.WriteLine($"{studentNames[i]}\t\t {updatedScoreReport} \t\t {averageGrade:F1} \t {currentStudentGrade} \t\t {extraCredit}({extraCreditPoints:F2} pts) ");
            }



            /* This module challenges you to add new capabilities to your Student Grading application.
             In short, you need to use the teacher's updated grading report specification to:
                 update the iteration and selection code to calculate separate final scores for exams, extra credit assignments, and the overall grade.
                 update the code that writes the grading report to the console*/

            
            


            Console.ReadLine();


        }
    }
}
