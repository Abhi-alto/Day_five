Console.WriteLine("Enter number 1");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter number 2 ");
int b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter number 3");
int c = Convert.ToInt16(Console.ReadLine());
if (a != b && b != c)
{
    int temp = (a > b ? a : b);
    int max = (temp > c ? temp : c);
    Console.WriteLine("Greatest of the three is " + max);
}
else if (a != b && b == c)
{
    int max =( a > c ? a : c);
    Console.WriteLine("b & C are equal and the greatest is " + max);
}
else if (a == b && b != c)
{
    int max = (a > c ? a : c);
    Console.WriteLine("a & b are equal and the greatest is " + max);
}
else if (a == c && b != c)
{
    int max = (a > b ? a : b);
    Console.WriteLine("a & c are equal and the greatest is " + max);
}
else
{
    Console.WriteLine("All three no. are same");
}
