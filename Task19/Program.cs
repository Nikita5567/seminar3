// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите первую  координату по X");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату по y");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату по x");
int x2 = Convert.ToInt32(Console.ReadLine());                              // Math.Pow(x, 2)- квадрат                                                                         // Math.Sqrt(x)- корень
Console.WriteLine("Введите вторую координату по y");
int y2 = Convert.ToInt32(Console.ReadLine());

double skobX = Math.Pow(x1 - x2, 2);
double skobY = Math.Pow(y1 - y2, 2);
double result = Math.Sqrt(skobX + skobY);
Console.WriteLine($"{result:f2}");
