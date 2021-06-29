using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                array = new int[] { 0, 1, 2, 4, 6, 8, 10, 14, 18, 19 },
                SearchValue = 4,
                Expected = 3
            };

            var testCase2 = new TestCase()
            {
                array = new int[] { 0, 10, 20, 43, 62, 86, 101, 144, 182, 199 },
                SearchValue = 62,
                Expected = 4
            };

            var testCase3 = new TestCase()
            {
                array = new int[] { 0, 15, 2, 4, 6, 86, 10, 14, 18, 19 },
                SearchValue = 86,
                Expected = 5
            };

            var testCase4 = new TestCase()
            {
                array = new int[] { 0, 15, 222, 456, 621, 86, 1000, 1454, 1822, 1977 },
                SearchValue = 456,
                Expected = 3
            };

            var testCase5 = new TestCase()
            {
                array = new int[] { 20, 19, 18, 16, 13, 10, 8, 5, 3, 1},
                SearchValue = 18,
                Expected = 2
            }; 

            TestBinarySearch(testCase1);
            TestBinarySearch(testCase2);
            TestBinarySearch(testCase3);
            TestBinarySearch(testCase4);
            TestBinarySearch(testCase5);

            Console.WriteLine("Ассимптотическая сложность алгоритма - О(N/2)");
        }

        static void TestBinarySearch(TestCase testCase)
        {
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < testCase.array.Length; i++)
            {
                Console.Write("{0} ", testCase.array[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("Искомое значение: {0}", testCase.SearchValue);
            var actual = BinarySearch(testCase.array, testCase.SearchValue);

            if (actual == testCase.Expected)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }            
        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
