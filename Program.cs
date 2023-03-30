// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//
// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//
// 4 -> да
// -3 -> нет
// 7 -> нет
//
// Задача 4: Напишите программу, которая на вход принимает число (N), а нfа выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine ("Введите число А->");

string valueA; // Объявление переменной типа строка
valueA = Console.ReadLine(); // Считываем с консоли строку
int numberA = Convert.ToInt32(valueA);

// int A = Console.ReadLine();

Console.WriteLine ("Введите число B->");
string valueB; // Объявление переменной типа строка
valueB = Console.ReadLine(); // Считываем с консоли строку
int numberB = Convert.ToInt32(valueB); // переводим в числовой формат

if (numberA == numberB)
    {
    Console.WriteLine ("Числа " + numberA + " и " + numberB +" равны");
    }
    else
    if (numberA > numberB)
        {
         Console.WriteLine ("Максимальное число - " + numberA);
         Console.WriteLine ("Минимальное число - " + numberB);
        }
        else
        {
        Console.WriteLine ("Максимальное число - " + numberB);
        Console.WriteLine ("Минимальное число - " + numberA);
        } //(numberB > numberA)
    //       Console.WriteLine ("Максимальное число - " + numberB);
        //   Console.WriteLine ("Минимальное число - " + numberA);
// if (numberA == numberB)
//     Console.WriteLine ("Числа " + numberA + " и " + numberB +" равны");

       