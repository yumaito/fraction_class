using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fraction
{
    public static class NumericOperation
    {
        /// <summary>
        /// 最大公約数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < b)
            {
                return GCD(b, a);//引数を入れ替えて自分を呼び出す
            }
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        /// <summary>
        /// 最小公倍数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int LCM(int a, int b)
        {
            return a * b / GCD(a, b);
        }
    }
}
