﻿using System;
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
            return number % 2 == 0 ? true: false;
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
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
