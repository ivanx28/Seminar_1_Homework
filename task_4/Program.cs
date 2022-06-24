// Программа, показывающая максимальное число их трёх введенных

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > a && b > c) max = b;
if (c > a && c > b) max = c;

Console.Write("Максимальное число: ");
Console.WriteLine(max);