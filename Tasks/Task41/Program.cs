// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите M чисел через пробел: ");
int[] arrayOfNumber = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int count = 0;
for (int i = 0; i < arrayOfNumber.Length; i++)
{
    if (arrayOfNumber[i] > 0) count++;
}
Console.WriteLine($"Количество чисел больше 0: {count}");