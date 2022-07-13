using static System.Console;

namespace Basic_String_Processing
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                _ = new BasicStringProcessing();
            } while(Continue());
        }

        private static string[] yes = { "yes", "y", "yup" };
        private static string[] no = { "no", "n", "nope" };

        private static bool Continue()
        {
            do
            {
                WriteLine("Press any key to continue.");
                ReadKey();
                Clear();
                Write("Would you like to continue Y/N? ");
                string input = ReadLine().ToLower().Trim();
                if(yes.Contains(input)) return true;
                else if(no.Contains(input)) return false; 
            } while(true);
        }
    }
}