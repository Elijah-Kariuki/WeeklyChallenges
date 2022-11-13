using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber /n) +1)* n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
          
            foreach(var bus in businesses)
            {
                if(bus.TotalRevenue == 0)
                {
                    bus.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
             
            if (numbers == null || numbers.Length == 0)
            { 
                return false; 
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                { 
                    return false; 
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for( int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] %2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            //return (words == null || words.Length == 0) ? "" : (words.Aggregate((x, y) => x + " " + " " + y + "."));
            if(words == null || words.Length == 0)
             {
                 return "";
             }

             var goodwords = 0;
             List<string> sentence = new List<string>();
             for (int i = 0; i < words.Length; i++)
             {
                 if (words[i] == "" || words[i] == " " || words[i] == "  ")
                 {

                 }
                 else
                 {
                     sentence.Add(words[i].Trim());
                     goodwords +=1;
                 }
             }
             if(goodwords == 0)
             {
                 return "";
             }    
             else
             {
                 return String.Join(" ", sentence) + ".";
             }

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
           if(elements == null || elements.Count ==0)
                return new double[0];
           for(int i= 3; i < elements.Count; i+=4)
            {
                result.Add(elements[i]);
            }
           return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {

            for(int i = 0; i < nums.Length -1; i++)
            {
                for(int k = i +1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;

            throw new NotImplementedException();
        }
    }
}
