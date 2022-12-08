using System.Linq.Expressions;
Console.WriteLine("Eded daxil edin");

int n = int.Parse(Console.ReadLine());


if (n <0) 
{
    Console.WriteLine("Duzgun eded daxil edin");

}

else if (n%2==0)
{

    Console.WriteLine(n / 2);
}

else if (n % 2 != 0)
{
    Console.WriteLine(n*2);
}

