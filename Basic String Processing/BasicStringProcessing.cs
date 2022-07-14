using static System.Console;


namespace Basic_String_Processing
{
    internal class BasicStringProcessing
    {
        string input;
        List<string> stringList;

        public BasicStringProcessing()
        {
            GetStringInput();
            PrintResults();
        }

        private void PrintResults()
        {
            foreach(var item in stringList)
            {
                WriteLine(item);
            }
        }

        private void GetStringInput()
        {
            Clear();
            Write("Enter a sentence: ");
            input = ReadLine();
            stringList = input.Split(" ").ToList();
        }
    }
}
