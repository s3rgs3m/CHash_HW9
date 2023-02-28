// https://github.com/s3rgs3m/CHash_HW9.git
/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int readPosInt(string msg, bool zero = false){
    int input;
    Console.Write("\t" + msg);
    while (!(int.TryParse(Console.ReadLine(),out input)) || ( input < 1 && zero == false))
            Console.Write("\t" + msg);
    return input;
}

void writeOutNatural(int num){
    if (num > 1){
        Console.Write ($" {num},");
        num--;
        writeOutNatural(num);
    }
    else
        Console.Write ($" {num}");
}

int sumBW(int beg, int end){
    int res=0;
    if (end > beg)
        res = end + beg + sumBW(beg+1,end-1);
    else if (end==beg)
        res = end;
    return res;
}

Console.Clear();


Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
int n = readPosInt("Введите N: ");
Console.Write($"\tНатуральные числа от {n} до 1:");
writeOutNatural(n);


Console.WriteLine("\n\nЗадача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
int m = readPosInt("Введите M: ");
n = readPosInt("Введите N: ");
Console.WriteLine($"Сумма элементов: {sumBW(m,n)}");


Console.WriteLine("\nЗадача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
m = readPosInt("Введите m: ", true);
n = readPosInt("Введите n: ", true);

long akkerman(long m, long n){
    long ret=0;
    if (m==0)
        ret = n+1;
    else if (n == 0 && m!=0)
        ret = akkerman(m-1, 1);
    else 
        ret = akkerman(m-1,akkerman(m,n-1));
    return ret;
}

Console.WriteLine ($"\tA({m},{n}) = {akkerman(m,n)}");