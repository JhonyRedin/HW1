// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (max == number2 && max == number3)
{
    System.Console.WriteLine("числа равны");
}
else if (max > number2)
{
    System.Console.WriteLine($"max = {max}");
}
else 
{
    max = number2;
    if (max>number3)
    {
    System.Console.WriteLine($"max = {max}");
    }
    else
    { 
    max = number3;
    System.Console.WriteLine($"max = {max}");
    }
}