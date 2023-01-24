//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, 
//является ли оно палиндромом. 
//задача 1
Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    int lastNumber = number % 10;
    int preLastNumber = (number / 10) % 10;
    int secondNumber = (number / 1000) % 10;
    int firstNumber = (number / 10000) % 10;
    if (lastNumber == firstNumber && preLastNumber == secondNumber)
    {
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }

}
else {
    Console.WriteLine("число не пятизначное");
}