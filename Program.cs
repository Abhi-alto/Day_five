Console.WriteLine("Enter a value for n till where you want 2^n");
int n=Convert.ToInt16(Console.ReadLine());
if (n > 0 && n < 31)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("2 ^ " + i + " = " + (Math.Pow(2, i)));
    }
}
else
{
    Console.WriteLine("Wrong input");
}