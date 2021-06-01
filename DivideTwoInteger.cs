using System;

public class DivideTwoInteger
{
    public class Solution
    {

        public int Divide(int dividend, int divisor)
        {

            if (divisor == 0)
            {
                throw new DivideByZeroException();
            }

            long result = (long)dividend / (long)divisor;

            if (result < int.MinValue || result > int.MaxValue)
            {
                return (int)Math.Pow(2, 31) - 1;
            }

            return (int)result;
        }
    }
}
