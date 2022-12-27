using static System.Console;
Clear();

// ================ Теория ==================

/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Random rnd = new Random();
int a = rnd.Next(3,9);
WriteLine(a);

int num = 1;
while(a>1)
{
    num = num + a;
    a--;
}
WriteLine(num);


/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/


Write("Введи число: ");
int a = Convert.ToInt32(ReadLine()!);
int num = 0;

while(a>0)
{
    a = a/10;
    num++;
}
WriteLine($"Кол-во цифр в числе: {num}");




/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/


Random rnd = new Random();
int a = rnd.Next(3,9);
WriteLine(a);
int num = 1;
while(a>0)
{
    num = num * a;
    a--;
}
WriteLine($"{num}");


/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

Random rnd = new Random();
int[] a = new int[8];

Write("[");
for (int i = 0; i < a.Length; i++)
{
    a[i] = rnd.Next(0,2);
    Write($"{a[i]} ");
}
Write("]");