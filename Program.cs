Console.WriteLine("Enter a value for n till where you want harmonic numbers");
int n=Convert.ToInt32(Console.ReadLine());
double harm = 0;
if (n < 0 || n == 0)
{
    Console.WriteLine("Wrong input");
}
else
{
    for (int i = 1; i <= n; i++)
    {
        harm = harm + (1.0/ i);
        if (i == n)
        {
            Console.Write("1/" + i + "=");
            break;
        }
        Console.Write("1/" + i + "+");
    }
    Console.WriteLine(harm);
}
