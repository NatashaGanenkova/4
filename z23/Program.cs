// See https://aka.ms/new-console-template for more information
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
if (N < 0)
{
    N =N *(-1); 
    }
for (int j=1;j<= N; j++)
{   
     Console.WriteLine($"{Math.Pow(j,3)}");

}

