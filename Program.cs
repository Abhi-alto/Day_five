Console.WriteLine("Enter a year you want to check for Leap Year in the format yyyy");
int y=Convert.ToInt32(Console.ReadLine());
int ye = y;                  //alternate variable for year
int d = 0;                         //digit variable
while(y>0)                  //to check no. of digits of the year
{
    d++;
    y = y / 10;
}
if(d>3&&d<5)
{
    if(ye%4==0)
    {
        if(ye%400==0)                       //Checking if the year is a century and a leap year
        {
            Console.WriteLine("This century is a leap year");
        }
        else
        {
            Console.WriteLine("This year is a leap year");
        }
    }
    else
    {
        Console.WriteLine("Not a leap year");
    }
}
else
{
    Console.WriteLine("Wrong input");
}