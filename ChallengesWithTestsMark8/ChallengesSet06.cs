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
            
            if (words == null)
            {
                return false;
            }
           ignoreCase = words.Any(x => x == word.ToLower());
           return words.Contains(word) && ignoreCase;              
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
            throw new NotImplementedException();
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
