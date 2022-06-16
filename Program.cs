using Day_five_assignment;
Console.WriteLine("Enter a value whose prime factors you want");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prime factorization of " + n + " = ");
for (int i = 2; i <= (n / 2); i++)            //factors are only from 2 to the half of the number
{
    while (n % i == 0)              
    {
        Console.WriteLine(i + " ");
        n = n / i;                          //remove that particular factor by updating the number value
    }
}
if(n>1)
{
    Console.WriteLine(n);
}
else
{
    Console.WriteLine("Error");
}