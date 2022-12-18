using static System.Console;
WriteLine("Enter the first number :");
int a = int.Parse(ReadLine()!);
WriteLine("Enter the second number :");
int b = int.Parse(ReadLine()!);

if (a > b)
{
    WriteLine("The largest number " + a);
}
else 
{
        WriteLine( "The largest number " + b);
}