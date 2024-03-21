// Задача 1: Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

int CheckParity (int n)
{   
    int a = n/10;
    int b = n%10;
    int c = a+b;
    while (c%2==0)
    {
        break;
    }
    return n;
}
    
string CheckLetter (string n)
{   
    while (n==q)
    {
        break;
    }
    return n;
}

System.Console.WriteLine("Введите целое двузначное число");
int n = Convert.ToInt32(Console.ReadLine ());
CheckParity (n);
CheckLetter (n);

