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
                
            var checkString = string.Empty;

            for (var i = 0; i <= input.Length/2; i++)
            {

                checkString += input[i];

                if (input.Length % (i+1) == 0 && input.Length > 1)
                {
                    if (!RecursieCheckPrimeString(input, checkString))
                    {
                        return false;
                    }                    
                }
            }
            return true;

        }

        private bool RecursieCheckPrimeString(string input, string checkString)
        {
            var subInput = input.Substring(checkString.Length);

            if (subInput.Length > checkString.Length)
            {
                if (subInput.Substring(0, checkString.Length).Equals(checkString))
                {
                    return RecursieCheckPrimeString(subInput, checkString);
                }
            }

            if (subInput.Equals(checkString)) return false;

            return true;
        }
    }
}
