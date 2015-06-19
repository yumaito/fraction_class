using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fraction
{
    /// <summary>
    /// 分数を管理するクラス
    /// </summary>
    public class Fraction : IComparable
    {
        #region メンバ変数
        private int numerator;//分子
        private int denominator;//分母
        #endregion

        #region プロパティ
        /// <summary>
        /// 分子
        /// </summary>
        public int Numerator
        {
            get
            {
                return numerator;
            }
            //set
            //{
            //    numerator = value;
            //}
        }
        /// <summary>
        /// 分母
        /// </summary>
        public int Denominator
        {
            get
            {
                return denominator;
            }
            //set
            //{
            //    denominator = value;
            //}
        }
        /// <summary>
        /// 小数値
        /// </summary>
        public double DecimalValue
        {
            get
            {
                double result = (double)numerator / (double)denominator;
                return result;
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// 分数を管理するクラス
        /// </summary>
        public Fraction()
        {
            this.numerator = 0;
            this.denominator = 1;
            this.CreateIrreducibleFration();
            this.minus();
        }
        /// <summary>
        /// 分数を管理するクラス
        /// </summary>
        /// <param name="numerator">分子</param>
        /// <param name="denominator">分母</param>
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.CreateIrreducibleFration();
            this.minus();
        }
        /// <summary>
        /// 小数を含む数値を分数に変換するクラス
        /// </summary>
        /// <param name="x"></param>
        public Fraction(double x)
        {
            //入力された数値の小数点以下の桁数を求める
            string strTemp = x.ToString();
            strTemp = strTemp.Substring(strTemp.IndexOf(".") + 1);
            int number = strTemp.Length;
            //
            this.denominator = (int)Math.Pow(10, number);
            this.numerator = (int)(x * Math.Pow(10, number));
            this.CreateIrreducibleFration();
            this.minus();
        }
        /// <summary>
        /// 整数を分数の形にするクラス
        /// </summary>
        /// <param name="x"></param>
        public Fraction(int x)
        {
            this.numerator = x;
            this.denominator = 1;
            this.CreateIrreducibleFration();
            this.minus();
        }
        #endregion

        #region メソッド
        /// <summary>
        /// 文字列に変換
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}/{1}", numerator, denominator);
            //return base.ToString();
        }
        
        /// <summary>
        /// 既約分数に直すメソッド
        /// </summary>
        private void CreateIrreducibleFration()
        {
            int d = NumericOperation.GCD(numerator, denominator);
            numerator = numerator / d;
            denominator = denominator / d;
        }
        /// <summary>
        /// マイナスの位置を調整するメソッド
        /// </summary>
        private void minus()
        {
            if ((denominator < 0 && numerator < 0) || (denominator < 0))
            {
                numerator *= -1;
                denominator *= -1;
            }
        }
        #endregion

        #region 静的メソッド（演算子関係）
        /// <summary>
        /// 分数の絶対値を返す
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static Fraction ABS(Fraction x)
        {
            return new Fraction(Math.Abs(x.Numerator), Math.Abs(x.Denominator));
        }
        #region 四則演算
        /// <summary>
        /// 加算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction x, Fraction y)
        {
            //両分母の最小公倍数をとる
            int lc = NumericOperation.LCM(x.denominator, y.denominator);
            //分母が異なるなら最小公倍数/分母を分子にかける
            if (x.denominator != y.denominator)
            {
                x.numerator *= (lc / x.denominator);
                y.numerator *= (lc / y.denominator);
            }
            Fraction result = new Fraction(x.numerator + y.numerator, lc);
            return result;
        }
        /// <summary>
        /// 加算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator +(Fraction x, int y)
        {
            return x + new Fraction(y);
        }
        /// <summary>
        /// 減算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator -(Fraction x, Fraction y)
        {
            //両分母の最小公倍数をとる
            int lc = NumericOperation.LCM(x.denominator, y.denominator);
            //分母が異なるなら最小公倍数/分母を分子にかける
            if (x.denominator != y.denominator)
            {
                x.numerator *= (lc / x.denominator);
                y.numerator *= (lc / y.denominator);
            }
            Fraction result = new Fraction(x.numerator - y.numerator, lc);
            return result;
        }
        /// <summary>
        /// 減算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator -(Fraction x,int y)
        {
            return x - new Fraction(y);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator *(Fraction x, Fraction y)
        {
            return new Fraction(x.numerator * y.numerator, x.denominator * y.denominator);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator *(Fraction x, int y)
        {
            return new Fraction(x.numerator * y, x.denominator);
        }
        /// <summary>
        /// 除算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator /(Fraction x, Fraction y)
        {
            return new Fraction(x.numerator * y.denominator, x.denominator * y.numerator);
        }
        /// <summary>
        /// 除算
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static Fraction operator /(Fraction x, int y)
        {
            return new Fraction(x.numerator, x.denominator * y);
        }
        #endregion

        #region 比較演算
        /// <summary>
        /// objと自分自身が等価のときはtrueを返す
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            //objがnullか、型が違うときは、等価でない
            if ((object)obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Fraction c = (Fraction)obj;
            return (this.numerator == c.numerator) && (this.denominator == c.denominator);
            //return base.Equals(obj);
        }
        /// <summary>
        /// Equalがtrueを返すときに同じ値を返す
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            //XOR
            return this.numerator ^ this.denominator.GetHashCode();
            //return base.GetHashCode();
        }
        /// <summary>
        /// 自分自身がotherより小さいときはマイナスの数、大きいときはプラスの数、
        /// 同じときは0を返す
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            //nullより大きい
            if (obj == null)
            {
                return 1;
            }
            //違う型とは比較できない
            if (this.GetType() != obj.GetType())
            {
                throw new ArgumentException("別の型とは比較できません。", "obj");
            }
            //単純な減算の結果を返す
            return this.DecimalValue.CompareTo(((Fraction)obj).DecimalValue);
        }

        /// <summary>
        /// 比較演算子(==)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator ==(Fraction x, Fraction y)
        {
            //nullの確認
            if ((object)x == null)
            {
                return ((object)y == null);
            }
            if ((object)y == null)
            {
                return false;
            }
            //Equalメソッドを呼び出す
            return x.Equals(y);
        }
        /// <summary>
        /// 比較演算子(!=)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator !=(Fraction x, Fraction y)
        {
            return !(x == y);
        }
        /// <summary>
        /// 比較（<）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator <(Fraction x, Fraction y)
        {
            //nullの確認
            if ((object)x == null || (object)y == null)
            {
                throw new ArgumentException();
            }
            //CompareToメソッド
            //Fraction temp = x - y;

            return ((x - y).numerator < 0);
        }
        /// <summary>
        /// 比較（>）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator >(Fraction x, Fraction y)
        {
            return (y < x);
        }
        /// <summary>
        /// 比較（<=）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator <=(Fraction x, Fraction y)
        {
            //nullの確認
            if ((object)x == null || (object)y == null)
            {
                throw new ArgumentException();
            }
            //CompareToメソッド
            return ((x - y).numerator <= 0);
        }
        /// <summary>
        /// 比較（>=）
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool operator >=(Fraction x, Fraction y)
        {
            return (y <= x);
        }
        #endregion
        #endregion
    }
}
