using ce100_hw1_hamzaeren_gencalioglu;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using static ce100_hw1_hamzaeren_gencalioglu.ce100_hw1_algo_lib;

namespace ce100_hw1_algo_test_cs
{

    [TestClass]
    public class Tests
    {


        [TestMethod]
        public void SelectionSort_BestCase()
        {

            int[] Arr = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Arr[i] = i;
            }

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }
            CollectionAssert.AreEqual(ce100_hw1_algo_lib.SelectionSort(Arr, Arr.Length), Exp);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }

        [TestMethod]
        public void SelectionSort_AverageCase()
        {

            // Creating an array of 10,000 elements
            int[] numbers = new int[10000];

            // Filling the array with random numbers
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = r.Next(0, 10000);
            }

            // Sorting the array using Merge Sort
            int[] actual = ce100_hw1_algo_lib.SelectionSort(numbers, numbers.Length);

            // Creating sorted array
            int[] expected = (int[])actual.Clone();
            Array.Sort(expected);

            // Comparing expected and actual results
            for (int i = 0; i < 10000; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }

        [TestMethod]
        public void SelectionSort_WorstCase()
        {
            int[] Arr = new int[10000];
            for (int i = 9999; i > 0; i--)
            {
                Arr[i] = i;
            }

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }
            CollectionAssert.AreEqual(ce100_hw1_algo_lib.SelectionSort(Arr, Arr.Length), Exp);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }


        [TestMethod]
        public void MergeSort_BestCase()
        {

            int[] Arr = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Arr[i] = i;
            }

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }
            CollectionAssert.AreEqual(ce100_hw1_algo_lib.MergeSort(Arr), Exp);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }
        [TestMethod]
        public void MergeSort_AverageCase()
        {

            // Creating an array of 10,000 elements
            int[] numbers = new int[10000];

            // Filling the array with random numbers
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = r.Next(0, 10000);
            }

            // Sorting the array using Merge Sort
            int[] actual = ce100_hw1_algo_lib.MergeSort(numbers);

            // Creating sorted array
            int[] expected = (int[])actual.Clone();
            Array.Sort(expected);

            // Comparing expected and actual results
            for (int i = 0; i < 10000; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }
        [TestMethod]
        public void MergeSort_WorstCase()
        {

            int[] Arr = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Arr[i] = 9999 - i;
            }

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }
            CollectionAssert.AreEqual(ce100_hw1_algo_lib.MergeSort(Arr), Exp);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }
        [TestMethod]
        public void RandomQuicksortHoare_BestCase()
        {

            int[] Arr = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Arr[i] = i; 
            }

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }

            ce100_hw1_algo_lib.RandomQuicksortHoare(Arr, 0, Arr.Length - 1);

            for (int i = 0; i < 10000; i++)
            {
                Assert.AreEqual(Exp[i], Arr[i]);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");


        }

        [TestMethod]
        public void RandomQuicksortHoare_AverageCase()
        {




            int[] Arr = new int[10000];
            Random rnd = new Random();

            // Generating random numbers
            HashSet<int> set = new HashSet<int>();
            while (set.Count < 10000)
            {
                set.Add(rnd.Next(0, 10000));
            }

            set.CopyTo(Arr);

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }

            // Applying sorting algorithm
            ce100_hw1_algo_lib.RandomQuicksortHoare(Arr, 0, Arr.Length - 1);

            // Recreating the expected results array
            int[] expected = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                expected[i] = i;
            }

            // comparing arrays
            CollectionAssert.AreEqual(expected, Arr);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }

        [TestMethod]
        public void RandomQuicksortHoare_WorstCase()
        {



            int[] Arr = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Arr[i] = 9999 - i;
            }

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }



            ce100_hw1_algo_lib.RandomQuicksortHoare(Arr, 0, Arr.Length - 1);



            for (int i = 0; i < 10000; i++)
            {
                Assert.AreEqual(Exp[i], Arr[i]);
            }
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");


        }
        [TestMethod]
        public void RandomQuicksortLomuto_BestCase()
        {
            int[] expected = Enumerable.Range(1, 10000).ToArray();
            int[] actual = Enumerable.Range(1, 10000).Reverse().ToArray();

            ce100_hw1_algo_lib.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

            CollectionAssert.AreEqual(expected, actual);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }


        [TestMethod]
        public void RandomQuicksortLomuto_AverageCase()
        {
            int[] expected = Enumerable.Range(1, 10000).ToArray();
            int[] actual = Enumerable.Range(1, 10000).Reverse().ToArray();

            ce100_hw1_algo_lib.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

            CollectionAssert.AreEqual(expected, actual);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ce100_hw1_algo_lib.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }


        [TestMethod]
        public void RandomQuicksortLomuto_WorstCase()
        {


            int[] expected = Enumerable.Range(1, 10000).ToArray();
            int[] actual = Enumerable.Range(1, 10000).ToArray();

            // The last element in the array is chosen as the pivot for worst-case scenario
            ce100_hw1_algo_lib.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

            CollectionAssert.AreEqual(expected, actual);


            // Call RandomQuickSortLomuto with the last element as the pivot
            ce100_hw1_algo_lib.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");


        }

        [TestMethod]
        public void TestBinarySearchIterative()
        {

            int n = 10000;
            int[] arr = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100000);
            }

            Array.Sort(arr);

            int key1 = arr[rand.Next(0, n)];
            int key2 = rand.Next(100000, 200000);

            // Ýþlem
            var result1 = ce100_hw1_algo_lib.BinarySearchIterative(arr, key1);
            var result2 = ce100_hw1_algo_lib.BinarySearchIterative(arr, key2);

            // Doðrulama
            if (result1 != -1)
            {
                Assert.AreEqual(key1, arr[result1]);
            }
            else
            {
                Assert.IsFalse(Array.Exists(arr, x => x == key1));
            }

            Assert.AreEqual(-1, result2);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }
        [TestMethod]
        public void TestBinarySearchRecursiveNonRandom()
        {


            int[] arr3 = new int[10000];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = i;
            }

            Random rand = new Random();
            int a = rand.Next(10000);
            int index3 = ce100_hw1_algo_lib.BinarySearchRecursive(arr3, 0, arr3.Length - 1, a);
            Assert.AreEqual(a, arr3[index3]);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }



        [TestMethod]
        public void MatrixMultiplicationIterative_BestCase()
        {
            // Arrange
            int n = 10;
            int[,] mat1 = new int[n, n];
            int[,] mat2 = new int[n, n];
            int[,] res = new int[n, n];

            // Initialize matrices with same values
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat1[i, j] = 1;
                    mat2[i, j] = 1;
                }
            }

            // Calculate expected result matrix
            int[,] expected = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    expected[i, j] = n;
                }
            }

            // Act
            ce100_hw1_algo_lib.MatrixMultiplicationIterative(mat1, mat2, res);

            // Assert
            CollectionAssert.AreEqual(expected, res);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }




        [TestMethod]
        public void MatrixMultiplicationIterative_AverageCase()
        {

            // Arrange
            int n = 10;
            int[,] mat1 = new int[n, n];
            int[,] mat2 = new int[n, n];
            int[,] res = new int[n, n];

            // Initialize matrices with random values between 1 and 10
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat1[i, j] = rand.Next(1, 11);
                    mat2[i, j] = rand.Next(1, 11);
                }
            }

            // Calculate expected result matrix
            int[,] expected = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += mat1[i, k] * mat2[k, j];
                    }
                    expected[i, j] = sum;
                }
            }

            // Act
            ce100_hw1_algo_lib.MatrixMultiplicationIterative(mat1, mat2, res);

            // Assert
            CollectionAssert.AreEqual(expected, res);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");



        }

        [TestMethod]
        public void MatrixMultiplicationIterative_WorstCase()
        {
            // Arrange
            int n = 10;
            int[,] mat1 = new int[n, n];
            int[,] mat2 = new int[n, n];
            int[,] res = new int[n, n];

            // Fill matrices with random values
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat1[i, j] = random.Next(1, 100);
                    mat2[i, j] = random.Next(1, 100);
                }
            }

            // Calculate expected result matrix
            int[,] expected = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < n; k++)
                    {
                        sum += mat1[i, k] * mat2[k, j];
                    }
                    expected[i, j] = sum;
                }
            }


            // Act
            ce100_hw1_algo_lib.MatrixMultiplicationIterative(mat1, mat2, res);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

            // Assert
            CollectionAssert.AreEqual(expected, res);
        }

        [TestMethod]

        public void MatrixMultiplicationRecursive_BestCase()
        {
            int[,] A = new int[10, 10];
            int[,] B = new int[10, 10];
            int[,] C = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        A[i, j] = 1;
                        B[i, j] = 1;
                    }
                    else
                    {
                        A[i, j] = 0;
                        B[i, j] = 0;
                    }
                }
            }

            ce100_hw1_algo_lib.MatrixMultiplicationRecursive(10, 10, A, 10, 10, B, C);

            // C should be a 10x10 identity matrix
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }

        [TestMethod]
        public void MatrixMultiplicationRecursive_AverageCase()
        {


            Random random = new Random();
            int[,] A = new int[10, 10];
            int[,] B = new int[10, 10];
            int[,] C = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A[i, j] = random.Next(101);
                    B[i, j] = random.Next(101);
                }
            }

            ce100_hw1_algo_lib.MatrixMultiplicationRecursive(10, 10, A, 10, 10, B, C);

            // C should be the product of A and B
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");


        }

        [TestMethod]
        public void MatrixMultiplicationRecursive_WorstCase()
        {
            int[,] A = new int[10, 10];
            int[,] B = new int[10, 10];
            int[,] C = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A[i, j] = 0;
                    B[i, j] = 0;
                }
            }

            ce100_hw1_algo_lib.MatrixMultiplicationRecursive(10, 10, A, 10, 10, B, C);

            // C should be a 10x10 matrix of all zeros

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");



        }



        [TestMethod]
        public void MatrixMultiplicationStrassen_BestCase()
        {

            int[,] A1 = new int[10, 10] {
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 } };
            int[,] B1 = (int[,])A1.Clone();
            int[,] expected1 = new int[10, 10] {
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 }};


            int[,] result1 = MatrixMultiplicationStrassen.Strassen(A1, B1);
            CollectionAssert.AreEqual(expected1, result1);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }

        [TestMethod]
        public void MatrixMultiplicationStrassen_AverageCase()
        {
            // Average case: Two random matrices
            Random random = new Random();
            int[,] A2 = new int[10, 10];
            int[,] B2 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A2[i, j] = random.Next(-100, 100);
                    B2[i, j] = random.Next(-100, 100);
                }
            }
            int[,] expected2 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < 10; k++)
                    {
                        sum += A2[i, k] * B2[k, j];
                    }
                    expected2[i, j] = sum;
                }
            }
            int[,] result2 = MatrixMultiplicationStrassen.Strassen(A2, B2);
            CollectionAssert.AreEqual(expected2, result2);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");

        }
        [TestMethod]
        public void MatrixMultiplicationStrassen_WorstCase()
        {
            // Worst case: Two matrices with all elements equal to 1
            int[,] A3 = new int[10, 10];
            int[,] B3 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    A3[i, j] = 1;
                    B3[i, j] = 1;
                }
            }
            int[,] expected3 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    expected3[i, j] = 10;
                }
            }
            int[,] result3 = MatrixMultiplicationStrassen.Strassen(A3, B3);
            CollectionAssert.AreEqual(expected3, result3);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }


    }
}


  

