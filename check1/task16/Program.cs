// Напишите программу, которая принимает на вход N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int product = 1;
for(int i = 1; i <= n; i++)
{
    product *= i;
}

Console.WriteLine("Произведение чисел от 1 до {0} равно {1}.", n, product);











