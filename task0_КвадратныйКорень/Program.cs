// 0. Демонстрация решения
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
string str = "Привет дружок!";

Console.Write("Введите целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
// int numberA = 4;
int result = numberA * numberA;
Console.WriteLine($"Квадрат числа {numberA} = {result}");
