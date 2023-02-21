Console.Clear();
int sqr=0;

Console.Write("Введите число: ");
int Number = Convert.ToInt32 (int.Parse(Console.ReadLine()));
while (sqr<=Number)
    {
        if(sqr%2==0)
        {Console.WriteLine($"Четные числа: ({sqr})");
    }
    sqr++;
   }