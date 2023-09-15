double k1,b1,k2,b2,x,y;

k1 = Convert.ToDouble(Console.ReadLine());
b1 = Convert.ToDouble(Console.ReadLine());
k2 = Convert.ToDouble(Console.ReadLine());
b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) & (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    }

else if (k1==k2)
    {
        Console.WriteLine("Прямые параллельны");
    }

else
{
    x=(b2-b1)/(k1-k2);

    y=(k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"x= {x}y= {y}");

}
