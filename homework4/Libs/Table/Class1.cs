namespace Tables;

public class Table{
    private double[]? PiTable;

    // Вывод таблицы
    public void PrintTable(){
        if (PiTable != null){
            Console.Write("[");
            for (int i = 0; i < PiTable.Length; ++i){
                Console.Write(PiTable[i] + "; ");
            }
            Console.WriteLine("]");
        }
        else{
            Console.WriteLine("Null Table");
        }
    }

    // Конструктор
    public Table(double start, double end, double step){
        // Расчет размерности
        int size = Convert.ToInt32((Math.Abs(start) + Math.Abs(end)) / step) + 1;
        PiTable = new double[size];
        for (int i = 0; i < size; ++i){
            PiTable[i] = start + i * step;
        }
    }
}
