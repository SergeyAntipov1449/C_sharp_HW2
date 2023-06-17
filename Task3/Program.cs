//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введи цифру от 1 до 7, соотвертсвующую дню недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
if (dayNum < 1 || dayNum > 7)
{
    System.Console.WriteLine("Дня недели с таким номером не существует");
}
else
{
    if(dayNum == 6 || dayNum == 7)
    {
        System.Console.WriteLine("Выходной день");
    }
    else
    {
        System.Console.WriteLine("Будний день");
    }
}