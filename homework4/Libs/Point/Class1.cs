﻿namespace Points;

public class Point{
    private double X;
    private double Y;

    // Конструктор
    public Point(double a){
        X = Math.Sin(2 * a);
        Y = Math.Cos(2 * a);
    }

    public double GetX(){
        return X;
    }

    public double GetY(){
        return Y;
    }

    // Обновление значений координат точки
    public void UpdatePointValue(double a){
        X = Math.Sin(2 * a);
        Y = Math.Cos(2 * a);
    }

    // Переопределение ToString для вывода Point
    public override string ToString(){
        return string.Format("Point: X = {0} Y = {1}", X, Y);
    }

    public static Point operator +(Point point1, Point point2){
        Point pointRes = new Point(0);
        pointRes.X = point1.X + point2.X;
        pointRes.Y = point1.Y + point2.Y;
        return pointRes;
    }

    public static Point operator +(Point point1, double value){
        Point pointRes = new Point(0);
        pointRes.X = point1.X + value;
        pointRes.Y = point1.Y + value;
        return pointRes;
    }

    public static Point operator -(Point point1, Point point2){
        Point pointRes = new Point(0);
        pointRes.X = point1.X - point2.X;
        pointRes.Y = point1.Y - point2.Y;
        return pointRes;
    }

    public static Point operator -(Point point1, double value){
        Point pointRes = new Point(0);
        pointRes.X = point1.X - value;
        pointRes.Y = point1.Y - value;
        return pointRes;
    }

    public static Point operator *(Point point1, Point point2){
        Point pointRes = new Point(0);
        pointRes.X = point1.X * point2.X;
        pointRes.Y = point1.Y * point2.Y;
        return pointRes;
    }

    public static Point operator *(Point point1, double value){
        Point pointRes = new Point(0);
        pointRes.X = point1.X * value;
        pointRes.Y = point1.Y * value;
        return pointRes;
    }

    public static Point operator /(Point point1, Point point2){
        Point pointRes = new Point(0);
        pointRes.X = point1.X / point2.X;
        pointRes.Y = point1.Y / point2.Y;
        return pointRes;
    }

    public static Point operator /(Point point1, double value){
        Point pointRes = new Point(0);
        pointRes.X = point1.X / value;
        pointRes.Y = point1.Y / value;
        return pointRes;
    }

    public static bool operator !=(Point point1, Point point2){
        if (point1.X != point2.X && point1.Y != point2.Y){
            return true;
        }
        else{
            return false;
        }
    }

    public static bool operator ==(Point point1, Point point2){
        if (point1.X == point2.X && point1.Y == point2.Y){
            return true;
        }
        else{
            return false;
        }
    }
}
