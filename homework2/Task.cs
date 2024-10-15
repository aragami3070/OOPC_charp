using System;

namespace homework2{
    class MyTask{
        public static int[][] InputAr(){
            Console.WriteLine("Введите размерность массива:");
            Console.Write("n = ");

            // считываем кол-во строк
            int n = int.Parse(Console.ReadLine());
            // создаем массив из n строк
            int [][] arr = new int[n][];

            for (int i = 0; i < n; ++i){
                // считываем кол-во ячеек в строке
                Console.WriteLine("Введите размерность массива (кол-во элементов в строке):");
                int m = int.Parse(Console.ReadLine());
                // создаем n ячеек в i-ой строке массива
                arr[i] = new int[m];
                for (int j = 0; j < m; ++j){
                    Console.Write("arr[{0},{1}] = ", i, j);
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        public static void PrintRow(int[] arr){ // а – ссылка на массив
            for (int i = 0; i < arr.Length; ++i){
                Console.Write("{0,5}", arr[i]);
            }
        }

        public static void PrintAll(int [][] arr){
            for (int i = 0; i < arr.Length; ++i){
                for (int j = 0; j < arr[i].Length; ++j){
                    Console.Write("{0,5}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static int[] FindFirstPositive(int [][] arr){
            int[] res = new int[arr.Length];
            int index = 0;
            for (int j = 0; j < arr.Length; ++j){
                for (int i = 0; i < arr[j].Length; ++i){
                    if (arr[i][j] > 0){
                        res[index] = arr[i][j];
                        index++;
                        break;
                    }
                }
            }
            return res;
        }


    }
}































