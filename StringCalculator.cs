using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcTest2
{
    public class StringCalculator
    {
        public int Add(string nums)
        {
            if (String.IsNullOrEmpty(nums))
                return 0;
            else
            {
                string[] numbers = nums.Split(',');
                int sum = 0;
                foreach (string num in numbers)
                    sum += Int32.Parse(num);
                return sum;
            }


        }
    }
}
