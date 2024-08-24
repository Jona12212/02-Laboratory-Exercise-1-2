using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COmputerAverageApp1
{
    internal class ComputerAverageProgram
    {
        static void Main(string[] args)
        {
            // Display to input how many subjects
            Console.Write("Enter how many subjects you have: ");
                int numSubjects = Convert.ToInt32(Console.ReadLine());   
            
            //declaring variables
            int Sum=0,Grades;
            double Average;

            Console.WriteLine("Enter " + numSubjects+ " grades separated by new line: ");
            //for loop for entering the grades multiple times
            for (int i = 0; i < numSubjects; i++)
            {
                Grades = Convert.ToInt32(Console.ReadLine());
                //To add all the grades
                Sum += Grades;
            }
            //equation for the average
            Average = Sum/(double)numSubjects;

            Console.WriteLine("The average is " + Average + " and round off to " +  Math.Round(Average, 0) + ".");
        }
    }
}
           
