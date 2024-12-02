using Points;
using Tables;

class Program{
    static void Main(){
        // Применение Point 
        Console.WriteLine("==========================================================");
        Console.WriteLine("Point method:");
        Point a = new Point(4);
        Point b = new Point(25);
        Point c = a + b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine("==========================================================");

        // Применение Table
        Console.WriteLine("Table method:");
        Table table = new Table(-Math.PI, Math.PI, (Math.PI / 4));
        table.PrintTable();
        Console.WriteLine("==========================================================");
    }
}
