Console.Write("Please Enter number in range 0 to 20:");
int number = int.Parse(Console.ReadLine());



if(number > 20 || number < 0)
{
    Console.WriteLine("Please enter the correct range.");
}
else if (number < 10)
{
    Console.WriteLine("Rejected");
}
else if (number > 10 && number <= 14)
{
    Console.WriteLine("Conditional acceptance.");
}
else
{
    Console.WriteLine("Successfully accepted");
}


Console.ReadLine();