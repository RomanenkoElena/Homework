// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
Console.WriteLine($"Вводим первое число {numberA}");
Console.WriteLine($"Вводим второе число {numberB}");
if (numberB > numberA)
{
   Console.WriteLine($"Число {numberB} большее, число {numberA} меньшее"); 
}
else
{
    Console.WriteLine($"Число {numberA} большее, число {numberB} меньшее");
}