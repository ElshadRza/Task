
    internal class Security:Person
{
    public int CustomerID;
    public bool CustomerWithGirl;
    public string WhoIsYourDad;

    public static string Ask(string statement)
    {
        Console.WriteLine();
        return statement;
    }
    public static string Read(string statement)
    {
        statement=Console.ReadLine();
        return statement;
    }
    
    public Security()
    {
        
        while(true)
        {

            Ask("Name?");
        Read (FirstName);

        Ask("Last Name?");

        Read(LastName);

        Ask("How old are you?");

        Read();

        Ask("Who is your dad?");

            Read(WhoIsYourDad);
        }
    }
}

