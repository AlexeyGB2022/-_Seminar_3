Console.WriteLine("Введите координаты двух точек в 3D пространстве");

int[] pointA = new int[3];
Console.WriteLine ("Введите координату x точки A");
pointA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите координату y точки A");
pointA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите координату z точки A");
pointA[2] = int.Parse(Console.ReadLine()!);

int[] pointB = new int[3];
Console.WriteLine ("Введите координату x точки B");
pointB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите координату y точки B");
pointB[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine ("Введите координату z точки B");
pointB[2] = int.Parse(Console.ReadLine()!);

double distance (int[] pointA, int[] pointB)
{
    double distF = Math.Sqrt(Math.Pow(pointA[0]-pointB[0], 2) + Math.Pow(pointA[1]-pointB[1], 2) + Math.Pow(pointA[2]-pointB[2], 2));
    return distF;
}

double dist = Math.Round(distance(pointA, pointB), 2);

Console.WriteLine("Расстояние между точками " + dist);