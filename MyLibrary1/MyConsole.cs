using System;

namespace MyLibrary1 {
    public static class MyConsole {

        public static void PrintArray(int[] array) {

            Console.Write("{");

            if (array != null) {
                int lastIndex = array.Length - 1;
                for (int i = 0; i < lastIndex; i++)
                    Console.Write($"{array.GetValue(i)}, ");
                Console.Write(array.GetValue(lastIndex));
            }

            Console.WriteLine("}");
        }
    }
}
