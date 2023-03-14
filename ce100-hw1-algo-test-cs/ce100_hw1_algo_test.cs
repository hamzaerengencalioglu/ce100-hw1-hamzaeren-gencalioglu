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
       


    }
}


  

