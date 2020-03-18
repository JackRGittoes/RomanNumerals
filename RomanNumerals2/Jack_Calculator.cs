using System;

namespace RomanNumerals
{
    public class Jack_Calculator
    {
        public int ConvertRomanNumerals(string romanNumerals)
        {
            // Roman Numeral Value declarations 
            const int I = 1;
            const int V = 5;
            const int X = 10;
            const int L = 50;
            const int C = 100;
            const int D = 500;
            const int M = 1000;

            romanNumerals = romanNumerals.ToUpper();
            int[] numeralInts = new int[20];
            int convertedRomanNumerals = 0;

            // Loop until there are no values left in the array
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                // Converts the Input into Numeral values
                // Inputs Converted Integers into array 
                string val = Convert.ToString(romanNumerals[i]);
                switch (val)
                {
                    case "I":
		                numeralInts[i] = I;
                        break;
                    case "V":
		                numeralInts[i] = V;
                        break;
                    case "X":
		                numeralInts[i] = X;
                        break;
                    case "L":
		                numeralInts[i] = L;
                        break;
                    case "C":
		                numeralInts[i] = C;
                        break;
                    case "D":
		                numeralInts[i] = D;
                        break;
                    case "M":
		                numeralInts[i] = M;
                        break;
                    default: // If the case requirements are not met it will throw an exception by default
                        throw new System.ArgumentException(numeralInts + "Is not a valid Roman Numerals Input");

                }
               
            }

            // Loop until there are no values left in the array
            for (int i = 0; i < romanNumerals.Length; i++)
            {
                /* If the value of the next int position is larger than the current int 
                 * Then subtract the smaller int from the larger int */
                if (numeralInts[i + 1] > numeralInts[i])
                {
                    var number = numeralInts[i + 1] - numeralInts[i];
                    convertedRomanNumerals = convertedRomanNumerals + number;

                    //Skips the next int position to stop comparison of a used int
                    i += 1;
                }
                
                else
                {
                    convertedRomanNumerals = convertedRomanNumerals + numeralInts[i];
                }
               


            }

            return convertedRomanNumerals;
        }
    }
}