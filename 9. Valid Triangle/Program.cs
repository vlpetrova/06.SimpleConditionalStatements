int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

if (sideB + sideC <= sideA)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideC + sideA <= sideB)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideA + sideB <= sideC)
{
    Console.WriteLine("Invalid Triangle");
}
else
{
    Console.WriteLine("Valid Triangle");
}
