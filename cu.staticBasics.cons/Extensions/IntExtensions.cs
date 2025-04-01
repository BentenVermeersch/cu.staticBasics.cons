using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cu.staticBasics.cons.Extensions
{
    public static class IntExtensions
    {
        public static int Add(this int number,int numberToAdd)
        {
            return number + numberToAdd;
        }
        public static int CustomAverage(this IEnumerable<int> values)
        {
            int total = 0;
            var enumerable = values as int[] ?? values.ToArray();
            foreach(var value in enumerable)
            {
                total += value;
            }
            return total / enumerable.Count();
        }
    }
}
