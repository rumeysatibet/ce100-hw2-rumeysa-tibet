using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ce100_hw2_algo_lib_cs;

namespace ce100_hw2_algo_lib_cs
{
    public class Class1
    {
        static int[] H = new int[50];
        static int size = -1;

        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
        }

        /**
        *
        *	  @name   matrix_Multiplication_Iterative (Matris Multiplication Iterative)
        *
        *	  @brief Matris Multiplication Recursive
        *
        *	  Matris Multiplication Recursive
        *
        *	  @param  [in] a [\b int]  a
        *	  
        *	  @param  [in] b [\b int]  b
        *	  
        *	  @param  [in] row [\b int]  row
        *	  
        *	  @param  [in] column [\b int]  column
        *	   
        *	  
        **/

        public static int[,] matrix_Multiplication_Iterative(int[,] a, int[,] b, int row, int column)
        {
            //new multidimensional matrix for the result
            int[,] result = new int[row, column];
            //first for loop for rows
            for (int i = 0; i < row; i++)
            {
                //second for loop for traversing through columns
                for (int j = 0; j < column; j++)
                {
                    //initializing result matrix with 0
                    result[i, j] = 0;
                    //third for loop for calculating results
                    for (int k = 0; k < row; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            //returning result
            return result;
        }

        public static int MAX = 100;

        // Note that below variables
        // are static i and j are used
        // to know current cell of result
        // matrix C[][]. k is used to
        // know current column number of
        // A[][] and row number of B[][]
        // to be multiplied
        public static int i = 0, j = 0, k = 0;

        /**
        *
        *	  @name   multiplyMatrixRecursive (Matris Multiplication Recursive)
        *
        *	  @brief Matris Multiplication Recursive
        *
        *	  Matris Multiplication Recursive
        *
        *	  @param  [in] row1 [\b int]  row1
        *	  
        *	  @param  [in] col1 [\b int]  col1
        *	  
        *	  @param  [in] A [\b int]  A
        *	  
        *	  @param  [in] row2 [\b int]  row2
        *	  
        *	  @param  [in] col2 [\b int]  col2
        *	  
        *	  @param  [in] B [\b int]  B
        *	  
        *	  @param  [in] C [\b int]  C  
        *	  
        *	  
        **/

        public static void multiply_Matrix_Recursive(int row1, int col1, int[,] A, int row2, int col2, int[,] B, int[,] C)
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

                    multiply_Matrix_Recursive(row1, col1, A,
                                      row2, col2, B, C);
                }

                k = 0;
                j++;
                multiply_Matrix_Recursive(row1, col1, A,
                                  row2, col2, B, C);
            }

            j = 0;
            i++;
            multiply_Matrix_Recursive(row1, col1, A,
                              row2, col2, B, C);
        }

        // Function to multiply two
        // matrices A[][] and B[][]

        /**
        *
        *	  @name  Matrixmultiply (Matris Multiplication Recursive)
        *
        *	  @brief Matris Multiplication Recursive
        *
        *	  Matris Multiplication Recursive
        *
        *	  @param  [in] row1 [\b int]  row1
        *	  
        *	  @param  [in] col1 [\b int]  col1
        *	  
        *	  @param  [in] A [\b int]  A
        *	  
        *	  @param  [in] row2 [\b int]  row2
        *	  
        *	  @param  [in] col2 [\b int]  col2
        *	  
        *	  @param  [in] B [\b int]  B
        *	  
        *	  
        **/

        public static void Matrixmultiply(int row1, int col1, int[,] A, int row2, int col2, int[,] B)
        {
            if (row2 != col1)
            {
                return;
            }

            int[,] C = new int[MAX, MAX];

            multiply_Matrix_Recursive(row1, col1, A,
                              row2, col2, B, C);
        }





        /**
        *
        *	  @name   matrixMultiplicationStrassen (Strassen)
        *
        *	  @brief Strassen
        *
        *	  Strassen
        *     
        *     @param  [in] A [\b int]  A
        *     
        *     @param  [in] B [\b int]  B
        *	  
        **/

        public static int[,] matrixMultiplicationStrassen(int[,] A, int[,] B)
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


        /**
        *
        *	  @name   HoarePartition (Hoare Partition)
        *
        *	  @brief Hoare Partition
        *
        *	  Hoare Partition
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/


        public static int HoarePartition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low - 1, j = high + 1;

            while (true)
            {
                // Find leftmost element greater
                // than or equal to pivot
                do
                {
                    i++;
                } while (arr[i] < pivot);

                // Find rightmost element smaller
                // than or equal to pivot
                do
                {
                    j--;
                } while (arr[j] > pivot);

                // If two pointers met.
                if (i >= j)
                    return j;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                // swap(arr[i], arr[j]);
            }
        }

        /**
        *
        *	  @name   HoareQuickSort (Hoare Quick Sort)
        *
        *	  @brief Hoare Quick Sort
        *
        *	  Hoare Quick Sort
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/



        /* The main function that
           implements QuickSort
        arr[] --> Array to be sorted,
        low --> Starting index,
        high --> Ending index */
        public static void HoareQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index,
                arr[p] is now at right place */
                int pi = HoarePartition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                HoareQuickSort(arr, low, pi);
                HoareQuickSort(arr, pi + 1, high);
            }
        }


        /**
        *
        *	  @name   LomutoPartition (Lomuto Partition)
        *
        *	  @brief Lomuto Partition
        *
        *	  Lomuto Partition
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/



        /* This function takes last element as
        pivot, places the pivot element at its
        correct position in sorted array, and
        places all smaller (smaller than pivot)
        to left of pivot and all greater elements
        to right of pivot */
        public static int LomutoPartition(int[] arr, int low, int high)
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
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }


        /**
        *
        *	  @name   LomutoQuickSort (Lomuto Quick Sort)
        *
        *	  @brief Lomuto Quick Sort
        *
        *	  Lomuto Quick Sort
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/


        /* The main function that
           implements QuickSort
        arr[] --> Array to be sorted,
        low --> Starting index,
        high --> Ending index */
        public static void LomutoQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index,
                arr[p] is now at right place */
                int pi = LomutoPartition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                LomutoQuickSort(arr, low, pi - 1);
                LomutoQuickSort(arr, pi + 1, high);
            }
        }




        /**
        *
        *	  @name   partitionHoare_Randomized (Partition Hoare Randomized)
        *
        *	  @brief Partition Hoare Randomized
        *
        *	  Partition Hoare Randomized
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/


        public static int partitionHoare_Randomized(int[] arr, int low, int high)
        {
            Random rd = new Random();
            int random = rd.Next(low, high);

            swap(arr, random, low);

            return HoarePartition(arr, low, high);
        }

        /**
        *
        *	  @name   quickSortHoare_Randomized (Quick Sort Hoare Randomized)
        *
        *	  @brief Quick Sort Hoare Randomized
        *
        *	  Quick Sort Hoare Randomized
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/

        public static void quickSortHoare_Randomized(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partitionHoare_Randomized(arr, low, high);

                quickSortHoare_Randomized(arr, low, pi);
                quickSortHoare_Randomized(arr, pi + 1, high);
            }
        }

        /**
        *
        *	  @name   partitionLomuto_Randomized (Partition Lomuto Randomized)
        *
        *	  @brief Partition Lomuto Randomized
        *
        *	  Partition Lomuto Randomized
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/

        public static int partitionLomuto_Randomized(int[] arr, int low, int high)
        {

            // pivot is chosen randomly
            randomLomuto_Randomized(arr, low, high);
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


        /**
        *
        *	  @name   randomLomuto_Randomized (Random Lomuto Randomized)
        *
        *	  @brief Random Lomuto Randomized
        *
        *	  Random Lomuto Randomized
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/


        // This Function helps in calculating
        // random numbers between low(inclusive)
        // and high(inclusive)
        static int randomLomuto_Randomized(int[] arr, int low, int high)
        {

            Random rand = new Random();
            int pivot = rand.Next() % (high - low) + low;

            swap(arr, pivot, high);

            return partitionLomuto_Randomized(arr, low, high);
        }


        /**
        *
        *	  @name   quickSortLomuto_Randomized (Quick Sort Lomuto Randomized)
        *
        *	  @brief Quick Sort Lomuto Randomized
        *
        *	  Quick Sort Lomuto Randomized
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] low [\b int]  low
        *	  
        *	  @param  [in] high [\b int]  high
        *	  
        *	   
        *	  
        **/


        /* The main function that implements Quicksort()
          arr[] --> Array to be sorted,
          low --> Starting index,
          high --> Ending index */
        public static void quickSortLomuto_Randomized(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is
                      now at right place */
                int pi = partitionLomuto_Randomized(arr, low, high);

                // Recursively sort elements before
                // partition and after partition
                quickSortLomuto_Randomized(arr, low, pi - 1);
                quickSortLomuto_Randomized(arr, pi + 1, high);
            }
        }
        public static int SelectionProblem(int[] arr, int l, int r, int k)
        {
            // If k is smaller than number
            // of elements in array
            if (k > 0 && k <= r - l + 1)
            {
                // Partition the array around a
                // random element and get position
                // of pivot element in sorted array
                int pos = randomPartition_SelectionProblem(arr, l, r);

                // If position is same as k
                if (pos - l == k - 1)
                    return arr[pos];

                // If position is more, recur
                // for left subarray
                if (pos - l > k - 1)
                    return SelectionProblem(arr, l, pos - 1, k);

                // Else recur for right subarray
                return SelectionProblem(arr, pos + 1, r,
                                k - pos + l - 1);
            }

            // If k is more than number of
            // elements in array
            return int.MaxValue;
        }

        /**
        * 
        * @name partition
        * @param [in] arr [\b int[]] 
        * @param [in] l [\b int] 
        * @param [in] r [\b int]
        * Standard partition process of QuickSort().
        * It considers the last element as pivot and
        * moves all smaller element to left of it
        * and greater elements to right. This function
        * is used by randomPartition()
        * 
        **/
        static int partition(int[] arr, int l, int r)
        {
            int x = arr[r], i = l;
            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    Swap(arr, i, j);
                    i++;
                }
            }
            Swap(arr, i, r);
            return i;
        }

        /**
        * 
        * @name randomPartition_SelectionProblem
        * @param [in] arr [\b int[]] 
        * @param [in] l [\b int] 
        * @param [in] r [\b int]
        * Picks a random pivot element between
        * l and r and partitions arr[l..r]
        * around the randomly picked element
        * using partition()
        * 
        **/
        static int randomPartition_SelectionProblem(int[] arr, int l, int r)
        {
            int n = r - l + 1;
            Random rnd = new Random();
            int rand = rnd.Next(0, 1);
            int pivot = (int)(rand * (n - 1));
            Swap(arr, l + pivot, r);
            return partition(arr, l, r);
        }

        private static void Swap(int[] arr, int v, int r)
        {
            throw new NotImplementedException();
        }

        /**
        *
        *	  @name   findMedian (Selection Problem)
        *
        *	  @brief Selection Problem
        *
        *	  Selection Problem
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] i [\b int]  i
        *	  
        *	  @param  [in] n [\b int]  n
        *	  
        *	   
        *	  
        **/


        static int findMedian(int[] arr, int i, int n)
        {
            if (i <= n)
                Array.Sort(arr, i, n); // Sort the array
            else
                Array.Sort(arr, n, i);
            return arr[n / 2]; // Return middle element
        }

        // Returns k'th smallest element
        // in arr[l..r] in worst case
        // linear time. ASSUMPTION: ALL
        // ELEMENTS IN ARR[] ARE DISTINCT
        static int kthSmallest(int[] arr, int l,
                                    int r, int k)
        {
            // If k is smaller than
            // number of elements in array
            if (k > 0 && k <= r - l + 1)
            {
                int n = r - l + 1; // Number of elements in arr[l..r]

                // Divide arr[] in groups of size 5,
                // calculate median of every group
                // and store it in median[] array.
                int i;

                // There will be floor((n+4)/5) groups;
                int[] median = new int[(n + 4) / 5];
                for (i = 0; i < n / 5; i++)
                    median[i] = findMedian(arr, l + i * 5, 5);

                // For last group with less than 5 elements
                if (i * 5 < n)
                {
                    median[i] = findMedian(arr, l + i * 5, n % 5);
                    i++;
                }

                // Find median of all medians using recursive call.
                // If median[] has only one element, then no need
                // of recursive call
                int medOfMed = (i == 1) ? median[i - 1] :
                                        kthSmallest(median, 0, i - 1, i / 2);

                // Partition the array around a random element and
                // get position of pivot element in sorted array
                int pos = partition(arr, l, r, medOfMed);

                // If position is same as k
                if (pos - l == k - 1)
                    return arr[pos];
                if (pos - l > k - 1) // If position is more, recur for left
                    return kthSmallest(arr, l, pos - 1, k);

                // Else recur for right subarray
                return kthSmallest(arr, pos + 1, r, k - pos + l - 1);
            }

            // If k is more than number of elements in array
            return int.MaxValue;
        }

        static int[] swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            return arr;
        }

        // It searches for x in arr[l..r], and
        // partitions the array around x.
        static int partition(int[] arr, int l,
                                int r, int x)
        {
            // Search for x in arr[l..r] and move it to end
            int i;
            for (i = l; i < r; i++)
                if (arr[i] == x)
                    break;
            swap(arr, i, r);

            // Standard partition algorithm
            i = l;
            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    swap(arr, i, j);
                    i++;
                }
            }
            swap(arr, i, r);
            return i;
        }


        /**
        *
        *	  @name   Heap_Sort (Heap Sort)
        *
        *	  @brief Heap Sort
        *
        *	  Heap Sort
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] n [\b int]  n
        *	  
        *	  
        **/


        public static void Heap_Sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap (rearrange array)
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);

            // One by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // call max heapify on the reduced heap
                heapify(arr, i, 0);
            }
        }

        /**
        *
        *	  @name   heapify (Heap Sort)
        *
        *	  @brief Heap Sort
        *
        *	  Heap Sort
        *
        *	  @param  [in] arr [\b int]  arr
        *	  
        *	  @param  [in] n [\b int]  n
        *	  
        *	  @param  [in] i [\b int]  i
        *	  
        *	  
        **/

        static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }




        /**
        *
        *	  @name   parent (Priority Queue with Heap)
        *
        *	  @brief Priority Queue with Heap
        *
        *	  Priority Queue with Heap
        *	  
        *	  @param  [in] i [\b int]  i
        *	  
        **/




        // Function to return the index of the
        // parent node of a given node

        static int parent(int i)
        {
            return (i - 1) / 2;
        }

        // Function to return the index of the
        // left child of the given node
        static int leftChild(int i)
        {
            return ((2 * i) + 1);
        }

        // Function to return the index of the
        // right child of the given node
        static int rightChild(int i)
        {
            return ((2 * i) + 2);
        }

        // Function to shift up the
        // node in order to maintain
        // the heap property
        static void shiftUp(int i)
        {
            while (i > 0 &&
                   H[parent(i)] < H[i])
            {

                // Swap parent and current node
                swappq(parent(i), i);

                // Update i to parent of i
                i = parent(i);
            }
        }

        // Function to shift down the node in
        // order to maintain the heap property
        static void shiftDown(int i)
        {
            int maxIndex = i;

            // Left Child
            int l = leftChild(i);

            if (l <= size &&
                H[l] > H[maxIndex])
            {
                maxIndex = l;
            }

            // Right Child
            int r = rightChild(i);

            if (r <= size &&
                H[r] > H[maxIndex])
            {
                maxIndex = r;
            }

            // If i not same as maxIndex
            if (i != maxIndex)
            {
                swappq(i, maxIndex);
                shiftDown(maxIndex);
            }
        }

        // Function to insert a
        // new element in
        // the Binary Heap
        public static void insert(int p)
        {
            size = size + 1;
            H[size] = p;

            // Shift Up to maintain
            // heap property
            shiftUp(size);
        }

        // Function to extract
        // the element with
        // maximum priority
        public static int extractMax()
        {
            int result = H[0];

            // Replace the value
            // at the root with
            // the last leaf
            H[0] = H[size];
            size = size - 1;

            // Shift down the replaced
            // element to maintain the
            // heap property
            shiftDown(0);
            return result;
        }

        // Function to change the priority
        // of an element
        public static void changePriority(int i,
                                   int p)
        {
            int oldp = H[i];
            H[i] = p;

            if (p > oldp)
            {
                shiftUp(i);
            }
            else
            {
                shiftDown(i);
            }
        }

        // Function to get value of
        // the current maximum element
        public static int getMax()
        {
            return H[0];
        }

        // Function to remove the element
        // located at given index
        public static void Remove(int i)
        {
            H[i] = getMax() + 1;

            // Shift the node to the root
            // of the heap
            shiftUp(i);

            // Extract the node
            extractMax();
        }

        static void swappq(int i, int j)
        {
            int temp = H[i];
            H[i] = H[j];
            H[j] = temp;
        }



        /**
       *
       *	  @name   countingsort (counting Sort)
       *
       *	  @brief Sounting Sort
       *
       *	  Sounting Sort
       *
       *	  @param  [in] Array [\b int]  Array
       *	  
       *	  @param  [in] place [\b int]  place
       *	    
       *	  
       **/
        static void countingsort(int[] Array, int place)
        {
            int n = Array.Length;
            int[] output = new int[n];

            //range of the number is 0-9 for each place considered.
            int[] freq = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //count number of occurrences in freq array
            for (int i = 0; i < n; i++)
                freq[(Array[i] / place) % 10]++;

            //Change count[i] so that count[i] now contains actual 
            //position of this digit in output[] 
            for (int i = 1; i < 10; i++)
                freq[i] += freq[i - 1];

            //Build the output array 
            for (int i = n - 1; i >= 0; i--)
            {
                output[freq[(Array[i] / place) % 10] - 1] = Array[i];
                freq[(Array[i] / place) % 10]--;
            }

            //Copy the output array to the input Array, Now the Array will 
            //contain sorted array based on digit at specified place
            for (int i = 0; i < n; i++)
                Array[i] = output[i];
        }

        public static void countingsort(int[] Array)
        {
            int n = Array.Length;
            int max = 0;
            //find largest element in the Array
            for (int i = 0; i < n; i++)
            {
                if (max < Array[i])
                {
                    max = Array[i];
                }
            }

            //Create a freq array to store number of occurrences of 
            //each unique elements in the given array 
            int[] freq = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                freq[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                freq[Array[i]]++;
            }

            //sort the given array using freq array
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (freq[i] > 0)
                {
                    Array[j] = i;
                    j++;
                    freq[i]--;
                }
            }
        }


        /**
        *
        *	  @name   RadixSort (Radix Sort)
        *
        *	  @brief Radix Sort
        *
        *	  Radix Sort
        *
        *	  @param  [in] Array [\b int]  Array
        *	  	    
        *	  
        **/

        // function for radix sort
        public static void RadixSort(int[] Array)
        {
            int n = Array.Length;
            int max = Array[0];

            //find largest element in the Array
            for (int i = 1; i < n; i++)
            {
                if (max < Array[i])
                    max = Array[i];
            }

            //Counting sort is performed based on place. 
            //like ones place, tens place and so on.
            for (int place = 1; max / place > 0; place *= 10)
                countingsort(Array, place);
        }
    }
}