// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

Console.WriteLine("\t GPA");
double math, english, physics, chemistry, biology;
double total;
double average;
Console.Write("math : ");
math = Convert.ToDouble(Console.ReadLine());
if (math>100 || math<0)
{
Console.WriteLine("Enter correct number ");
Environment.Exit(0);
}
Console.Write("english : ");
english = Convert.ToDouble(Console.ReadLine());
if (english>100 || english<0)
{
Console.WriteLine("Enter correct number ");
Environment.Exit(0);
}
Console.Write("physics : ");
physics = Convert.ToDouble(Console.ReadLine());
if (physics>100 || physics<0)
{
Console.WriteLine("Enter correct number ");
Environment.Exit(0);
}
Console.Write("chemistry : ");
chemistry = Convert.ToDouble(Console.ReadLine());
if (chemistry>100 || chemistry<0)
{
Console.WriteLine("Enter correct number ");
Environment.Exit(0);
}
Console.Write("biology : ");
biology = Convert.ToDouble(Console.ReadLine());
if (biology>100 || biology<0)
{
Console.WriteLine("Enter correct number ");
Environment.Exit(0);
}
total=math+english+physics+chemistry+biology;
Console.WriteLine(total);
average=total/5;
Console.WriteLine(average);
if(average>=90 && average<100)
{
    Console.WriteLine("A");
}
else if(average>=80 && average<90)
{
    Console.WriteLine("B");
}
else if(average>=70 && average<80)
{
    Console.WriteLine("C");
}
else if(average>=60 && average<70)
{
    Console.WriteLine("D");
}
else if(average>=50 && average<60)
{
    Console.WriteLine("D-");
}
else
{
    Console.WriteLine("F");
}

    }
}