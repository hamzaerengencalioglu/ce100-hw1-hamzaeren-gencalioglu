using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ce100_hw1_hamzaeren_gencalioglu
{

    /**
 * @file ce100-hw1-algo-lib-cs
 * @authors Hamza Eren Gencalioglu / Bayram Kamus
 * @date 14/03/2023
 *
 * @brief <b> HW-2 Functions </b>
 *
 * HW-2 Sample Lib Functions
 *
 */


    public class ce100_hw1_algo_lib
    {

        //Selection Sort
        /**
    *
    *	  @name   SelectionSort (ce100_SelectionSort)
    *
    *	  @brief Selection Sort Function
    *
    *	  The Selection Sort function is a function that sorts the mixed numbers in the system from smallest to largest.
    *
    *	  @param  [in] numArray [\b int]  arrayLenght of Selection Sort Function 
    *
    *	  @retval [\b int] function Selection Sort
    **/

        public static int[] SelectionSort(int[] A, int n)
        {
            int temp;
            int min;

            // scans the elements in the array
            for (int i = 0; i < n - 1; i++)
            {
                min = i;

                // Scans the remaining elements of the array
                for (int j = i; j < n; j++)
                {

                    // When the element indicated by J1 is less than the minimum value, it assigns the new minimum value as j.
                    if (A[j] < A[min])
                    {
                        min = j;
                    }
                }

                // At the end of the loop, the minimum value index is replaced by the i-th element.
                temp = A[i];
                A[i] = A[min];
                A[min] = temp;
            }

            return A;
        }

        // MergeSort
        /**
*
*	  @name   Merge Sort (ce100_Merge_Sort)
*
*	  @brief Merge Sort Function
*
*	  It is a function that is used to sort the array of mixed numbers from smallest to largest..
*	  
*
*	  @param  [in] array.Lenght [\b int]  midpoint of Merge Sort Function 
*
*	  @retval [\b int] function Merge Sort */


        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];

            // If the array has only one element or is empty, it returns to itself because it is ordered.
            if (array.Length <= 1)
            {
                return array;

            }
            // Sets the midpoint of the array.
            int MidPoint = array.Length / 2;

            // Create an array for the left side of the array and copy the elements to it.
            left = new int[MidPoint];

            // Create an array for the right side of the array and copy the elements to it.
            if (array.Length % 2 == 0)
            {
                right = new int[MidPoint];

            }
            else
            {

                right = new int[MidPoint + 1];
            }

            for (int i = 0; i < MidPoint; i++)
            {
                left[i] = array[i];
            }

            int x = 0;

            for (int i = MidPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }

            // Merge Sort algorithm is called for left and right arrays.

            left = MergeSort(left);


            right = MergeSort(right);

            result = Merge(left, right);
            return result;
        }

      
        public static int[] Merge(int[] left, int[] right)
        {
            // Determines the length of the result array.
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            // Enters a loop to scan all elements of the array on the left or right.
            while (indexLeft < left.Length || indexRight < right.Length)
            {

                // The indexes of the left and right arrays are compared before reaching their final values.
                if (indexLeft < left.Length && indexRight < right.Length)
                {

                    /* If the current element of the left array is less than or equal to the current element of the right array,
                      adds the current element of the left array to the result array and increments the index of the left array by one.*/
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }

                    /* If the current element of the array on the right is less than the current element of the array on the left,
                    add the current element of the right array to the result array and increment the index of the right array by one.*/
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }

                /* If only the elements of the left array are left, after adding the current element of the left array to the result array
                   then increase the index of the left index by one.*/
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }

                /* If only the elements of the array on the right are left, after adding the current element of this array to the result array
                 increase the index of the right index by one */
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }

            return result;
        }

        /**
*
*	  @name   Quick Sort Lomuto
*
*	  @brief Quick Sort Lomuto Algorithm
*
*	  Lomuto’s partition scheme is easy to implement as compared to Hoare scheme. 
*	  This has inferior performance to Hoare’s QuickSort.
*	  This algorithm works by assuming the pivot element as the last element. 
*	  If any other element is given as a pivot element then swap it first with the last element. 
*	  Now initialize two variables i as low and j also low, swap whenever arr[I] <= arr[j], and increment i, otherwise only increment j.
*	  After coming out from the loop swap arr[i] with arr[hi]. This i stores the pivot element.
*     
*     @param  [in] mass [array, position1, position2 int]   Quick Sort Lomuto in the serie
     @retval [\b n] Quick Sort Lomuto
*	  
**/



        static void Swap(int[] array,
              int position1,
              int position2)
        {
            // Swaps elements in an array

            // Copy the first position's element
            int temp = array[position1];

            // Assigns the element in the second position to the first position
            array[position1] = array[position2];

            // Assigns the element in the Temp variable to the second position
            array[position2] = temp;
        }
       

        static int Partition(int[] arr, int low, int high)
        {
            // Sets the pivot element as the trailing element.
            int pivot = arr[high];


            int i = (low - 1);


            //Traverses the array to the left for elements smaller than the pivot element and to the right for elements larger than the pivot element.
            for (int j = low; j <= high - 1; j++)
            {


                /* If the current element is less than or equal to the pivot element, the smaller elements are added together.
                and increments the index of smaller elements by one.
                                 */
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            // Replaces the pivot element and the last element of the partition where smaller elements are collected.
            Swap(arr, i + 1, high);

            return (i + 1);


        }


        /**
       *
       *	  @name   Quick Sort Hoare's
       *
       *	  @brief Quick Sort Hoare's Algorithm
       *
       *	 Hoare’s Partition Scheme works by initializing two indexes that start at two ends, 
       *	 the two indexes move toward each other until an inversion is (A smaller value on the left side and greater value on the right side) found. 
       *	 When an inversion is found, two values are swapped and the process is repeated.
       *     
       *     @param  [in] mass [array,position1,position2 int]   Quick Sort Hoare's in the serie
            @retval [\b n] Quick Sort Hoare's
       *	  
       **/

        public static int RandomHoarePartition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low - 1, j = high + 1;

            while (true)
            {

                // Continue incrementing i until it finds the element greater than or equal to Pivot.
                do
                {
                    i++;
                } while (arr[i] < pivot);

                // Decrement j until it finds the element less than or equal to Pivot.
                do
                {
                    j--;
                } while (arr[j] > pivot);


                if (i >= j)
                    return j;

                int tempp = arr[i];
                arr[i] = arr[j];
                arr[j] = tempp;
            }
        }

     

        public static int Random(int[] arr, int low, int high)
        {
            /* Generate a random number in between
             low ,high*/
            Random rand = new Random();
            int pivot = rand.Next() % (high - low) + low;

            int tempp1 = arr[pivot];
            arr[pivot] = arr[high];
            arr[high] = tempp1;

            return RandomHoarePartition(arr, low, high);
        }
      
        public static void RandomQuicksortHoare(int[] array, int lw, int high)
        {
            if (lw < high)
            {
                /* pi is partitioning index, arr[pi] is
                      now at right place */
                int pi = Random(array, lw, high);

                // Recursively sort elements before
                // partition and after partition
                RandomQuicksortHoare(array, lw, pi);
                RandomQuicksortHoare(array, pi + 1, high);
            }
        }

        
        static void SwapHoares(int[] array,
                       int position1,
                       int position2)
        {
            // Swaps elements in an array

            // Copy the first position's element
            int temp = array[position1];

            // Assign to the second element
            array[position1] = array[position2];

            // Assign to the first element
            array[position2] = temp;
        }


        
        static int PartitionHoares(int[] arr, int low,
                                               int high)
        {
            int pivot = arr[high];

            // Index of smaller element
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller
                // than or equal to pivot
                if (arr[j] <= pivot)
                {
                    i++; // increment index of
                         // smaller element
                    SwapHoares(arr, i, j);
                }
            }
            SwapHoares(arr, i + 1, high);
            return (i + 1);
        }
       
        public static void QuickSortHoares(int[] arr, int low,
                                        int high)
        {
            if (low < high)
            {
                /* pi is partitioning index,
                arr[p] is now at right place */
                int pi = Partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                QuickSortHoares(arr, low, pi - 1);
                QuickSortHoares(arr, pi + 1, high);
            }
        }

        /**
         *  @ name   Random Quick Sort Lomuto
         *  @ brief  Quick Sort Hoare's Algorithm
         *  
         *         This function takes last element as pivot,
         *    places the pivot element at its correct
         *   position in sorted array, and places all
         *  smaller (smaller than pivot) to left of
         *  pivot and all greater elements to right
         *  of pivot 
         *
         * @retval  [\b n] Random Quick Sort Lomuto
         *
         **/
        static int PartitionRL(int[] arr, int low, int high)
        {

            // pivot is chosen randomly
            RandomQSL(arr, low, high);
            int pivot = arr[high];

            int i = (low - 1); // index of smaller element
            for (int j = low; j < high; j++)
            {

                // If current element is smaller than or
                // equal to pivot
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    int tempp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot)
            int tempp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = tempp2;

            return i + 1;
        }


        static int RandomQSL(int[] arr, int low, int high)
        {

            Random rand = new Random();
            int pivot = rand.Next() % (high - low) + low;

            int tempp1 = arr[pivot];
            arr[pivot] = arr[high];
            arr[high] = tempp1;

            return Partition(arr, low, high);
        }

        public static void RandomQuickSortLomuto(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is
                      now at right place */
                int pi = Partition(arr, low, high);

                /* Recursively sort elements before
                 partition and after partition*/
                RandomQuickSortLomuto(arr, low, pi - 1);
                RandomQuickSortLomuto(arr, pi + 1, high);
            }
        }


        //Binary Search Iterative
        /**
*
*	  @name   Binary Search Iterative (ce100_Binary_Search_Iterative)
*
*	  @brief Binary Search Iterative Function
*
*	  It is a function that helps us find the rank of any number in an ordered array, starting from 0.
*	  
*
*	  @param  [in] İnputArray [\b int]  key of Binary Search Iterative Function 
*
*	  @retval [\b int] function Binray Search Iterative*/

        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return mid;
                }
                else if (key < inputArray[mid])
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

        //Binary Search Recursive
        /**
*
*	  @name   Binary Search Recursive (ce100_Binary_Search_Recursive)
*
*	  @brief Binary Search Recursive Function
*
*	  It is a function that helps us find the rank of any number in an ordered array, starting from 0.
*	  
*
*	  @param  [in] İnputArray , min [\b int]  max, key of Binary Search Recursive Function 
*
*	  @retval [\b int] function Binray Search Recursive*/


        public static int BinarySearchRecursive(int[] inputArray, int min, int max, int key)
        {


            int mid = min + (max - min) / 2;

            if (key == inputArray[mid])
            {
                return mid;
            }
            else if (key < inputArray[mid])
            {
                return BinarySearchRecursive(inputArray, min, mid - 1, key);
            }
            else
            {
                return BinarySearchRecursive(inputArray, mid + 1, max, key);
            }

        }



        /**
*
*	  @name  Matrix Multiplication Iterative
*
*	  @brief Matrix Multiplication Iterative Algorithm
*
*	 
*     
*     @param  [in] mass [mat1, mat2, res int]   Matrix Multiplication Iterative in the serie
*   @retval [\b n] Matrix Multiplication Iterative 
*	  
**/

        static int n = 10;
        public static void MatrixMultiplicationIterative(int[,] mat1,
                         int[,] mat2, int[,] res)
        {
            int i, j, k;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    res[i, j] = 0;
                    for (k = 0; k < n; k++)
                        res[i, j] += mat1[i, k]
                                     * mat2[k, j];
                }
            }
        }

        public static int i = 0, j = 0, k = 0;
        public static void MatrixMultiplicationRecursive(int row1, int col1,
                                    int[,] A, int row2,
                                    int col2, int[,] B,
                                    int[,] C)
        {
            // If all rows traversed
            if (i >= row1)
                return;

            // If i < row1
            if (j < col2)
            {
                if (k < col1)
                {
                    C[i, j] += A[i, k] * B[k, j];
                    k++;

                    MatrixMultiplicationRecursive(row1, col1, A,
                                      row2, col2, B, C);
                }

                k = 0;
                j++;
                MatrixMultiplicationRecursive(row1, col1, A,
                                  row2, col2, B, C);
            }

            j = 0;
            i++;
            MatrixMultiplicationRecursive(row1, col1, A,
                              row2, col2, B, C);
        }


        /**
*
*	  @name  Matrix Multiplication Strassen
*
*	  @brief Matrix Multiplication Strassen Algorithm
*
*	 
*     
*     @param  [in] mass [n, m1, m2 int]   Matrix Multiplication Strassen in the serie
*   @retval [\b n] Matrix Multiplication Strassen 
*	  
**/
        public static class MatrixMultiplicationStrassen
        {
            public static int[,] Strassen(int[,] A, int[,] B)
            {
                int i, j, k;
                int N = A.GetLength(1);
                int[,] C = new int[N, N];
                if (N == 1)
                {
                    C[0, 0] = A[0, 0] * B[0, 0];
                    return C;
                }
                else
                {
                    for (i = 0; i < N; i++)
                    {
                        for (j = 0; j < N; j++)
                        {
                            C[i, j] = 0;
                            for (k = 0; k < N; k++)
                            {
                                C[i, j] += A[i, k] * B[k, j];
                            }
                        }
                    }
                    return C;
                }
            }

        }


    }
}
        
