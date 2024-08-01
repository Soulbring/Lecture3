System.Console.WriteLine("Введите количество чисел в массиве");
int ArrayLenght = Convert.ToInt32(System.Console.ReadLine());

int[] numbers = new int[ArrayLenght];
int n = 0;
while (n < numbers.Length)
{
    System.Console.WriteLine($"Введите {n + 1}-е число");
    numbers[n] = Convert.ToInt32(System.Console.ReadLine());
    n++;

}


int count = 0;
int i = 0;
int minRange = 9;
int maxRange = 91;

while (i < numbers.Length)
{
    if (numbers[i] > minRange && numbers[i] < maxRange)
    {
        count++;
        i++;
    }
    else
    {
        i++;
    }
}
System.Console.WriteLine($"Количество чисел в диапазоне от 10 до 90 равно {count}");