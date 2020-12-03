using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsRiver.YString
{
    public static class StringParser
    {
        public static float ToFloat(ReadOnlySpan<char> input)
        {
            if (!CheckFloat(input))
            {
                throw new FormatException();
            }

            throw new NotImplementedException();
        }

        private static bool CheckFloat(ReadOnlySpan<char> input)
        {
            if (input == null || input.IsEmpty)
            {
                return false;
            }

            int size = input.Length;
            if (size == 1 && !char.IsDigit(input[0]))
            {
                return false;
            }

            //for (int i = 0; i < input)

            throw new NotImplementedException();
        }

        public static int ToInt(ReadOnlySpan<char> input)
        {
            if (!CheckInt(input))
            {
                throw new FormatException();
            }

            int tmp = 0;
            int n = 0;
            for (int i = input.Length - 1; i > 0; i--)
            {
                tmp += (input[i] - '0') * (int)Math.Pow(10, n);
                n++;
            }

            if (input[0] == '-')
            {
                tmp = -1 * tmp;
            }
            else if (input[0] != '+')
            {
                tmp += (input[0] - '0') * (int)Math.Pow(10, n);
            }

            return tmp;
        }

        private static bool CheckInt(ReadOnlySpan<char> input)
        {
            if (input == null || input.IsEmpty)
            {
                return false;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsDigit(input[i])) continue;

                if (input[i] != '-' && input[i] != '+')
                {
                    return false;
                }

                if (i != 0 || input.Length == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
