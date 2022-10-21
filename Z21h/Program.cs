Console.WriteLine("Введите размерность пространства");
int N;
while (!int.TryParse(Console.ReadLine()!, out N))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите размерность пространства");
}

int i = 0;

int[] pointA = new int[N];
while (i<N)
{
    Console.WriteLine ("Введите координату точки A");
    pointA[i] = int.Parse(Console.ReadLine()!);
    i++;
}

int i2 = 0;

int[] pointB = new int[N];
while (i2<N)
{
    Console.WriteLine ("Введите координату точки B");
    pointB[i2] = int.Parse(Console.ReadLine()!);
    i2++;
}



double distance (int[] pointA, int[] pointB)
{
    double distFPow = 0;
    int i = 0;
    while (i<N)
    {
        distFPow = distFPow + Math.Pow(pointA[i]-pointB[i], 2);
        i++;
    }

    double distF = Math.Sqrt(distFPow);
    
    return distF;
   
}

double dist = Math.Round(distance(pointA, pointB), 2);

Console.WriteLine("Расстояние между точками " + dist);

