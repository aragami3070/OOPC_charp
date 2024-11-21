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

        ~Matrix(){
            Type objtype = this.GetType();
            Console.WriteLine(objtype.Name + "Delete");
            // Array.Clear(MatrixArray);
            // for (int i = 0; i < Row; i++){
            //     for (int j = 0; j < Column; j++){
            //         Console.WriteLine(MatrixArray[i,j]);
            //     }
            // }
        }


        public void InputMatrix(){
            Console.WriteLine("Введите элементы матрицы");
            for (int i = 0; i < Row; i++){
                for (int j = 0; j < Column; j++){
                    Console.Write("Matrix[{0},{1}] = ", i, j);
                    MatrixArray[i,j] = char.Parse(Console.ReadLine());
                }
            }
        }

        public void PrintMatrix(){
            for (int i = 0; i < Row; i++){
                for (int j = 0; j < Column; j++){
                    Console.Write("{0,5}", MatrixArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
