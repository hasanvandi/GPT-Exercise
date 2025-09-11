Console.WriteLine("Hello every body");

Console.Write("Please enter number1:");
int num01 = int.Parse(Console.ReadLine());

Console.Write("Please enter number2:");
int num02 = int.Parse(Console.ReadLine());

int sum = num01 + num02;
int sub = num01 - num02;
int mult = num01 * num02;
int div = num01 / num02;
int rem = num01 % num02;



Console.WriteLine($"sum is:{sum}");
Console.WriteLine($"subtraction is:{sub}");
Console.WriteLine($"multiplication is:{mult}");
Console.WriteLine($"division is:{div}");
Console.WriteLine($"remaining num01 to num02 is:{rem}");


Console.WriteLine("A combined operation:");
int result = ((sum % div) - (2 * mult + rem));
Console.WriteLine("rsult:" + result);

Console.WriteLine();