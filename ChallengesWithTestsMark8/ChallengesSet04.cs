using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            
           foreach (var number in numbers) 
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else 
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> stringList = new List<string>() { str1, str2, str3, str4 };

            int stringChar = stringList.Min(x => x.Length);

            return stringChar;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> intList = new List<int>() { number1, number2, number3, number4 };

            int smallestnum = intList.Min();

            return smallestnum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength2 + sideLength3 > sideLength1 &&
                sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            //return input.All(char.IsDigit);

            double d;
            bool isNumber = double.TryParse(input, out d);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var sum = 0;
            var numOfObj = objs.Length;
            

            foreach (var item in objs) 
            {
                if (item == null)
                {
                    sum++;
                }
              
            }
            
            var majority = (numOfObj / 2) + 1;
           
            if (sum >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {


            //List<int> evens = new List<int>();

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var evens = numbers.Where(x => x % 2 == 0);
            if (evens.Count() == 0)
            {
                return 0;
            }
            else
            {
                return evens.Average();

            }

           
            

            //foreach (var item in numbers)
            //{
            //   if (item % 2 == 0)
            //    {
            //        evens.Add(item);
            //    }

            //}

            //var average = evens.Average();

            //return average;

        }

        public int Factorial(int number)
        {
            if (number >= 0)
            {

                List<int> factList = new List<int>();
                int factNum = 1;

                for (int i = 1; i <= number; i++)
                {
                    factList.Add(i);

                }
                for (int j = 1; j <= factList.Count; j++)
                {
                    factNum *= j;
                }

                return factNum;

            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
