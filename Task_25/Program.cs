/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*/

Console.Write("Введите число 'А': ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 'В': ");
int b = Convert.ToInt32(Console.ReadLine());
int degree = a;
for (int i = 1; i < b; i++)
    {
        degree = degree * a;
    }
Console.Write($"{a} в степени {b} равно {degree}");