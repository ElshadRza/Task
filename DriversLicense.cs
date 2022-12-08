Console.WriteLine("Yashinizi daxil edin");
int age= int.Parse(Console.ReadLine());

int limit = 18;
int year = limit - age;


if (age < 0 || age >100)
{
    Console.WriteLine("Duzgun eded daxil edin!");
}
else if (age < 18)
{

    Console.WriteLine($"Siz suruculuk vesiqesi ala bilmezsiniz.Sizin suruculuk vesiqesi ala bilmeyiniz ucun {year} iliniz var.");

}

else if (age<66 && age>=18)
{
    Console.WriteLine("Siz suruculuk vesiqesi ala bilersiniz.");
}
else if (age > 65)
{
    Console.WriteLine("Teesuf ki,siz suruculuk huququ ucun olan maksimum yash heddini kecmisiniz.");
}






