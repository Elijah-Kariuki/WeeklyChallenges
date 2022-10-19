using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool isFalse;
            foreach(var val in vals)
            { if (val == false)
                { return true; }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            var sum = numbers.Sum();
            return (sum %2 != 0) ? true:false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLower = false;
            var isUpper = false;
            var isNumber = false;

            foreach (var key in password)
            {
                if (char.IsLower(key))
                { isLower = true; }
                if (char.IsUpper(key))
                { isUpper = true; }
                if (char.IsNumber(key))
                { isNumber = true; }
            }
            return isLower == true && isNumber == true && isUpper == true? true : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        { 
            if(divisor == 0)
            { return 0; }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i]=words[i].ToUpper();
            }
            
        }

    }
}
