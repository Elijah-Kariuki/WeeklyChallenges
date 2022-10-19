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
            return numbers == null|| numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max(); 
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
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
            return numbers.Sum() % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long count = 0;
            //if (number ==1 || number <=0)
            //{ return 0; }
            
            for (long i = number -1; i >= 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        count ++;
                    }
                }

            return count;
        }
    }
}


