using static System.Console;


namespace Basic_String_Processing
{
    internal class BasicStringProcessing
    {
        string input;
        List<string> stringArray;

        public BasicStringProcessing()
        {
            GetStringInput();
            PrintResults();
        }

        private void PrintResults()
        {
            foreach(var item in stringArray)
            {
                WriteLine(item);
            }
        }

        private void GetStringInput()
        {
            Clear();
            Write("Enter a sentence: ");
            input = ReadLine();
            stringArray = input.Split(" ").ToList();
        }
    }
}
