//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты для точки a: ");
double a1 = Convert.ToDouble(Console.ReadLine());
double a2 = Convert.ToDouble(Console.ReadLine());
double a3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты для точки b: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double b3 = Convert.ToDouble(Console.ReadLine());

double distans = Math.Sqrt(Math.Pow((a1-b1), 2) + Math.Pow((a2-b2), 2) + Math.Pow((a3-b3), 2));

Console.WriteLine($"Расстояние между a и b = {Math.Round(distans, 3)}");
