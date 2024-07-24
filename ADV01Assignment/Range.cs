using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01Assignment
{
    internal class Range<T> where T : IComparable<T>
    {
        public T minimum { get; }
        public T maximum { get; }

        public Range(T minimum, T maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(minimum) >= 0 && value.CompareTo(maximum) <= 0;
        }

        public double Length()
        {
            return Convert.ToDouble(maximum) - Convert.ToDouble(minimum);
        }
    }






}
