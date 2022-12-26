using static System.Console;
Clear();



// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Write("Введиче 5 цифр: ");
string str = Convert.ToString(ReadLine()!);

if (str.Length < 5 | str.Length > 5)
{
    WriteLine("Ошибка! Введите 5 цифр");
    return;
}
if (str[0] == str[4])
{
    if (str[1] == str[3])
    {
        if (str[2] == str[2])
        {
            WriteLine("Полиндром");
        }
    }
}
else
{
    WriteLine("Не полиндром");
}


// То же самое, только не через строку

Write("Введите 5 чисел: ");
int str = Convert.ToInt32(ReadLine()!);
int last = str%10;
int first = str/100/100;
int a2 = str%100/10;
int a3 = str/100%100/10;

if (last == first)
{
    if (a2 == a3)
    {
        WriteLine("Полиндром");
    }
}
else
    {
        WriteLine("Не полиндром");
    }



// ========================= // =========================


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Write("Введите координату X1: ");
int x1 = Convert.ToInt32(ReadLine()!);
Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(ReadLine()!);
Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(ReadLine()!);

Write("Введите координату X2: ");
int x2 = Convert.ToInt32(ReadLine()!);
Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(ReadLine()!);
Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(ReadLine()!);

double total = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));

WriteLine($"{Math.Round(total,2)}");

// ========================= // =========================


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Write("Введите одну цифру а мы покажем таблицу кубов числа: ");
int num = Convert.ToInt32(ReadLine()!);

for (int i = 1; i < num+1; i++)
{
    Write($"{Math.Pow(i,3)}, ");
}





