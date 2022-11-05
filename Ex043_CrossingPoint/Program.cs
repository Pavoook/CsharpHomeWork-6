// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2. 
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double B1 = AskAndGetValue("Введите значение b1 для уравнения y = k1 * x + b1:");
double K1 = AskAndGetValue("Введите значение k1 для уравнения y = k1 * x + b1:");
double B2 = AskAndGetValue("Введите значение b2 для уравнения y = k2 * x + b2:");
double K2 = AskAndGetValue("Введите значение k2 для уравнения y = k2 * x + b2:");
double X = CrossX(K1, B1, K2, B2);
double Y = CrossY(K1, B1, X);
Console.WriteLine($"Координаты точки пересечения заданных уравнениями прямых: ({X}, {Y}).");

double AskAndGetValue(string message)
{
    Console.WriteLine(message);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double CrossX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double CrossY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}