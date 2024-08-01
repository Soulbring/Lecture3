//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = { 55, 70, 10, 94, 55, 30, 6, 55, 75, 15 };
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine(count);