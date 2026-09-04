using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
          Console.WriteLine("\tThe First Project (C#)\n");
          Console.WriteLine("\tMultiplication Table\n");
        double num;
        Console.WriteLine("Enter the number: ");
        num = Convert.ToDouble(Console.ReadLine());
        for (double x=0; x<=12; x++)
        {
            Console.WriteLine(num + "*" + x + "=" + num*x);
        }
    }
}