using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fraction
{
    /// <summary>
    /// 代数的処理をする静的クラス
    /// </summary>
    public static class NumericOperation
    {
        /// <summary>
        /// 最大公約数を求める関数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static public int GCD(int a, int b)
        {
            //それぞれの絶対値を取得
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a < b)
            {
                return GCD(b, a);//引数を入れ替えて自分を呼び出す
            }
            while (b != 0)
            {
                //bがゼロでない限り
                int r = a % b;//aをbで割った余り
                a = b;
                b = r;
            }
            return a;
        }
        /// <summary>
        /// 最小公倍数を求めう関数
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
