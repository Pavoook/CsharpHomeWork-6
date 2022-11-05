// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] array = GetArrayFromString(AskAndGetString("Введите несколько целых чисел через запятую:"));
int positiveCount = GetPositiveCount(array);
Console.WriteLine($"Количество введенных положительных чисел равно {positiveCount}.");

string AskAndGetString(string message)
{
    Console.WriteLine(message);
    string inputString = Console.ReadLine();
    return inputString;
}

int[] GetArrayFromString(string stringArray)
{
    string[] numbers = stringArray.Split(",", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

int GetPositiveCount(int[] collection)
{
    int counter = 0;
    foreach (int i in collection)
    {
        if (i > 0) counter++;
    }
    return counter;
}