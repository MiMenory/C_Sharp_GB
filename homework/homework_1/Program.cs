using static System.Console;
Clear();


// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Write("Введите первое число: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Введите второе число: ");
int num2 = Convert.ToInt32(ReadLine()!);

if (num1 > num2)
{
    WriteLine($"Число {num1} больше {num2}");
}
else
{
    WriteLine($"число {num2} больше {num1}");
}


// ======================= // =======================


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Write("Число 1: ");
int num1 = Convert.ToInt32(ReadLine()!);
Write("Число 2: ");
int num2 = Convert.ToInt32(ReadLine()!);
Write("Число 3: ");
int num3 = Convert.ToInt32(ReadLine()!);
int max = 0;
if (num1 > num2 & num1 > num3) max = num1;
if (num2 > num1 & num2 > num3) max = num2;
if (num3 > num1 & num3 > num2) max = num3;
WriteLine(max);


// ======================= // =======================

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Write("Введите число: ");
// int num = Convert.ToInt32(ReadLine()!);

// if (num % 2 == 0)
// {
//     WriteLine($"Число {num} четное. ");
// }
// else
// {
//     WriteLine($"Число {num} не четное. ");
// }


// ======================= // =======================



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Write("Inpun number: ");
int num = Convert.ToInt32(ReadLine()!);
int max = 1;

while (max <= num)
{
    if (max % 2 == 0)
    {
        Write($"{max}, ");
    }
    max++;
}


// Альтернативный способ 

Write("Введите число: ");
int num = Convert.ToInt32(ReadLine()!);

for (int i = 1; i <= num; i++)
{
    if (i % 2 == 0)
    WriteLine($"{i} ");
}