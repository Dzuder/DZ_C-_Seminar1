using static System.Console;
WriteLine("Enter the first number: ");
int a = int.Parse(ReadLine()!);
WriteLine("Enter the second number: ");
int b = int.Parse(ReadLine()!);
WriteLine("Enter the third number: ");
int c = int.Parse(ReadLine()!);
int max = a;
if (b > a)
{
max = b;
}
if (c > b)
{
max = c;
}
WriteLine("The largest number of three- " + max);

