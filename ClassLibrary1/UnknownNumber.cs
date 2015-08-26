using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuncAlg
{
    public class UnknownNumber
    {
        /// <summary>
        /// raise when two variables name don't match.
        /// </summary>
        public class VarMatchException : ArgumentException { }

        /// <summary>
        /// <系数>
        /// </summary>
        public decimal coefficient;

        /// <summary>
        /// <指数>index or power
        /// </summary>
        public decimal exponent;

        /// <summary>
        /// <变量名>
        /// </summary>
        public string name;

        public UnknownNumber(string name)
        {
            this.name = name;
            exponent = 1;
            coefficient = 1;
        }

        public UnknownNumber(decimal coeffi, string name)
        {
            this.name = name;
            exponent = 1;
            coefficient = coeffi;
        }

        public UnknownNumber(decimal coeffi, string name, decimal expon)
        {
            this.name = name;
            exponent = expon;
            coefficient = coeffi;
        }

        protected UnknownNumber Clone()
        {
            var result = new UnknownNumber(this.name);
            result.coefficient = this.coefficient;
            result.exponent = this.exponent;
            return result;
        }

        public static UnknownNumber operator *(UnknownNumber one, UnknownNumber other)
        {
            //ax*by
            if (one.name != other.name)
            {
                throw new VarMatchException("different variable can't do multi.", string.Format("var name1:{0}, var name2:{1}", one.name, other.name));
            }
            UnknownNumber result = new UnknownNumber(one.name);
            //ax^2*bx^3
            result.coefficient = one.coefficient * other.coefficient;
            result.exponent = one.exponent + other.exponent;

            return result;
        }

        public static UnknownNumber operator *(UnknownNumber one, decimal coeffi)
        {
            UnknownNumber result = one.Clone();
            //ax^2*3
            result.coefficient = one.coefficient * coeffi;

            return result;
        }

        public static UnknownNumber operator +(UnknownNumber one, UnknownNumber other)
        {
            //ax*by
            if (one.name != other.name)
            {
                throw new VarMatchException("different variable can't do add.", string.Format("var name1:{0}, var name2:{1}", one.name, other.name));
            }
            UnknownNumber result = new UnknownNumber(one.name);
            //ax^2*bx^3
            result.coefficient = one.coefficient * other.coefficient;
            result.exponent = one.exponent + other.exponent;

            return result;
        }
    }
}
