using static System.Console;
WriteLine("Enter a number: ");
float a = float.Parse(ReadLine());
int n = 2;
while (n <= a)
{
Write(n + " ");
n = n + 2;
}