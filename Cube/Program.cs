// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()??"0");
int i = 1;
while (i <= number )
    {
        Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");
        i++;
    }