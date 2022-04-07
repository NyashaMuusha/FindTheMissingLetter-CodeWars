using System;
using System.Collections.Generic;

namespace FIndTheMissingLetter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] inputArray= {'a','b','d'};
            Console.WriteLine(FindMissingLetter(inputArray));
        }
        public static char FindMissingLetter(char[] array)
        {
                var missingLetter = ' ';
                List<int> inCompleteAscList = new List<int>();
                List<int> completeAscCodeList = new List<int>();

                foreach (var arrayAscii in array)
                {
                    int asciiCode = arrayAscii;
                    inCompleteAscList.Add(asciiCode);
                }
                
                for (int i = 0; i < array.Length + 1; i++)
                {
                    completeAscCodeList.Add(array[0] + i);
                }

                foreach (var ascii in completeAscCodeList)
                {
                    if (!inCompleteAscList.Contains(ascii)) // Missing Character
                    {
                        missingLetter = Convert.ToChar(ascii);
                    }
                }
                return missingLetter;
        }
    }
}