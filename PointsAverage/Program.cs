using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
int x1, x2, x3, x4, x5, rating;

Console.WriteLine("Оцінка 1 (1-100):");
x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Оцінка 2 (1-100):");
x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Оцінка 3 (1-100):");
x3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Оцінка 4 (1-100):");
x4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Оцінка 5 (1-100):");
x5 = Convert.ToInt32(Console.ReadLine());

if (x1 < 1 || x1 > 100 || x2 < 1 || x2 > 100 || x3 < 1 || x3 > 100 || x4 < 1 || x4 > 100 || x5 < 1 || x5 > 100)
{
    Console.WriteLine("Оцінка не може бути менше 1 чи більше 100");
}
else
{
    rating = (x1 + x2 + x3 + x4 + x5) / 5;

    if (rating < 50)
    {
        Console.WriteLine("Нажаль, ви не набрали необхідний бал для екзамену. Ваш середній бал менший 50.");
    }
    else

        Console.WriteLine("Ви допущені до екзамену.");
}
    