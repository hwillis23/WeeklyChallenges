using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            bool result = Char.IsLetter(c);
            return result;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var result = vals.Count();
            if (result %2 == 0)
            {
               return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool IsNumberEven(int number)
        {
            bool result = number %2 == 0;
            return result;
        }
        //return (number % 2 == 0) true : false;
        // can refactor to this:  return (number % 2 == 0);

        public bool IsNumberOdd(int num)
            // return (num %2 != 0); 
        {
            bool result = num %2 != 0;
            return result;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        //get the min and max then add them together  look up online Mircosoft Enumerable.Max Method
        //don't forget there is a null
        // list (numbers == null|| ) first or it will throw a error
        
        {     //Null check
            if (numbers == null || numbers.Count() == 0)
            { 
                return 0; 
            }

            return numbers.Min() + numbers.Max();  //sum of min and max
        }

        public int GetLengthOfShortestString(string str1, string str2)
            //can treat string like an array, so can use  .Length (string of int)
            //
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else 
            {
                return str2.Length;      
            }
        }

        public int Sum(int[] numbers)
            //add all the numbers and return as a int
           // put if null first so it will run at the beginning
           // tertinary way: return (numbers == null) ? 0 : numbers.Sum();
        { 
            if (numbers == null)
            { 
                return 0;
            }
            var sum = 0; //initalize a variable and give it zero so sum has a value   
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return numbers.Sum();  
            // or use return sum;
            // or use tertinary to get answer:  return (numbers == null) ? 0 : numbers.Sum();
            
        }

        public int SumEvens(int[] numbers)
            //can also do as a foreach loop 
        { 
            if (numbers == null)
            {
                return 0;
            }
            var sumOfEvens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 ==0)
                {
                    sumOfEvens += numbers[i];  //sumofEvens = SumofEvens + numbers[i];
                }
            }
            return sumOfEvens;

            //return (numbers == null) ? 0 : numbers.Where(x => % 2 == 0).Sum();
          
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers==null)  
                { 
                return false;
                }

            return (numbers.Sum() % 2 != 0);
        }
        //can also be refactored as a tertinary
        // could do If else statement

        public long CountOfPositiveOddsBelowNumber(long number)
        // can also do it as a for loop
        {
          
           if (number <= 0)       // need if statement to account for negative numbers 
             {
                return 0;
              }
           else
              {
                 return number / 2;   //could do a reverse for loop
              }

           

        }
    }
}
