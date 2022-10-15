using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers.Count() != 0 || numbers == null ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var evenSum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }

            }
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 == 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            do
            {
                for (var i = number; i > 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                        count++;
                    }
                }
            } while (number <= 0);
            return count;
        }
    }
}


