using CharMatrix;
using System; // Need for compile with mono
class Program{
    static void Main(){
        int n;
        Console.WriteLine("Введите размерность матрицы:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("=============================================================");
        // создаем матрицу из елементов типа char
        Matrix test = new Matrix(n, n);
        test.InputMatrix();
        Console.WriteLine("=============================================================");
        Console.WriteLine("Матрица {0}:", nameof(test));
        test.PrintMatrix();
        // Применим конструктор копирования
        Console.WriteLine("Применим конструктор копирования:");
        Matrix test2 = new Matrix(test, 1);
        Console.WriteLine("=============================================================");
        Console.WriteLine("Матрица {0}:", nameof(test2));
        test2.PrintMatrix();
        Console.WriteLine("=============================================================");
        // находим среднее арифметическое всех элементов и выводим его
        double mean = test.MeanElements();
        Console.WriteLine("Вывод среднего арифметического всех элементов матрицы:");
        Console.WriteLine("=============================================================");
        Console.WriteLine(mean);
    }
}
