Console.Clear();
Console.Write("Введите число трехзначное число: ");
int Number = int.Parse(Console.ReadLine());
int a = Number % 100;
int a1 =Number % 10;
Console.WriteLine($"Последнее число трезначного значения ({a1})");
