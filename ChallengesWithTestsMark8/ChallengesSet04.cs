using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = numbers.Where(x => x % 2 == 0).ToList().Sum();
            var odds = numbers.Where(x => x % 2 != 0).ToList().Sum();

            return evens - odds;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<string> shortest = new List<string>()
                { str1, str2, str3, str4 };
            return shortest.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> smallest = new List<int>()
            { number1, number2, number3, number4 };
            return smallest.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            var realName = "TrueCoders";
            if (biz.Name != realName)
            {
                biz.Name = realName;
            }
            else
                biz.Name = realName;

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 
                && sideLength2 + sideLength3 > sideLength1
                && sideLength1 + sideLength3 > sideLength2)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {


            try
            {
                double.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }

           


        }
        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var countOfNulls = 0;
            var countOfOthers = 0;

            for (int i = 0; i < objs.Length; i++)
            {

                if (objs[i] == null)
                {
                    countOfNulls++;
                }
                else
                {
                    countOfOthers++;
                }

            }
            if (countOfNulls > countOfOthers)
            {
                return true;
            }
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null ||
                numbers.Length == 0 ||
                numbers.All(x => x % 2 != 0))
            {
                return 0;
            }
            return numbers.Where(x => x % 2 ==0 ).Average();
        }

        public int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
           
            for (var i = number - 1; i >= 1; i--)
            {
                number *= i;
            }
            return number;
        }
    }
}
