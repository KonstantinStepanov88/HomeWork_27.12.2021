// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()??"0");
int sum = 0;
while (Number > 0)
    {
    sum = sum + (Number % 10);
    Number = Number / 10;
    }
Console.WriteLine(sum);
