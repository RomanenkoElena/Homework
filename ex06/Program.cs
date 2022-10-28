// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int currentNumber = new Random().Next(1, 100);
Console.WriteLine($"Вводим число {currentNumber}");
if (currentNumber % 2 == 0)
{
    Console.WriteLine($"Число {currentNumber} является чётным");
}
else
{
    Console.WriteLine($"Число {currentNumber} не является чётным");
}
