using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double pole;

        pole = inputValue();
        Console.WriteLine("Wpisz pole");
        double obwód;

        obwód = Math.Sqrt(pole / Math.PI);
        Console.WriteLine(obwód);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}

