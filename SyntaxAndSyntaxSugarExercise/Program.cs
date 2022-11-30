using System.Runtime.CompilerServices;

namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int answer = 4; // Explicit Typing
            //string response; // Explicit Typing

            //if (answer < 9)
            //{
            //    response = answer + "is less than nine";
            //}
            //else 
            //{
            //    response = answer + "greater than or equal to nine";
                
            //}

            var answer = 4; // Inferred Typing
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
    }
}
