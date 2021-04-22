using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Summer
    {
        public static int ArrayAdder(Array x)
        {
            int arrayTotal = 0;

            foreach (int tempItem in x)
            {
                arrayTotal += tempItem;
            }

            return arrayTotal;
        }
    }
}
