using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.Problem_13
{
    public static class RectangleHelper
    {
        public static void Swap(ref Rectangle rect1, ref Rectangle rect2)
        {
            Rectangle temp = rect1;
            rect1 = rect2;
            rect2 = temp;
        }
    }
}
