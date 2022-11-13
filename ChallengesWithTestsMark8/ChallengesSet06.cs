using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            
            return string.Equals(words, null) || words.Contains(null) ? 
                   false : ignoreCase == true ? words.Select(x => x.ToLower())
                   .ToList().Contains(word.ToLower()) :
                   ignoreCase == false ? words.Contains(word) : false;
        }

        public bool IsPrimeNumber(int num)
        {
            var isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                { isPrime =true; }
            }
            if (num == 2 || num == 3)
            { isPrime =true; }
            if (num == 1)
            { isPrime=false;}
            return isPrime;
                 
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var index = -1;
            bool unidex;
            for (int i = 0; i < str.Length; i++)
            {
                unidex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        unidex = false;
                    }
                }
                if (unidex == true)
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var count =0;
        
            for (int i = 0; i < numbers.Count(); i++)
            {
               int currentCount = 1;

                for (int j = i + 1; j < numbers.Count(); j++)
                {
                   
                    if (numbers[i] != numbers[j] && i != j)
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();
            double[] nullCheck = new double[0];

            if (elements == null )
            {
                return nullCheck;
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthElement.Add(elements[i]);
                }
                if (n < 0 || n > elements.Count)
                {
                    nthElement.Clear();
                }
            }
            double[] finalArray = nthElement.ToArray();
            
            return finalArray;
        }
    }
}
