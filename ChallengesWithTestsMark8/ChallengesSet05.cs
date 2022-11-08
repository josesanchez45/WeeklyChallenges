﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do
            {
                startNumber++;

            }
            while (startNumber % n != 0);

            return startNumber;





        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {

            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }

            }


        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            var x = numbers.OrderBy(x => x).ToArray();

            if (numbers.SequenceEqual(x))
            {
                return true;
            }
            else return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string result = "";
            foreach (string word in words)
            {
                if (word.Trim().Length > 0)
                {
                    result += word.Trim() + " ";
                }
            }
            if (result.Length == 0)
            {
                return "";
            }
            result = result.Substring(0, result.Length - 1);
            result += ".";
            return result;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var x = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return x.ToArray();
            }

            for (int i = 3; i < elements.Count; i += 4)
            {
                x.Add(elements[i]);
            }
            return x.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if ((nums[i] + nums[k]) == targetNumber)
                    {
                        return true;
                    }

                    
                }
            }
            return false;
        }
    }
}