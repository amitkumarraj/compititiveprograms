// See https://aka.ms/new-console-template for more information

public class program
{
    //const string _const; /// Compile Time Error, because constant should be initialize on declaration time
    public const string _const = "8987";

    public program()
    {
        //_const = "4343"; /// Compile  time error,  
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

    }
}


public class child
{
    public string sum()
    {
        return program._const;
    }
}

