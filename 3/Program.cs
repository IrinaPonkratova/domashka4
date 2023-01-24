//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//задача 3
System.Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int result = i * i * i;
    System.Console.Write($"{result};");
}
