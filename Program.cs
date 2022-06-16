int times = 0, h = 0, t = 0;            //counters for head and tail and no. of times for flip
while (times < 1)                        //takes input until user gives a positive integer
{
    Console.WriteLine("How many times do you want to flip coin");
    times = Convert.ToInt16(Console.ReadLine());
    if (times > 0)                                    
    {
        for (int i = 0; i < times; i++)
        {
            double flip = new Random().NextDouble();
            if (flip > 0.5)
            {
                h++;
            }
            else
            {
                t++;
            }
        }
       Console.WriteLine("Percentage of heads in the total flips = " + (((double)h / times) * 100)+" %");
        Console.WriteLine("Percentage of tails in the total flips = " + (((double)t / times) * 100)+" %");
    }
    else
    {
        Console.WriteLine("Wrong Input");
    }
}
