using Microsoft.VisualStudio.TestTools.UnitTesting;
using ce100_hw2_algo_lib_cs;
using System;

namespace ce100_hw2_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MatrixMultiplicationIterative_Test1()
        {

            int[,] a = {{1, 3},
                       {0, 2}};

            int[,] b =  {{0, 1},
                       {3, 4}};


            int row = 2, col = 2;

            int[,] result = {{9, 13},
                              {6, 8}};
            CollectionAssert.AreEqual(Class1.matrix_Multiplication_Iterative(a, b, row, col), result);

        }

        [TestMethod]
        public void MatrixMultiplicationIterative_Test2()
        {

            int[,] a = {{3, 0,1},
                       {1, 2,2},
                       { 0,1,2}};

            int[,] b = {{1, 4,1},
                       {0, 2,3},
                       {1,0,2 }};

            int row = 3, col = 3;

            int[,] result = {{4, 12,5 },
                             {3, 8 ,11},
                             {2,2,7}};
            CollectionAssert.AreEqual(Class1.matrix_Multiplication_Iterative(a, b, row, col), result);
        }

        [TestMethod]
        public void MatrixMultiplicationIterative_Test3()
        {

            int[,] a = {{2, 6, 5, 4},
                       {1, 4 ,6,7},
                       {2, 4, 5,3},
                       {1, 2, 3, 4}};

            int[,] b = {{2, 6, 8,1},
                       {2, 4, 4,2},
                       {3, 2,4,3},
                       {1,2,3,4 }};

            int row = 4, col = 4;

            int[,] result = {{35, 54, 72, 45},
                              {35, 48, 69, 55},
                              {30, 44, 61, 37},
                              {19, 28, 40,30}};
            CollectionAssert.AreEqual(Class1.matrix_Multiplication_Iterative(a, b, row, col), result);
        }

        [TestMethod]
        public void MatrixMultiplicationRecursive_Test1()
        {
            int row1 = 2, col1 = 2;
            int row2 = 2, col2 = 2;

            int[,] a = {{1, 3},
                       {0, 2}};

            int[,] b = {{0, 1},
                       {3, 4}};

            int[,] c = new int[row1, col2];

            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            Class1.multiply_Matrix_Recursive(row1, col1, a, row2, col2, b, c);
            int[,] expected = {{9, 13},
                              {6, 8}};
            CollectionAssert.AreEqual(c, expected);
        }

        [TestMethod]
        public void MatrixMultiplicationRecursive_Test2()
        {
            int row1 = 3, col1 = 3;
            int row2 = 3, col2 = 3;

            int[,] a = {{3, 0,1},
                       {1, 2,2},
                       { 0,1,2}};

            int[,] b = {{1, 4,1},
                       {0, 2,3},
                       {1,0,2 }};

            int[,] c = new int[row1, col2];

            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            Class1.multiply_Matrix_Recursive(row1, col1, a, row2, col2, b, c);
            int[,] expected =  {{4, 12,5 },
                             {3, 8 ,11},
                             {2,2,7}};
            CollectionAssert.AreEqual(c, expected);
        }

        [TestMethod]
        public void MatrixMultiplicationRecursive_Test3()
        {
            int row1 = 4, col1 = 4;
            int row2 = 4, col2 = 4;

            int[,] a = {{2, 6, 5, 4},
                       {1, 4 ,6,7},
                       {2, 4, 5,3},
                       {1, 2, 3, 4}};

            int[,] b = {{2, 6, 8,1},
                       {2, 4, 4,2},
                       {3, 2,4,3},
                       {1,2,3,4 }};

            int[,] c = new int[row1, col2];

            Class1.i = 0; Class1.j = 0; Class1.k = 0;
            Class1.multiply_Matrix_Recursive(row1, col1, a, row2, col2, b, c);
            int[,] expected = {{35, 54, 72, 45},
                              {35, 48, 69, 55},
                              {30, 44, 61, 37},
                              {19, 28, 40,30}};
            CollectionAssert.AreEqual(c, expected);
        }

        [TestMethod]
        public void MatrixMulStrTest1()
        {
            int[,] array = { { 1, 3},
                           { 0, 2 } };


            int[,] array2 = { { 0, 1 },
                            { 3, 4 } };

            int[,] result = { { 9, 13 },
                            { 6, 8 } };

            int[,] exp = Class1.matrixMultiplicationStrassen(array, array2);
            CollectionAssert.AreEqual(exp, result);
        }



        [TestMethod]
        public void MatrixMulStrTest2()
        {
            int[,] array = { { 4, 3 },
                           { 1, 5 } };


            int[,] array2 = { { 6, 2 },
                            { 7, 0 } };

            int[,] result = { { 45, 8 },
                            { 41, 2 } };

            int[,] exp = Class1.matrixMultiplicationStrassen(array, array2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void MatrixMulStrTest3()
        {
            int[,] array = { { 5, 3 },
                           { 9, 6 } };


            int[,] array2 = { { 1, 0 },
                            { 5, 7 } };

            int[,] result = { { 20, 21 },
                            { 39, 42 } };

            int[,] exp = Class1.matrixMultiplicationStrassen(array, array2);
            CollectionAssert.AreEqual(exp, result);
        }

        [TestMethod]
        public void QuickSortHoarePartition_Test1()
        {
            int[] array = { 12, 3, 41, 45, 5, 79 };
            int n = array.Length;
            Class1.HoareQuickSort(array, 0, n - 1);
            int[] result = { 3, 5, 12, 41, 45, 79 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortHoarePartition_Test2()
        {
            int[] array = { 13, 4, 42, 46, 6, 81 };
            int n = array.Length;
            Class1.HoareQuickSort(array, 0, n - 1);
            int[] result = { 4, 6, 13, 42, 46, 81 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortHoarePartition_Test3()
        {
            int[] array = { 15, 1, 33, 35, 5, 69 };
            int n = array.Length;
            Class1.HoareQuickSort(array, 0, n - 1);
            int[] result = { 1, 5, 15, 33, 35, 69 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortLomutoPartition_Test1()
        {
            int[] array = { 12, 5, 46, 23, 8, 7 };
            int n = array.Length;
            Class1.LomutoQuickSort(array, 0, n - 1);
            int[] result = { 5, 7, 8, 12, 23, 46 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortLomutoPartition_Test2()
        {
            int[] array = { 16, 6, 47, 24, 9, 80 };
            int n = array.Length;
            Class1.LomutoQuickSort(array, 0, n - 1);
            int[] result = { 6, 9, 16, 24, 47, 80 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void QuickSortLomutoPartition_Test3()
        {
            int[] array = { 11, 2, 40, 44, 4, 78 };
            int n = array.Length;
            Class1.LomutoQuickSort(array, 0, n - 1);
            int[] result = { 2, 4, 11, 40, 44, 78 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void randomQuickSortHoarePartition_Test1()
        {
            int[] array = { 32, 4, 47, 23, 8, 7 };
            int n = array.Length;
            Class1.partitionHoare_Randomized(array, 0, n - 1);
            int[] result = { 4, 7, 8, 23, 32, 47 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void randomQuickSortHoarePartition_Test2()
        {
            int[] array = { 33, 7, 47, 4, 9, 8 };
            int n = array.Length;
            Class1.partitionHoare_Randomized(array, 0, n - 1);
            int[] result = { 4, 7, 8, 9, 33, 47 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void randomQuickSortHoarePartition_Test3()
        {
            int[] array = { 35, 1, 45, 23, 3, 2 };
            int n = array.Length;
            Class1.partitionHoare_Randomized(array, 0, n - 1);
            int[] result = { 1, 2, 3, 23, 35, 45 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void randomQuickSortLomutoPartition_Test1()
        {
            int[] array = { 12, 5, 46, 23, 8, 7 };
            int n = array.Length;
            Class1.partitionLomuto_Randomized(array, 0, n - 1);
            int[] result = { 5, 7, 8, 12, 23, 46 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void randomQuickSortLomutoPartition_Test2()
        {
            int[] array = { 22, 5, 46, 23, 8, 7 };
            int n = array.Length;
            Class1.partitionLomuto_Randomized(array, 0, n - 1);
            int[] result = { 5, 7, 8, 22, 23, 46 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void randomQuickSortLomutoPartition_Test3()
        {
            int[] array = { 32, 4, 47, 23, 8, 7 };
            int n = array.Length;
            Class1.partitionLomuto_Randomized(array, 0, n - 1);
            int[] result = { 4, 7, 8, 23, 32, 47 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void SelectionProblem_1()
        {
            int[] arr = { 25, 35, 4, 8, 16, 9 };
            int n = arr.Length, k = 5;
            int expected = 25;
            int actual = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SelectionProblemTest2()
        {
            int[] arr = { 23, 29, 7, 10, 17, 3 };
            int n = arr.Length, k = 4;
            int expected = 17;
            int actual = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void SelectionProblemTest3()
        {
            int[] arr = { 4, 5, 8, 3, 41, 15 };
            int n = arr.Length, k = 6;
            int expected = 41;
            int actual = Class1.SelectionProblem(arr, 0, n - 1, k);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void HeapSort_Test1()
        {
            int[] array = { 10, 29, 20, 80, 89, 90 };
            Class1.Heap_Sort(array);
            int[] result = { 10, 20, 29, 80, 89, 90 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void Heap_Sort_Test2()
        {
            int[] array = { 11, 28, 21, 81, 87, 93 };
            Class1.Heap_Sort(array);
            int[] result = { 11, 21, 28, 81, 87, 93 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void HeapSort_Test3()
        {
            int[] array = { 14, 27, 23, 82, 85, 92 };
            Class1.Heap_Sort(array);
            int[] result = { 14, 23, 27, 82, 85, 92 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void PrioritryHeapSortTestMethod1()
        {

            int[] arr = new int[] { 45, 12, 78, 27, 63 };
            Class1.insert(78);
            Class1.insert(63);
            Class1.insert(45);
            Class1.insert(27);
            Class1.insert(12);
            int expected = Class1.extractMax();
            Assert.AreEqual(78, expected);
        }


        [TestMethod]
        public void PrioritryHeapSortTestMethod2()
        {

            int[] arr = new int[] { 21, 74, 34, 94, 56, 17, 24, 32, 23, 99 };
            Class1.insert(99);
            Class1.insert(86);
            Class1.insert(75);
            Class1.insert(67);
            Class1.insert(51);
            Class1.insert(44);
            Class1.insert(32);
            Class1.insert(23);
            Class1.insert(14);
            Class1.insert(9);
            int expected = Class1.extractMax();
            Assert.AreEqual(99, expected);
        }


        [TestMethod]
        public void PrioritryHeapSortTestMethod3()
        {

            int[] arr = new int[] { 546, 987, 325, 784, 862, 879, 589, 555 };
            Class1.insert(987);
            Class1.insert(879);
            Class1.insert(862);
            Class1.insert(784);
            Class1.insert(589);
            Class1.insert(555);
            Class1.insert(546);
            Class1.insert(325);
            int expected = Class1.extractMax();
            Assert.AreEqual(987, expected);
        }

        [TestMethod]
        public void CountingSortTestMethod1()
        {
            int[] array = new int[] { 1500, 136, 2345, 981, 121, 877, 323, 467 };
            int[] expected = new int[] { 121, 136, 323, 467, 877, 981, 1500, 2345 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSortTestMethod_2()
        {
            int[] array = new int[] { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100 };
            int[] expected = new int[] { 1, 12, 19, 25, 34, 55, 78, 89, 95, 100 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void CountingSortTestMethod3()
        {
            int[] array = new int[] { 486, 123, 458, 2, 145, 44, 33, 852, 612, 952 };
            int[] expected = new int[] { 2, 33, 44, 123, 145, 458, 486, 612, 852, 952 };

            Class1.countingsort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void RadixSort_Test1()
        {
            int[] array = { 24, 1, 33, 55, 5, 79 };
            int n = array.Length;
            Class1.RadixSort(array);
            int[] result = { 1, 5, 24, 33, 55, 79 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RadixSort_Test2()
        {
            int[] array = { 1, 7, 16, 92, 53, 68 };
            int n = array.Length;
            Class1.RadixSort(array);
            int[] result = { 1, 7, 16, 53, 68, 92 };
            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void RadixSort_Test3()
        {
            int[] array = { 3, 18, 71, 45, 29, 54 };
            int n = array.Length;
            Class1.RadixSort(array);
            int[] result = { 3, 18, 29, 45, 54, 71 };
            CollectionAssert.AreEqual(array, result);
        }
    }
}