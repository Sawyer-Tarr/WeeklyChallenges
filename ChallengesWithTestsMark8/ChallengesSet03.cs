using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool i in vals) 
            {
                if (i == false)
                {
                    return true;
                }
               
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if ( numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            int sum = 0;
            foreach (var item in numbers)
            {
                if (item % 2 != 0)
                {
                    sum += item;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //var sum = numbers.Where(x => x % 2 != 0).Sum(x => x);

            //if (numbers == null)
            //{
            //    return false;
            //}
            //else if (sum % 2 != 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;
            foreach (var ch in password)
            {
                if (char.IsLower(ch))
                {
                    isLower = true;
                }
                if (char.IsUpper(ch))
                {
                    isUpper = true;

                }
                if (char.IsNumber(ch))
                {
                    isNumber = true;
                }

            }
            if (isLower && isUpper && isNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] firstLetter = val.ToCharArray();

            return firstLetter[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] lastLetter = val.ToCharArray();

            return lastLetter[lastLetter.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    list.Add(i);
                }
            }
            return list.ToArray();

            //int[] below100 = new int[50];

            //var belowList = below100.ToList();

            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        belowList.Add(i);
            //    }

            //}
            //below100 = belowList.ToArray();

            //return below100;

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
