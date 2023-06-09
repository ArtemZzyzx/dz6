/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"В массиве [{String.Join("; ", array)}] количество числел больше нуля равно: {count}");