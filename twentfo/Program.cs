using System;

public struct PointStruct
{
    public int X { get; set; }
    public int Y { get; set; }

    public PointStruct(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class PointClass
{
    public int X { get; set; }
    public int Y { get; set; }

    public PointClass(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Program
{
    public static void ModifyPoint(PointStruct point)
    {
        point.X += 10;
        point.Y += 10;
    }

    public static void ModifyPoint(PointClass point)
    {
        point.X += 10;
        point.Y += 10;
    }

    public static void Main()
    {
        PointStruct structPoint = new PointStruct(5, 5);
        PointStruct structPointCopy = structPoint;
        structPointCopy.X = 20;
        structPointCopy.Y = 20;

        Console.WriteLine("Исходная структура: X = " + structPoint.X + ", Y = " + structPoint.Y);
        Console.WriteLine("Копия структуры: X = " + structPointCopy.X + ", Y = " + structPointCopy.Y);

        PointClass classPoint = new PointClass(5, 5);
        PointClass classPointCopy = classPoint;
        classPointCopy.X = 20;
        classPointCopy.Y = 20;

        Console.WriteLine("Исходный класс: X = " + classPoint.X + ", Y = " + classPoint.Y);
        Console.WriteLine("Копия класса: X = " + classPointCopy.X + ", Y = " + classPointCopy.Y);

        ModifyPoint(structPoint);
        Console.WriteLine("Структура после ModifyPoint: X = " + structPoint.X + ", Y = " + structPoint.Y);

        ModifyPoint(classPoint);
        Console.WriteLine("Класс после ModifyPoint: X = " + classPoint.X + ", Y = " + classPoint.Y);
    }
}
