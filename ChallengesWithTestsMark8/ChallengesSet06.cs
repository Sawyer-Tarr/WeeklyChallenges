using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool ifContainsWord = false;
            if (words == null || words.Contains(null)) 
            {
                return false;
            }

            if (ignoreCase)
            {
                word = word.ToLower();

                List<string> list = words.Select(words=> words.ToLower()).ToList();

                ifContainsWord= list.Contains(word);
            }

            if (ignoreCase == false)
            {
                ifContainsWord = words.Contains(word);

            }

            return ifContainsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var prime = false;

            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    prime = true;

                }
            }
            if (num == 2 || num == 3)
            {
                prime = true; 
            }
            if (num == 1)
            {
                prime = false;
            }
           
            return prime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int letter = -1;
            bool uniqueletter;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueletter = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueletter = false;

                    }
                }
                if (uniqueletter == true)
                {
                    letter = i;
                }
                
            }
            return letter; 

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int nowCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }

                    nowCount++;
                }
                if (nowCount > count)
                {
                    count = nowCount;
                }
            }

            return count;


        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
             var number = new List<double>();

            if (elements == null || n <=0 || elements.Count < n)
            {
                return number.ToArray();

            }

            for (int i = n -1 ; i < elements.Count; i+= n)
            {
                number.Add(elements[i]);
            }
            return number.ToArray();
        }
    }
}
