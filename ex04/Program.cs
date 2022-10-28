// Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел

int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
int numberC = new Random().Next(1, 100);
Console.WriteLine($"Вводим первое число {numberA}");
Console.WriteLine($"Вводим второе число {numberB}");
Console.WriteLine($"Вводим третье число {numberC}");
int max_number = numberA;
if (numberB > numberA)
{
    max_number = numberB;
}
if (numberC > max_number)
{
    max_number = numberC;
}
Console.WriteLine($"Максимальное число {max_number}");