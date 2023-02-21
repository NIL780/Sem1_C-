Console.Clear();
Console.Write("Введите число A: ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = int.Parse(Console.ReadLine());
Console.Write("Введите число C: ");
int NumberC = int.Parse(Console.ReadLine());
int max = Convert.ToInt32(Math.Max (NumberC, Math.Max(NumberA,NumberB)));

Console.WriteLine($"Максимальное число из трех значений: ({max})");

