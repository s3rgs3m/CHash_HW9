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

int readPosInt(string msg){
    int input;
    Console.Write("\t" + msg);
    while (!(int.TryParse(Console.ReadLine(),out input)) || input < 1)
            Console.Write("\t" + msg);
    return input;
}

void outNatural(int num){
    if (num > 1){
        Console.Write ($" {num},");
        num--;
        outNatural(num);
    }
    else
        Console.Write ($" {num}");
}

Console.Clear();
Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
int n = readPosInt("Введите N: ");
Console.Write($"\tНатуральные числа от {n} до 1:");
outNatural(n);