Console.WriteLine("Enter a letter ");
char n = Convert.ToChar(Console.ReadLine());
n = char.ToUpper(n);
if (n > 64 && n < 91)
{
    if (n == 'A' || n == 'E' || n == 'I' || n == 'O' || n == 'U')
    {
        Console.WriteLine("Vowel");
    }
    else
    {
        Console.WriteLine("Consonant");
    }
}
else
{
    Console.WriteLine("Wrong input");
}