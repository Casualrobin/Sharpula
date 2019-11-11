using System;
namespace Sharpula
{
    public static class Validate
    {
        public static T Clamp<T>(T value, T min, T max) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0)
                return min;
            if (value.CompareTo(max) > 0)
                return max;

            return value;
        }

        //TODO: chuck in a non zero checker on input here.
    }
}
