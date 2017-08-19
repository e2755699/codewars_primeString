using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace codewars_primeString
{
    class PrimeString
    {
        internal bool Accum(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            return CheckStringPrime(input);
        }

        private bool CheckStringPrime(string input)
        {

            for (var i = 1; i <= input.Length / 2; i++)
            {

                if (input.Length % i == 0)
                {
                    if (RecursieCheckPrimeString(input, i))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool RecursieCheckPrimeString(string input, int length)
        {
            return (input.Replace(input.Substring(0, length), "").TrimEnd() == "");

            //var subInput = input.Substring(checkString.Length);

            //if (subInput.Length > checkString.Length)
            //{
            //    if (subInput.Substring(0, checkString.Length).Equals(checkString))
            //    {
            //        return RecursieCheckPrimeString(subInput, checkString);
            //    }
            //}

            //if (subInput.Equals(checkString)) return false;

            //return true;
        }
    }
}
