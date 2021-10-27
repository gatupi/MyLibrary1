using System;

namespace MyLibrary1 {
    public static class MyMath {
        public static bool IsPerfectSquare(long n) {

            if (n < 0)
                return false;

            switch (n & 0xF) {
                case 0:
                case 1:
                case 4:
                case 9:
                    long tst = (long)Math.Sqrt(n);
                    return tst * tst == n;

                default:
                    return false;
            }
        }

        public static bool IsEven(int n) {

            return n % 2 == 0;
        }

        public static bool IsOdd(int n) {

            return !IsEven(n);
        }

        public static int NthEven(int n) {

            if (n <= 0) n = 1;

            return 2 * (n - 1);
        }

        public static int NthOdd(int n) {

            return NthEven(n) + 1;
        }

        public static long FirstNSum(int n) {

            return n * (n + 1) / 2;
        }
    }
}
