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
                // создаем m ячеек в i-ой строке массива
                arr[i] = new int[n];
                for (int j = 0; j < n; ++j){
                    Console.Write("arr[{0},{1}] = ", i, j);
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        public static int[,] MakeArray(){
            Console.WriteLine("Введите размерность массива:");
            Console.Write("n = ");

            // считываем кол-во строк
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            // создаем массив из n строк, m столбцов
            int [,] arr = new int[n,m];

            for (int i = 0; i < n; ++i){
                for (int j = 0; j < m; ++j){
                    Console.Write("arr[{0},{1}] = ", i, j);
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            return arr;
        }

        public static void PrintAllDoubleArr(int [,] arr){
            for (int i = 0; i < arr.GetLength(0); ++i){
                for (int j = 0; j < arr.GetLength(1); ++j){
                    Console.Write("{0,5}", arr[i, j]);
                }
                Console.WriteLine();
            }
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

        // нахождение номеров последнего нечетного элемента и записать данные в новый массив.
        public static int[] LastOddElm(int [][] arr){
            int[] res = new int[arr.Length];
            int index = 0;
            for (int j = 0; j < arr.Length; ++j){
                for (int i = 0; i < arr[j].Length; ++i){
                    if (arr[i][j] % 2 != 0){
                        res[index] = i * arr.Length + j;
                    }
                }
                index++;
            }
            return res;
        }


    }
}































