using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int x in numbers)
            {
                if (x % 2 == 0)
                {
                    sum += x;
                }
                else if (x % 2 == 1)
                {
                    sum -= x;
                }

            }
            return sum;

            //return numbers.Where(x => x % 2 == 0).Sum () -  numbers.Where(x => x % 2 !=0.Sum();   //Linq method

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>()
            {
                str1.Length,
                str2.Length,
                str3.Length,
                str4.Length
            };

            return list.Min();

            //if (str1.Length < str2.Length && str1.Length < str3.Length && str1.Length < str4.Length)
            //{
            //    return str1.Length;
            //}

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };

            {
                return list.Min();
            };

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //if (sideLength1 + sideLength2 > sideLength3 ;// and if all sides are equal than it's true you can form a triangle 

            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }

            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input == "")
            {
                return false;
            }
            else if (double.TryParse(input, out double result2))
            {
                Console.WriteLine($"The parsed number is: {result2}");
                return true;
            }
            else
            {
                return false;
            }



            // var isNumber= double.TryParse(input, out double number);//
            //return isNumber;//



        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {

            double count = 0;
            double itemCount = objs.Length;
            for (int i = 0; i < objs.Length; i++)    //for each statement and sum
            {

                if (objs[i] == null)               //or can put as: if(!objs[i])
                {
                    count++;
                }

            }

            return count / itemCount > 0.5;
        }

        public double AverageEvens(int[] numbers)  ////////////////////
        {

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            double evenSum = 0;
            double evenCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                    evenCount++;
                }
            }

            if (evenCount == 0)
            {
                return 0;
            }

            return evenSum / evenCount;

        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0) return 1;

            if (number > 1)

            {
                return number * Factorial(number - 1);

            }
            else
            {
                return number;

            }
            // return (number == 0) ? 1 : Enumerable.Range(1, number).Aggregate((f, s) => f * s);

            //if number is less than 0 than throw a new ArgumentOutOfRangeException();

        }
    }
}
