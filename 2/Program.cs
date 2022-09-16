// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введите первое чило: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"{numberA} больше числа {numberB}");
}
else
{
    Console.WriteLine($"{numberB} больше числа {numberA}");
}
if (numberA == numberB)
{
    Console.WriteLine($"{numberA} равен {numberB}");
}
