using homework2;
class Program{
    static void Main(){
        int[][] myArray = MyTask.InputAr();
        Console.WriteLine("Исходный массив:");
        MyTask.PrintAll(myArray);

        int[] resultArray = MyTask.LastOddElm(myArray);
        Console.WriteLine("Массив номеров последних нечетных элементов в столбце(нумерация с 0):");
        MyTask.PrintRow(resultArray);
    }
}
