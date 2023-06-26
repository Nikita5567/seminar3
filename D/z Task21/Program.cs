 
// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите первую  координату по X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату по y");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую  координату по Z");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую  координату по X");
int x2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату по y");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первую  координату по Z");
int z2 = Convert.ToInt32(Console.ReadLine());

double skobX = Math.Pow(x1 - x2, 2);
double skobY = Math.Pow(y1 - y2, 2);
double skobZ = Math.Pow(z1 - z1,2);
double result = Math.Sqrt(skobX + skobY + skobZ);
Console.WriteLine($"{result:f2}");