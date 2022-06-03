using System;

namespace SyntaxExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
// GIVEN CODE
            //int answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + " is greater than or equal to nine";
            //}

// WORKING CODE
            //var answer = 4;
            //string response;
            //if (answer < 9)
            //{
            //    response = $"{answer} is less than nine";
            //}
            //else
            //{
            //    response = $"{answer} is greater than or equal to nine";
            //}
            //Console.WriteLine(response);

// EXERCISE COMPLETED CODE
            Console.WriteLine("Enter a number: ");
            var answer = Convert.ToInt32(Console.ReadLine());
            string response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}
