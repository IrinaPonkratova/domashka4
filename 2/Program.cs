//Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
// задача 2

Console.WriteLine("введите точку X1");
int valueX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите точку Y1");
int valueY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите точку Z1");
int valueZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите точку X2");
int valueX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите точку Y2");
int valueY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите точку Z2");
int valueZ2 = Convert.ToInt32(Console.ReadLine());

int coordinateX = valueX2 - valueX1;
int coordinateY = valueY2 - valueY1;
int coordinateZ = valueZ2 - valueZ1;

double square1 = Math.Pow(coordinateX, 2);
double square2 = Math.Pow(coordinateY, 2);
double square3 = Math.Pow(coordinateZ, 2);
double distance = Math.Sqrt(square1 + square2 + square3);

System.Console.WriteLine($"расстояние между точками равно {distance}");