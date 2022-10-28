// Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел

int numberA = new Random().Next(1, 100);
int numberB = new Random().Next(1, 100);
int numberC = new Random().Next(1, 100);
Console.WriteLine($"Первое число {numberA}");
Console.WriteLine($"Второе число {numberB}");
Console.WriteLine($"Третье число {numberC}");
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