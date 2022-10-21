Console.WriteLine("Введите число");

int numA;
while (!int.TryParse(Console.ReadLine()!, out numA))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите число");
}

    int numA1 = numA;
    double i = 0;
    while (numA>0)
    {
        numA = numA/10;
        i++;
    }

if (i<2) Console.WriteLine("Введено однозначное число");

else
{
 
    double i1 = Math.Pow(10, i-1);
    int b = (int)i1;

        int b2 = 1;
        int d = 1;
     
        while ((numA1/(b))%10 == (numA1/b2)%10)
        {
            b = b/10;
            b2 = b2*10;
            d++;
            if (b<10) break;
        }
            
        if (d>i/2) Console.WriteLine("Да, введённое число является палиндромом");
        else Console.WriteLine("Введённое число не является палиндромом");

}



