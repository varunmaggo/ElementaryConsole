using System;

namespace ElementaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReverseString("OmegaEpisode");

            Console.ReadLine();
        }

        static void ReverseString(string myString)
        {
            char[] charArray = myString.ToCharArray();

            for (int i = 0, j = myString.Length -1; i < j; i++, j--)
            {
                charArray[i] = myString[j];
                charArray[j] = myString[i];

            }

            string myNewReversedString = new string(charArray);


            Console.WriteLine(myNewReversedString);
        }
    }
}
