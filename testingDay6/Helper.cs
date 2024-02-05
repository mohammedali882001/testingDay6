using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingDay6
{
    internal class Helper
    {
        public int ID { get; set; }
        public static bool isOdd(int item)
        {
            return item % 2 != 0;
        }

        public bool isNegative(int item)
        {
            return item < 0;
        }
    }
}
