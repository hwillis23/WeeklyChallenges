using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        { if (vals == null)
            {
                return false;

            }

            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)     //or can put as: if(!vals[i])
                {
                    return true;
                }

            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            if (numbers.Sum() % 2 != 0)
            {
                return true;
            }

            return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
           var isLower = false;
            var isUpper = false;
            var isDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    isLower = true;
                }

                if (char.IsUpper(password[i]))
                {
                    isUpper = true;
                }
                if (char.IsDigit(password[i]))
                {
                    isDigit = true;
                }
            }

                if (isLower == true && isUpper == true && isDigit == true)
                {
                    return true;

                }
                else
                {
                    return false;
                }

            

        }

            public char GetFirstLetterOfString(string val)
            {
                return val[0];    
               
              // return val.First();  using Linq

            }

            public char GetLastLetterOfString(string val)


            {
                return val [val.Length - 1];

             // return val.Last();  using Linq

            }

    public decimal Divide(decimal dividend, decimal divisor)
    {
        if (divisor == 0)
        {
            return 0;
        }

        return dividend / divisor;
    }



                public int LastMinusFirst(int[] nums)
                {
                    return nums[nums.Length - 1] - nums[0];

                 //return nums.Last() - nums.First();
                }

                public int[] GetOddsBelow100()
                {
                    var nums = new List<int>();   //create a list  , they are more flexible

                    for (int i = 0; i < 100; i++)
                    {
                        //condition to check ODD number
                        if (i % 2 != 0)

                        {
                           nums.Add (i);
                        }
                    }

                return nums.ToArray();
                
                }

                public void ChangeAllElementsToUppercase(string[] words)
                {
                    for (var i = 0; i < words.Length; i++)
                    {
                        words[i] = words[i].ToUpper();
                    }

                    // can't really do Foreach loop with this method

                }
            }
        }
    






