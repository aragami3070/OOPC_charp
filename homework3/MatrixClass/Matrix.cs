using System; // Need for compile with mono
namespace CharMatrix{
    class Matrix {
        private int Row;                // кол-во строк матрицы
        private int Column;             // кол-во колонок матрицы
        private char[,] MatrixArray;    // матрица ввиде двумерного списка

        // Конструктор
        public Matrix(int row, int column){
            Row = row;
            Column = column;
            MatrixArray = new char[Row,Column];
        }

        // Конструктор копирования
        public Matrix(Matrix otherMatrix, int number){
            this.Row = otherMatrix.Row;
            this.Column = otherMatrix.Column;
            MatrixArray = new char[Row,Column];
            for (int i = 0; i < Row; i++){
                for (int j = 0; j < Column; j++){
                    MatrixArray[i,j] = Convert.ToChar(otherMatrix.MatrixArray[i,j] + number);
                }
            }
        }

        // Деструктор
        ~Matrix(){
            Type objtype = this.GetType();
            Console.WriteLine(objtype.Name + " Delete");
        }

        // вывод матрицы в консоль
        public void InputMatrix(){
            Console.WriteLine("Введите элементы матрицы");
            for (int i = 0; i < Row; i++){
                for (int j = 0; j < Column; j++){
                    Console.Write("Matrix[{0},{1}] = ", i, j);
                    MatrixArray[i,j] = char.Parse(Console.ReadLine());
                }
            }
        }

        // вывод матрицы в консоль
        public void PrintMatrix(){
            for (int i = 0; i < Row; i++){
                for (int j = 0; j < Column; j++){
                    Console.Write("{0,5}", MatrixArray[i, j]);
                }
                Console.WriteLine();
            }
        }
        // средние арифметическое всех элементов матрицы
        public double MeanElements(){
            double mean = 0;
            for (int i = 0; i < Row; i++){
                for (int j = 0; j < Column; j++){
                    mean += Convert.ToInt32(MatrixArray[i,j]);
                }
            }
            mean = mean / (Row * Column);
            return mean;
        }
    }
}
