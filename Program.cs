using System;

namespace ElementaryConsole
{
    //start
    //end
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CheckPallindrome("madam");
            //CheckPallindrome("Superman");

            //ReverseString("OmegaEpisode");
            Console.ReadLine();
        }

        static void CheckPallindrome(string myString)
        {
            bool flag = false;

            for (int i = 0, j = myString.Length - 1;
                i < myString.Length / 2; 
                i++, j--)
            {
                if (myString[i] != myString[j])
                {
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;
                }
            }

            if (flag)
            {
                Console.WriteLine(myString + " - Pallindrome");
            }
            else
            {
                Console.WriteLine(myString + " - Not Pallindrome"); 
            }
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
