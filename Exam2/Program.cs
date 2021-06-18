using System;

namespace Exam2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SearchWord();
        }

        private static void SearchWord()
        {
            string str;
            string word;
            int count = 0;
            Console.WriteLine("Enter a String");
            str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            word = Console.ReadLine();
        }
    }
}