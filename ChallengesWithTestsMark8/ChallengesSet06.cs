using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int i = 1; i <= num;  i++)
            {
                if( num % i == 0)
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
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
