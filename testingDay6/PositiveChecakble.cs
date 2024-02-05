using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingDay6
{
    internal class PositiveChecakble : ICheckable
    {
        bool ICheckable.Check(int item)
        {
            return item > 0;
        }
    }
}
