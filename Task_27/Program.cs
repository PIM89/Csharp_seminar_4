/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11 82 -> 10 9012 -> 12*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num.ToString().Length];
int sum = 0;
int k = num;
for (int i = 0; i < num.ToString().Length; i++)
    {
        array[i] = k % 10;
        sum = sum + array[i];
        k = k / 10;
    }
Console.WriteLine($"Сумма цифр в числе равна: {sum}");