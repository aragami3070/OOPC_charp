using Points;
class Program{
    static void Main(){
        Console.WriteLine("Test");
        Point a = new Point(4);
        Point b = new Point(25);
        Point c = a + b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
