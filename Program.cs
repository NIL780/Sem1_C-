Console.Clear();
Console.Write("Введите число A: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = int.Parse(Console.ReadLine());
int min = Math.Min(NumberA, NumberB);
int max = Math.Max(NumberA, NumberB);

Console.WriteLine($"Максимальное число из двух значений: ({max})");
Console.WriteLine($"Минимальное число: ({min})");

