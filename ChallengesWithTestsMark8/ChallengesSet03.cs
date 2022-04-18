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
                if (vals[i] == false)
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
            int validConditions = 0;
            foreach (char c in password)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    break;
                }
                {
                    return true;
                }
            } return false;

            foreach (char c in password)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    break;
                }
                {
                    return true;
                }
            } return false;

            if (validConditions == 0) return false;

            foreach (char c in password)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                    break;
                    {
                        return true;
                    }
                }
                return false;

            }

            public char GetFirstLetterOfString(string val)
            {
                // str = str.Substring(n);//

                char firstCharacter = str[0];
                Console.WriteLine(firstCharacter);
            }

            public char GetLastLetterOfString(string val)


            {
                return char lastCharacter = str[0];

            }

            public decimal Divide(decimal dividend, decimal divisor)
            {
                if (divisor == 0 || dividend == 0)
                {
                    return 0;
                }

                return dividend / divisor;



                public int LastMinusFirst(int[] nums)
                {
                    return nums[nums.Length - 1] - nums[0];
                }

                public int[] GetOddsBelow100()
                {
                    int[] nums = new int[100];

                    for (int i = 0; i < nums.Length; i++)
                    {
                        //condition to check ODD number
                        if (nums[i] % 2 != 0)

                        {
                            return nums;

                        }

                    }

                }

                public void ChangeAllElementsToUppercase(string[] words)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        words[i] = words[i].ToUpper();
                    }

                }
            }
        }
    }

}




