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
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var checkString = string.Empty;

            for (var i = 0; i <= input.Length/2; i++)
            {

                checkString = string.Concat(checkString, input[i]);

                if (input.Length % (i+1) == 0 && input.Length > 1)
                {
                    if (!RecursieCheckPrimeString(input.Substring(checkString.Length), checkString))
                    {
                        return false;
                    }                    
                }
            }
            return true;

        }

        private bool RecursieCheckPrimeString(string subInput, string checkString)
        {
           
            if (subInput.Length > checkString.Length)
            {
                if (subInput.Substring(0, checkString.Length).Equals(checkString))
                {
                    if (RecursieCheckPrimeString(subInput.Substring(checkString.Length), checkString))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else if (subInput.Length == checkString.Length)
            {
                if (subInput.Equals(checkString))
                {
                    return false;    
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

        }
    }
}
