using ce100_hw1_hamzaeren_gencalioglu;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TestProject1
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
            CollectionAssert.AreEqual(Class1.SelectionSort(Arr, Arr.Length), Exp);


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

            // 10.000 elemanlık bir dizi oluşturuluyor
            int[] numbers = new int[10000];

            // Rastgele sayılarla dizi dolduruluyor
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = r.Next(0, 10000);
            }

            // Merge Sort kullanılarak dizi sıralanıyor
            int[] actual = Class1.SelectionSort(numbers, numbers.Length);

            // Sıralanmış dizi oluşturuluyor
            int[] expected = (int[])actual.Clone();
            Array.Sort(expected);

            // Beklenen ve gerçek sonuçlar karşılaştırılıyor
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
            CollectionAssert.AreEqual(Class1.SelectionSort(Arr, Arr.Length), Exp);


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
            CollectionAssert.AreEqual(Class1.MergeSort(Arr), Exp);

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

            // 10.000 elemanlık bir dizi oluşturuluyor
            int[] numbers = new int[10000];

            // Rastgele sayılarla dizi dolduruluyor
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = r.Next(0, 10000);
            }

            // Merge Sort kullanılarak dizi sıralanıyor
            int[] actual = Class1.MergeSort(numbers);

            // Sıralanmış dizi oluşturuluyor
            int[] expected = (int[])actual.Clone();
            Array.Sort(expected);

            // Beklenen ve gerçek sonuçlar karşılaştırılıyor
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
            CollectionAssert.AreEqual(Class1.MergeSort(Arr), Exp);

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
                Arr[i] = i; // elemanlar sıralı olarak
            }

            int[] Exp = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                Exp[i] = i;
            }

            Class1.RandomQuicksortHoare(Arr, 0, Arr.Length - 1);

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

            // Benzersiz rasgele sayılar oluşturuluyor
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

            // Sıralama algoritması uygulanıyor
            Class1.RandomQuicksortHoare(Arr, 0, Arr.Length - 1);

            // Beklenen sonuçlar dizisi yeniden oluşturuluyor
            int[] expected = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                expected[i] = i;
            }

            // Assert.AreEqual metodu kullanılarak diziler karşılaştırılıyor
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



            Class1.RandomQuicksortHoare(Arr, 0, Arr.Length - 1);



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

            Class1.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

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

            Class1.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

            CollectionAssert.AreEqual(expected, actual);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Class1.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

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
            Class1.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

            CollectionAssert.AreEqual(expected, actual);


            // Call RandomQuickSortLomuto with the last element as the pivot
            Class1.RandomQuickSortLomuto(actual, 0, actual.Length - 1);

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

            // İşlem
            var result1 = Class1.BinarySearchIterative(arr, key1);
            var result2 = Class1.BinarySearchIterative(arr, key2);

            // Doğrulama
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
            int index3 = Class1.BinarySearchRecursive(arr3, 0, arr3.Length - 1, a);
            Assert.AreEqual(a, arr3[index3]);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");
        }



        [TestMethod]
        public void MultiplyMatrixIterative_BestCase()
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
            Class1.MatrixMultiplicationIterative(mat1, mat2, res);

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
        public void MultiplyMatrixIterative_AverageCase()
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
                Class1.MatrixMultiplicationIterative(mat1, mat2, res);

                // Assert
                CollectionAssert.AreEqual(expected, res);


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();
            Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");

            long memoryUsed = GC.GetTotalMemory(true);
            Console.WriteLine($"Memory used: {memoryUsed}");




        }
    }
}