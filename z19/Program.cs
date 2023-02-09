// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int i = num / 10000;
int b = num % 10;
int c = num / 1000;
int d = c % 10;
int f = num % 100;
int g = f/10;

if (i == b && d==g)
{
    Console.WriteLine("Является палиндромом");
    return;
}

else
{
    Console.WriteLine("Не является палиндромом");
}