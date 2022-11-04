using System;

namespace FirstApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please type any word or collection of symbols"); // Get a string from user
            string enteredText = Console.ReadLine(); // Get a string from input
            countMaxDifferentCharInLine(enteredText);
        }

        private static void countMaxDifferentCharInLine(string line) { 

            Console.WriteLine("You entered: {0}", line); // Write inputx
            Console.WriteLine("Lets find maximum number of unequal consecutive characters per line"); // Write what we gonna do
            char[] charArr = line.ToCharArray(); // string to chars
            int defferentCharCounter = 1; // 
            int maxDifferentCharCounter = 1; //

            for (int i = 0; i < charArr.Length - 1; i++)
            {
               Console.WriteLine("Character number {0} is \"{1}\". Character number {2} is \"{3}\"", i, charArr[i], i + 1, charArr[i+1]);
                if (charArr[i] != charArr[i+1]) { // not equal
                    defferentCharCounter++; // +1 to counter
                    if(defferentCharCounter > maxDifferentCharCounter)
                    {
                        maxDifferentCharCounter = defferentCharCounter;
                    }
                    Console.WriteLine("This characters are unequal");
               } else {
                    defferentCharCounter = 1;
                   Console.WriteLine("This characters are equal");
                }
            }
            // Write input
            Console.WriteLine("Maximum number of unequal consecutive characters in \"{0}\" is {1}", line, maxDifferentCharCounter);

        }
    }
}
