using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using Xunit;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }

            if (ignoreCase == true)
            {
                word = word.ToLower();

                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
                return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            return str.IndexOf(str.Distinct().Reverse().FirstOrDefault(x => str.Count(y => y.Equals(x)) == 1));
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            var currentNumber = numbers[0];
            var count = 0;
            var highestCount = 0;
            foreach (var num in numbers)
            {
                if (num == currentNumber)
                {
                    count++;
                    if (count > highestCount)
                    {
                        highestCount = count;
                    }
                }
                else
                {
                    if (count > highestCount)
                    {
                        highestCount = count;
                    }
                    currentNumber = num;
                    count = 1;
                }
            }
            return highestCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var result = new List<double>();
            if (elements == null || n <= 0 || elements.Count == 0 || n < 0 || !elements.Any())
            {
                return result.ToArray();
            }
            for (int i = n-1; i < elements.Count; i+=n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
