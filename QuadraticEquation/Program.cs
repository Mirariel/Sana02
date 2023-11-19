using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
double x1, x2, a, b, c, D;

Console.WriteLine("Enter a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b: ");
b = Convert.ToDouble(Console.ReadLine()); 
Console.WriteLine("Enter c: ");
c = Convert.ToDouble(Console.ReadLine());
D = b * b - 4 * a * c;
if (a == 0)
{
    x1 = -c / b;
    Console.WriteLine("Корінь рівняння {0}\n", x1);
}
else if (D > 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("Корінь х1 = {0}\n", x1);
    Console.WriteLine("Корінь х2 = {0}\n", x2);
}
else if (D == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine("Корінь рівняння {0}\n", x1);
}
else if (D < 0)
{
    Console.WriteLine("Коренів немає\n");
}
