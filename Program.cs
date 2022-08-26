Console.WriteLine("Press array length:");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Press value {i + 1}:");
    array[i] = Console.ReadLine();
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
        Console.Write($"{array[i]} ");
}