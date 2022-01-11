// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
//int i = 2;
//while ( i < number)
//{    Console.WriteLine($"куб числа {i} равен = {i * i * i}");
//    i = i + 2;
//}
for (int i = 2; i <= number; i = i+2)
    Console.WriteLine($"куб числа {i} равен = {i * i * i}");
