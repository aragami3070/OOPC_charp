using CharMatrix;
class Program{
    static void Main(){
        Matrix test = new Matrix(2, 2);
        test.InputMatrix();
        Console.WriteLine("Матрица {0}:", nameof(test));
        test.PrintMatrix();
        Console.WriteLine("Применим конструктор копирования");
        Matrix test2 = new Matrix(test, 1);
        Console.WriteLine("Матрица {0}:", nameof(test2));
        test2.PrintMatrix();
    }
}
