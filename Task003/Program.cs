using static System.Console;
WriteLine("Enter a number to find out if it is even");
float a = float.Parse(ReadLine()!);
float b = a % 2;
if (b == 0)
{
    WriteLine("number " + a + ("- even"));
}
    if (b > 0)
    {
        WriteLine("number " + a + ("- odd"));
    }
