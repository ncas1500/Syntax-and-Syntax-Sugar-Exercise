namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {/*
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }

            //Ternary Operator

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);

            //String Interpolation

            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = ($"{answer} is less than nine");
            }
            else
            {
                response = ($"{answer} is greater than or equal to nine");
            }
            Console.WriteLine(response)*/;

            //Inferred Typing

            var answer = 4;
            var response = "";

            if (answer < 9)
            {
                response = (answer + " is less than nine");
            }
            else
            {
                response = (answer + " is geater than or equal to nine");
            }
            Console.WriteLine(response);
        }
    }
}
