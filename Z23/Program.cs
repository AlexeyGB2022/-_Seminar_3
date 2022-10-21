Console.WriteLine("Введите число");

int numA;
while (!int.TryParse(Console.ReadLine()!, out numA))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите число");
}


int[] Cubing(int numA)
{
    int[] cubicNumbersF = new int[numA];
    
    for (int i = 0; i < numA; i++)
    {
        cubicNumbersF[i] = (i + 1) * (i + 1)* (i + 1);
    }
    return cubicNumbersF;
}

int[] cubicNumbers = Cubing(numA);


int number = 1;
for (int i = 0; i < cubicNumbers.Length; i++)
{
    Console.Write($"{number} ^ 3 = ");
    Console.WriteLine($"{cubicNumbers[i]}");
    number++;
}













