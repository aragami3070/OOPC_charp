namespace homework2{
    class Task1{
        public static void Print(int n, int[] a){ //n – размерность массива, а – ссылка на массив
            for (int i = 0; i < n; i++){
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        public static void Change(int n, int[] a){
            for (int i = 0; i < n; i++){
                if (a[i] > 0){
                    a[i] *= 2; // изменяются элементы массива
                }
            }
        }
    }
}
