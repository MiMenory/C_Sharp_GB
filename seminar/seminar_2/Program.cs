﻿using static System.Console;
Clear();


// 1. Программа, которая выводит случайное число из отрезка от 10 до 99
// и показывает наибольшцю цифру этого числа.


// Random rnd = new Random();
// int rand = rnd.Next(10,99);
// WriteLine(rand);
// int a = rand%10;
// int b = rand/10;

// if (a > b)
// {
//     WriteLine($"Наибольшее число {a}");
// }
// else
// {
//     WriteLine($"Наибольшее число {b}");
// }



// =========================== // ===========================



// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int a = new Random().Next(100, 999);
// int a1 = a%10;
// int a3 = a/100;

// WriteLine($"Имеем {a}, удаляем центр, получаем {a3}{a1}");



// =========================== // ===========================


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


// int a = new Random().Next(1,11);
// int b = new Random().Next(10,99);


// if (b * b == a)
// {
//     WriteLine($"Число {b} кратно числу {a}");
// }
// else
// {
//     WriteLine($"Число {b} не кратно числу {a}. Остаток от деления: {a%b}");
// }

