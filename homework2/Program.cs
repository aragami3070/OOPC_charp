using homework2;
class Program{
    static void Main(){
        int[][] myArray = MyTask.InputAr();
        Console.WriteLine("Исходный массив:");
        MyTask.PrintAll(myArray);
        int[] resultArray = MyTask.FindFirstPositive(myArray);
        Console.WriteLine("Массив первых положительных в столбце:");
        MyTask.PrintRow(resultArray);
    }
}
