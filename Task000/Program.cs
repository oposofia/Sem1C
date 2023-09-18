//Нахождение квадрата числа
// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число");
int NumberA = Convert.ToInt32(Console.ReadLine());
int square = NumberA * NumberA;
Console.WriteLine(NumberA + " -> " + square);
Console.WriteLine($"{NumberA} -> {square}");

