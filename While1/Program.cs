using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
int n, c = 0, fact = 1;
double a=0, b=0;
Console.WriteLine("Введіть значення n:");
n = Convert.ToInt32(Console.ReadLine());

a = MetodA(n);
b = MetodB(n);
c = MetodC(n);
Console.WriteLine("a={0}\n", a);
Console.WriteLine("b={0}\n", b);
Console.WriteLine("c={0}\n", c);
static double MetodA(int n)
{
    double a = 0;
    for (int i = 1; i <= n; i++)
    {
        a += Math.Pow(-1, i) / (2 * i + 1);
    }
    return a;
}
static double MetodB(int n)
{
    double b = 0;
    for (int i = 1; i <= n; i++)
    {
        b += 1 + (1.0 / Math.Pow (i,2));
    }
    return b;
}
static int MetodC(int n)
{
    int c = 0, fact = 1;
for (int i = 1; i <= n; i++)
{
    fact *= i;
    c += fact;
}
return c;
}