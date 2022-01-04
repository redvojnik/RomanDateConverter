using System;
using System.Collections.Generic;

namespace ParsingRomanDate
{
    public static class RomanNumerals
    {
        private static readonly Dictionary<char, int> RomanDate =
        new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public static int ParseToArabianNumerals(string userRomanDate)
        {
            int arabianDate = RomanDate[userRomanDate[userRomanDate.Length - 1]];
            if (userRomanDate.Length == 1)
                return arabianDate;
            else
            {
                for (int i = userRomanDate.Length - 2; i >= 0; i--)
                {
                    arabianDate = arabianDate > RomanDate[userRomanDate[i]] 
                        ? arabianDate - RomanDate[userRomanDate[i]] 
                        : arabianDate + RomanDate[userRomanDate[i]];
                }
                return arabianDate;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write Roman Date: ");
            string userRDate = Console.ReadLine();
            Console.WriteLine("Arabian date is "+RomanNumerals.ParseToArabianNumerals(userRDate));
            Console.ReadLine();
        }
    }
}
