// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int Mult = 1;
int i = 2;
while ( i <= N)
{
    Mult = Mult * i;
    i++;
}
Console.WriteLine($"Произведение чисел от 1 до N равно = {Mult}");
