namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Variable Declarations
            string game = "Overwatch";
            int year = 2016;
            char rating = 'B';
            double percent = 81.19;
            decimal decrease = 6.295m;
            bool isFun = true;

            // Output 
            Console.WriteLine($"{game} was released in {year} and currently has a game rating of {rating} at an {percent}% approval score.\n");
            Console.WriteLine($"The game's active playerbase has decreased to {decrease} million players, but is it still fun?\n");
            Console.WriteLine($"Still fun = {isFun}");
        }
    }
}
