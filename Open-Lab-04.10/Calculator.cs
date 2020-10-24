using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._10
{
    public class Calculator
    {
        public float Average(int[] nums)
        {
            
            float f = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                f = f + nums[i];
            }
            float f2 = f / nums.Length;
            return f2;
        }
    }
}
