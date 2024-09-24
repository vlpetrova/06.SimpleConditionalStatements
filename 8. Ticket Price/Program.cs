string priceType = Console.ReadLine();

if (priceType == "student")
{
    Console.WriteLine("$1.00");
}
else if (priceType == "regular")
{
    Console.WriteLine("$1.60");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}