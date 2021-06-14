using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public class Calculation
    {
        public static int Addition(int num)
        {
           int addNum = num + 75;
            return addNum;
        }

        public static int subtraction(int num)
        {
            int subNum = num - 12;
            return subNum;
        }

        public static int division(int num)
        {
            int divNum = num / 2;
            return divNum;
        }

    }
}
