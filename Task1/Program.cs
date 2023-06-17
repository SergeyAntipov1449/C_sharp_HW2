// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


System.Console.WriteLine("Введите трёхзначное число:");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number/10 <= 9 || number/10 >= 100)
{ 
    System.Console.WriteLine("Число не является трёхзначным");
}
else
{
    System.Console.WriteLine((number%100)/10);
}