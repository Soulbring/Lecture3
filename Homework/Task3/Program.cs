using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
        //Напишите свое решение здесь
        double MinNumber = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (MinNumber > numbers[i])
            {MinNumber = numbers[i];}
        }
        return MinNumber;
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
        //Напишите свое решение здесь
        double MaxNumber = numbers[0];
        for(int i = 0; i < numbers.Length;i++)
        {if (MaxNumber < numbers[i])
        {MaxNumber = numbers[i];}}
        return MaxNumber;
    }
    
    
    
    
    public static void PrintResult(double[] array)
    {
        //Напишите свое решение здесь
        double diff = FindMax(array) - FindMin(array);
        Console.WriteLine(diff);
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}