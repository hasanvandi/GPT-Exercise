
Console.WriteLine("Management of student grades");

Console.Write("Enter the number of students?");
int number = int.Parse(Console.ReadLine());

List<int> StudentsList = new List<int>();
int score;

for (int i  = 0; i < number; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Enter the student{i + 1} score?");
    score = int.Parse(Console.ReadLine());
    StudentsList.Add(score);
}

Console.WriteLine();

int counter = 0;
foreach(int i in StudentsList)
{
    Console.WriteLine($"student{counter + 1} grade:" +i);
    counter++;
}

Console.WriteLine();

StudentOperations(StudentsList, out int sum, out double average, out int max,out int min);
Console.WriteLine($"Total student scores:{sum}");
Console.WriteLine($"Best grade in the class:{max}");
Console.WriteLine($"Average class marks:{average}");
Console.WriteLine($"The worst grade in the class:{min}");

Console.ReadLine();

void StudentOperations(List<int> scoreStudent,out int sum,out double average,out int max,out int min)
{
    sum = scoreStudent.Sum();
    average = scoreStudent.Average();
    max = scoreStudent.Max();
    min = scoreStudent.Min();
}