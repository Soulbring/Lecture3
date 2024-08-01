//Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] array = { 5.5, 7.41, 1.8, 3.5, 5.5, 3.5, 6.25, 5.5, 7.5, 1.5 };

double MinNumber = array[0];
double MaxNumber = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > MaxNumber)
    {
        MaxNumber = array[i];
    }
    else if (array[i] < MinNumber)
    {
        MinNumber = array[i];
    }
}

System.Console.WriteLine(MaxNumber - MinNumber);