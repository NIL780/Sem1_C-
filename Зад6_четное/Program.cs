﻿Console.Clear();
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());
if(Number%2==0)
    {Console.WriteLine($"Да,{Number} число является четным");}
   else
     {Console.WriteLine($"НЕТ,{Number} число НЕЧЕТНОЕ");}
     