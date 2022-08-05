/*Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Введите цифры через ',': ");
string text = Console.ReadLine();
string[] array = text.Split(',');
int[] mas = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    mas[i] = Convert.ToInt32(array[i]);
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
PrintArray(mas);