using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Rational_Number
    {
        private double result; // добавил приватное поле с результатом деления для удобной проверки на равенства и больше-меньше

        public int Numerator { get; set; }

        public int Denumerator { get; set; }

        

        public Rational_Number(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;

            result = (double)numerator / denumerator;
        }

        public static bool operator ==(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            if ((rNumber1.result == rNumber2.result) && (rNumber1.result == rNumber2.result))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            if ((rNumber1.result != rNumber2.result) || (rNumber1.result != rNumber2.result))
            {
                return true;
            }
            return false;
        }


        // Долго думал, почему компилятор ругается на переопределенный метод. Нарыл в интернете два варианта решения
        //      1. Реализовать IEquatable
        //      2. Добавить доп.проверку через if на принадлежность нужному классу.
        // Из двух вариантов решил выбрать второй
        public override bool Equals(object rNumber)
        {
            if (rNumber is Rational_Number)
            {
                if (this == (Rational_Number)rNumber) // приведение типов - чтобы компилятор не выпендривался
                {
                    return true;
                }
                if (this != (Rational_Number)rNumber)
                {
                    return false;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denumerator);
        }

        public static bool operator >(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            if (rNumber1.result > rNumber2.result)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            if (rNumber1.result < rNumber2.result)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            if (rNumber1.result >= rNumber2.result)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            if (rNumber1.result <= rNumber2.result)
            {
                return true;
            }
            return false;
        }

        public static Rational_Number operator +(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            int numerator;
            int denumerator;
            Rational_Number newNumber;
            // Решил не заморачиваться с нахождением наименьшего общего кратного для знаменателя - просто перемножил их
            if (rNumber1.Denumerator != rNumber2.Denumerator)
            {
                numerator = (rNumber1.Numerator * rNumber2.Denumerator) + (rNumber2.Numerator * rNumber1.Denumerator);
                denumerator = rNumber1.Denumerator * rNumber2.Denumerator;

                newNumber = new(numerator, denumerator);

                return newNumber;
            }

            newNumber = new(rNumber1.Numerator + rNumber2.Numerator, rNumber1.Numerator);

            return newNumber;
        }

        public static Rational_Number operator -(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            int numerator;
            int denumerator;
            Rational_Number newNumber;

            if (rNumber1.Denumerator != rNumber2.Denumerator)
            {
                numerator = (rNumber1.Numerator * rNumber2.Denumerator) - (rNumber2.Numerator * rNumber1.Denumerator);
                denumerator = rNumber1.Denumerator * rNumber2.Denumerator;

                newNumber = new(numerator, denumerator);

                return newNumber;
            }

            newNumber = new(rNumber1.Numerator - rNumber2.Numerator, rNumber1.Numerator);

            return newNumber;
        }

        public static Rational_Number operator *(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            int numerator = rNumber1.Numerator * rNumber2.Numerator;
            int denumerator = rNumber1.Denumerator * rNumber2.Denumerator;
            Rational_Number newNumber = new(numerator, denumerator);

            return newNumber;
        }

        public static Rational_Number operator /(Rational_Number rNumber1, Rational_Number rNumber2)
        {
            int numerator = rNumber1.Numerator * rNumber2.Denumerator;
            int denumerator = rNumber1.Denumerator * rNumber2.Numerator;
            Rational_Number newNumber = new(numerator, denumerator);

            return newNumber;
        }


        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denumerator}";
        }

        public static implicit operator float(Rational_Number rNumber)
        {
            return (float)rNumber.Numerator / rNumber.Denumerator;
        }

        public static implicit operator int(Rational_Number rNumber)
        {
            return (rNumber.Numerator / rNumber.Denumerator);
        }

        public static Rational_Number operator ++(Rational_Number rNumber)
        {
            Rational_Number newNumber = new(rNumber.Numerator + 1, rNumber.Denumerator);
            return newNumber;
        }

        public static Rational_Number operator --(Rational_Number rNumber)
        {
            Rational_Number newNumber = new(rNumber.Numerator - 1, rNumber.Denumerator);
            return newNumber;
        }

    }
}
