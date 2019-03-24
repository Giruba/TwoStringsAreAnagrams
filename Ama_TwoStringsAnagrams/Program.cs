using System;

namespace Ama_TwoStringsAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verify if two given strings are anagrams" +
                "of each other!");
            Console.WriteLine();

            bool AreAnagrams = verifyIfTwoStringsAreAnagrams();
            if (AreAnagrams)
            {
                Console.WriteLine("The two strings entered are " +
                    "anagrams of each other!");
            }
            else {

                Console.WriteLine("The two strings entered are " +
                    "not anagrams of each other!");
            }

            Console.ReadLine();
        }

        private static bool verifyIfTwoStringsAreAnagrams() {
            bool result = false;

            try
            {
                Console.WriteLine("Enter the first string");
                String firstString = Console.ReadLine().Trim();
                Console.WriteLine("Enter the second string");
                String secondString = Console.ReadLine().Trim();

                char[] array1 = firstString.ToCharArray();
                Array.Sort(array1);
                char[] array2 = secondString.ToCharArray();
                Array.Sort(array2);

                if (new String(array1) == new string(array2))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return result;

        }
    }
}
