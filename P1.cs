using System;

namespace TNPractice{

    class Practice1
    {
        // Don't instantiate it you fool
        private Practice1() { }
        /// <summary>
        /// Aim is to determine if provided integers a and b are not both positive or negative.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool DifferentSigns(int a , int b)
        {

            // Proof:
            // Suppose one number is negative and one is not.
            // Through two's complemente
            // the leading bit of the negative int will be 1. 
            // therefore the XOR value of the leading bit will be 1.
            // therefore the results of a XOR b will be negative.
            return ((a ^ b) < 0);

        }


        // The insight into solving this problem is to look at the information lost by performing an and operation:
        // given two bits, A and B, whenever either is a 0, the & operator returns a 0.
        // we can then write either is false as either_is_false = ( ~ A | ~ B )
        // if it is not that either is false, then both are true. Thus both_are_true = ~ ( ~ A | ~ B )
        // return ~ ( ~ A | ~ B )
        
        /// <summary>
        /// implements bitwise And using the ~ and | operators.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int bitwiseAnd(int a, int b)
        {
            return ~(~a | ~b);
        }


	}

	

}