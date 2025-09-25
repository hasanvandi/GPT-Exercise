using System.ComponentModel;

Console.WriteLine("Calculator");

Console.Write("please enter number1:");
int num01 =int.Parse(Console.ReadLine());
Console.Write("please enter number2:");
int num02 = int.Parse(Console.ReadLine());

Meno();

char userInput = Console.ReadKey().KeyChar;
bool isValied = false;


while (!isValied)
{
    switch (userInput)
    {
        case '+':
            Console.WriteLine();
            Console.WriteLine($"Sum is:{Add(num01, num02)}");
            isValied = true;
            break;
        case '-':
            Console.WriteLine();
            Console.WriteLine("Subtraction is:" + subtraction(num01, num02));
            isValied = true;
            break;
        case '*':
            Console.WriteLine();
            Console.WriteLine($"multiplication is:{multiplication(num01, num02)}");
            isValied = true;
            break;
        case '/':
            Console.WriteLine();
            Console.WriteLine($"division is :{division(num01, num02)}");
            isValied = true;
            break;
        case 'E':
        case 'e':
            isValied = true;
            break;
        default:
            Console.WriteLine();
            Console.WriteLine("please enter correct character");
            Meno();
            userInput = Console.ReadKey().KeyChar;
            break;
    }
}

Console.ReadLine();
int Add(int number01,int number02)
{
    return number01 + number02;
}

int subtraction(int number01, int number02)
{
    return number01 - number02;
}

int multiplication(int number01, int number02)
{
    return number01 * number02;
}

double division(int number01, int number02)
{
    return number01 / number02;
}

void Meno()
{
    Console.WriteLine("[+] The sum of two numbers");
    Console.WriteLine("[-] Subtracting two numbers");
    Console.WriteLine("[*] Multiply two numbers");
    Console.WriteLine("[/] Divide two numbers");
    Console.WriteLine("[E] Exit");
}