// Программа, отображающая все чётные числа от 1 до введенного числа.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int x = 1;

while (x <= num)
{
    if (x %2 == 0)
    {
        Console.WriteLine(x);
        x ++;   
    }
    else
    {
        x ++;
    }
}