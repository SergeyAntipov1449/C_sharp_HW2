// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number/100 < 1)
{
    System.Console.WriteLine("Третья цифра отсутствует");
}
else {
    while (number/100 > 10)
    {
        number = number/10;
    }
    System.Console.WriteLine(number%10);
};
