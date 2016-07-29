using System;
using System.Numerics;

namespace OneSystemToAnyOhter
{
    class OneSystemToAnyOther
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            string N = Console.ReadLine();
            int d = int.Parse(Console.ReadLine());

            BigInteger decNum = SystemToDecimal(N, s);
            string result = DecimalToOtherSystem(decNum, d);
            Console.WriteLine(result);
        }

        public static BigInteger SystemToDecimal(string N, int numType)
        {
            BigInteger sum = 0;

            for (int i = N.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (char.IsDigit(N[i]))
                {
                    sum = ((N[i] - '0') * IntPower(numType, j)) + sum;
                }
                else
                {
                    sum = (((N[i] - 'A') + 10) * IntPower(numType, j)) + sum;
                }
            }

            return sum;
        }


        public static string DecimalToOtherSystem(BigInteger N, int numType)
        {
            string result = string.Empty;

            while (N != 0)
            {
                BigInteger decDiv = N % numType;
                if (0 >= decDiv || decDiv < 10)
                {
                    result = decDiv + result;
                }
                else
                {
                    switch (decDiv.ToString())
                    {
                        case "10":
                            result = 'A' + result;
                            break;
                        case "11":
                            result = 'B' + result;
                            break;
                        case "12":
                            result = 'C' + result;
                            break;
                        case "13":
                            result = 'D' + result;
                            break;
                        case "14":
                            result = 'E' + result;
                            break;
                        case "15":
                            result = 'F' + result;
                            break;
                    }
                }
                N /= numType;
            }

            return result;
        }

        public static long IntPower(int a, int b)
        {
            long result = 1;
            for (long i = 0; i < b; i++)
                result *= a;
            return result;
        }
    }
}
