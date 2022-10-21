Console.WriteLine("Введите пятизначное число");

int numA;
while (!int.TryParse(Console.ReadLine()!, out numA))
{
    Console.WriteLine ("Неверный ввод");
    Console.WriteLine("Введите пятизначное число");
}

void palindrome(int numA)
{
    if (numA/10000 == 0 || numA/10000>=10) 
    {
        Console.WriteLine ("Неверный ввод");
        Console.WriteLine("Перезапустите программу");
    }
    else
    {
       if (numA/10000 == numA%10 && (numA/1000)%10 == (numA/10)%10) Console.WriteLine ("Да, введённое число является палиндромом");
       else Console.WriteLine ("Введённое число не является палиндромом");
    }
}

palindrome(numA);
