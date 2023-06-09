using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double w, h;

        Console.WriteLine("Wprowadź wzrost");
        w = inputValue();
        Console.WriteLine("Wprowadź wagę");
        h = inputValue();
        double bMI;

        bMI = w / Math.Pow(h, 2);
        Console.WriteLine("Twoja wartość BMI to");
        Console.WriteLine(bMI);
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

