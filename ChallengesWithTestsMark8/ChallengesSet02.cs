using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            return false;

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var evenElements = vals.Length % 2;

            if (evenElements == 0)
            {
                return true;
            }
            else return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else return false;
        }
        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            var maxNum = numbers.Max();
            var minNum = numbers.Min();

            return maxNum + minNum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int answer = 0;
            for (int i = 0; i < numbers.Length; i++)

            {

                answer += numbers[i];
            }
            return answer;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            int sumEvens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 == 0)
                {
                    sumEvens += numbers[i];

                }

            }
            return sumEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return false;
            }
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            if (sum % 2 == 0)
            {
                return false;
            }
            else 
                return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if ( number == null ||number <= 0) 
            {
                return 0;
            }
            return number / 2 ;
        }
    }
}
