using System;
using MyLibrary1;

namespace TestMyLibrary1 {
    class Program {
        static void Main(string[] args) {
            Test5();
        }

        // Test Method OrderedArrayBuilder
        static void Test1() {
            MyConsole.PrintArray(MyArray.BuildOrdered(7));
            MyConsole.PrintArray(MyArray.BuildOrdered(7, true));
            MyConsole.PrintArray(MyArray.OrderedArrayBuilder(5, 7));
            MyConsole.PrintArray(MyArray.OrderedArrayBuilder(5, 7, true));
            // Random Array to be printed
            MyConsole.PrintArray(MyArray.OrderedArrayBuilder(new Random().Next(3, 10), new Random().Next(0, 100), new bool[] { true, false }[new Random().Next(0, 2)]));
        }

        // Methods NthEven, NthOdd, FirstNthEvens and FirstNthOdds
        static void Test2() {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(MyMath.NthEven(i + 1));
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(MyMath.NthOdd(i + 1));
            }
            MyConsole.PrintArray(MyArray.FirstNEvens(15));
            MyConsole.PrintArray(MyArray.FirstNOdds(12));
        }

        // Methods IsEven and IsOdds
        static void Test3() {

            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{i}: Is it Even? {MyMath.IsEven(i)}");

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
                Console.WriteLine($"{i}: Is it Odd? {MyMath.IsOdd(i)}");
        }
        // SumOfarray

        static void Test4() {
            int[] array = MyArray.OrderedArrayBuilder(10, 22, true);

            MyConsole.PrintArray(array);
            Console.WriteLine(array.SumOfArray());
        }

        static void Test5() {

            for (int i = 0; i < 20; i++)
                Console.WriteLine($"Sum({i + 1}): {MyMath.FirstNSum(i + 1)}");
        }
    }
}
