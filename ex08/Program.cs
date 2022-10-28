// Напишите программу, которая на вход принимает число(N),а на выходе показывает все чётные числа от 1 до N

int numberN = new Random().Next(1, 100);
Console.WriteLine($"Вводим число {numberN}");
int startNumber = 2;
int endNumber = numberN;
Console.WriteLine($"Чётные числа от 1 до {numberN}:");
while (startNumber <= numberN)
{
    Console.WriteLine(startNumber);
    startNumber += 2;
}
