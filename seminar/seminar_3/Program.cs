using static System.Console;
Clear();

// array 
// Мы можем задать пустой массив: int[] array
// Или можем задать пустой массив и выделить для него ячейки памяти: int[] array = new int[4];

// Заполнение массива
// int[] array = new int[4] {1,2,3,4};

// array[2] = array[2] * 2;
// WriteLine(array[2]);


// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * 2;
//     WriteLine($"{array[i]} ");
// }

// WriteLine($"{array[array.Length-1]}");


// ================= // ======================= //

// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Write("Введите координату  X: ");
int numX = Convert.ToInt32(ReadLine()!);
Write("Введите координату  Y: ");
int numY = Convert.ToInt32(ReadLine()!);

// Берем координаты до 5

if (numX >= 1 & numX <= 5 & numY >= 1 & numY <= 5)
{
    WriteLine("Первая четверть");
}
if (numX >= -5 & numX <= -1 & numY >= 1 & numY <= 5)
{
    WriteLine("Вторая четверть");
}
if (numX >= -5 & numX <= -1 & numY >= -5 & numY <= -1)
{
    WriteLine("Третья четверть");
}
if (numX >= 1 & numX <= 5 & numY >= -5 & numY <= -1)
{
    WriteLine("Четвертая четверть");
}


// ================= // ======================= //


// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)


Write("Введите значение четверти: ");
int num = Convert.ToInt32(ReadLine()!);


if (num == 1)
{
    WriteLine("'X: +' 'Y: +' ");
}


// ================= // ======================= //


// Задача 21: Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Write("Первая координата точки X1: ");
int numX1 = Convert.ToInt32(ReadLine()!);
Write("Вторая координата точки Y1: ");
int numY1 = Convert.ToInt32(ReadLine()!);

Write("Первая координата точки X2: ");
int numX2 = Convert.ToInt32(ReadLine()!);
Write("Вторая координата точки Y2: ");
int numY2 = Convert.ToInt32(ReadLine()!);


double total = Math.Sqrt(Math.Pow(numX2 - numX1,2) + Math.Pow(numY2 - numY1,2));
WriteLine(Math.Round(total,2));


// ================= // ======================= //


// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Write("Введите число: ");
int num = Convert.ToInt32(ReadLine()!);

for (int i = 1; i < num+1; i++)
{
    WriteLine(Math.Pow(i,2));
}