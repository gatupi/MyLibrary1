using System;
using MyLibrary1.Exceptions;

namespace MyLibrary1 {
    public static class MyArray {
        public static int[] GetRow(this int[,] matrix, int rowIndex) {

            int[] row = null;

            if (matrix != null) {
                int columns = matrix.GetLength(1);
                row = new int[columns];
                for (int i = 0; i < columns; i++)
                    row[i] = matrix[rowIndex, i];
            }

            return row;
        }

        public static int[] GetColumn(this int[,] matrix, int colIndex) {

            int[] column = null;

            if (matrix != null) {
                int rows = matrix.GetLength(0);
                column = new int[rows];
                for (int i = 0; i < rows; i++)
                    column[i] = matrix[i, colIndex];
            }

            return column;
        }

        public static int[] GetSquare(this int[,] matrix, int sqrIndex) {

            int[] square = null;

            if (matrix != null) {

                int length = matrix.GetLength(0);

                if (matrix.GetLength(1) != length)
                    throw new MyArrayException("It's not a square matrix!");

                if (!MyMath.IsPerfectSquare(length))
                    throw new MyArrayException("It's not a perfect square matrix!");

                if (sqrIndex >= length)
                    throw new IndexOutOfRangeException("Index out of bounds!");

                int sqrt = (int)Math.Sqrt(length);
                int row = sqrIndex / sqrt * sqrt;
                int col = sqrIndex % sqrt * sqrt;
                square = new int[sqrt * sqrt];

                for (int i = 0; i < sqrt; i++)
                    for (int j = 0; j < sqrt; j++)
                        square[i * sqrt + j] = matrix[row + i, col + j];
            }

            return square;
        }

        public static int[] BuildOrdered(int length, bool desc = false) {

            return
                BuildOrdered(length, 0, desc);
        }

        public static int[] BuildOrdered(int length, int start, bool desc = false) {

            int[] array = new int[length];

            int value = start;
            int increment = 1;

            if (desc) {
                value = start + length - 1;
                increment = -1;
            }
            for (int i = 0; i < length; i++) {
                array[i] = value + increment * i;
            }

            return array;
        }

        public static int[] FirstNEvens(int count) {

            int[] array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = MyMath.NthEven(i + 1);

            return array;
        }

        public static int[] FirstNOdds(int count) {

            int[] array = new int[count];

            for (int i = 0; i < count; i++)
                array[i] = MyMath.NthOdd(i + 1);

            return array;
        }

        public static int SumOfArray(this int[] array) {

            int sum = 0;

            foreach (int number in array)
                sum += number;

            return sum;
        }
    }
}
