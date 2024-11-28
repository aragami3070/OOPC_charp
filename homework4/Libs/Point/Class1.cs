namespace Points;

public class Point{
    private double X;
    private double Y;

    // Конструктор
    public Point(double a){
        X = a * a;
        Y = Math.Sqrt(a);
    }

    public double GetX(){
        return X;
    }

    public double GetY(){
        return Y;
    }

    // Обновление значений координат точки
    public void UpdatePointValue(double a){
        X = a * a;
        Y = Math.Sqrt(a);
    }

    // Переопределение ToString для вывода Point
    public override string ToString(){
        return string.Format("Point: X = {0} Y = {1}", X, Y);
    }
}
