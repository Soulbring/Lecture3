int[] array = { 55, 70, 10, 95, 55, 35, 6, 55, 75, 15 };
int count = 0;
int i = 0;
int minRange = 9;
int maxRange = 91;

while (i < array.Length)
{
    if (array[i] > minRange && array[i] < maxRange) 
    {
        count++;
        i++;
    }
    else
    {
        i++;
    }
}
System.Console.WriteLine(count);