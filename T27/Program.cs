//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11   82 -> 10   9012 -> 12
int FigureSum(int a)
{
    if (a < 0) a = Math.Abs(a);
    int n = default;
    while (a > 0)
    {
        n = n + a % 10;
        a = a / 10;
    }
    return n;
}
Console.Write("Введите целое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр в числе {x} =>  {FigureSum(x)}");